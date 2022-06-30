using iRely.Common;
using iRely.Vidly.BusinessLayer.Interface;
using iRely.Vidly.Model.Metadata;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRely.Vidly.BusinessLayer.Implementation
{
    public class MovieBl : BusinessLayer<tblVMMovie>, IMovieBl
    {
        public MovieBl(IVidlyRepository db) : base(db)
        {
        }
        public override async Task<GetObjectResult> GetAsync(GetParameter param)
        {
            var query = _db.GetQuery<tblVMMovie>().Filter(param);
            var data = await query.Select(s => new
            {
                s.intMovieId,
                s.strMovieName,
                s.intGenreId,
                strGenreName = s.tblVMGenre.strGenreName,
                s.dtmDateAdded,
                s.dtmReleaseDate,
                s.intNumberInStock,
                s.intNumberAvailable,
                s.intConcurrencyId
            }).ToListAsync(param.cancellationToken);

            return new GetObjectResult()
            {
                data = data,
                total = await query.CountAsync(param.cancellationToken)
            };
        }

        public override async Task<SearchResult> Search(GetParameter param)
        {
            var query = _db.GetQuery<tblVMMovie>().Filter(param, true);
            var data = await query.Select(s => new
            {
                s.intMovieId,
                s.strMovieName,
                strGenreName = s.tblVMGenre.strGenreName
            }).ExecuteProjection(param, "intMovieId", "DESC").ToListAsync(param.cancellationToken);

            return new SearchResult()
            {
                data = data.AsQueryable(),
                total = await query.CountAsync(param.cancellationToken),
                summaryData = await query.ToAggregateAsync(param.aggregates)
            };
        }
    }
}
