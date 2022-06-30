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
    public class RentalDetailBl : BusinessLayer<tblVMRentalDetail>, IRentalDetailBl
    {
        public RentalDetailBl(IVidlyRepository db) : base(db)
        {
        }

        public override async Task<GetObjectResult> GetAsync(GetParameter param)
        {
            var query = _db.GetQuery<tblVMRentalDetail>().Filter(param);
            var data = await query.Select(s => new
            {
                s.intRentalDetailId,
                s.intRentalHeaderId,
                s.intMovieId,
                strMovieName = s.tblVMMovie.strMovieName,
                s.dtmDateReturned,
                s.intConcurrencyId
            }).ToListAsync(param.cancellationToken);

            return new GetObjectResult()
            {
                data = data,
                total = await query.CountAsync(param.cancellationToken)
            };
        }
    }
}
