using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRely.Vidly.Model.Metadata
{
    public class tblVMRentalDetail : iRely.Common.BaseEntity
    {
        [Key]
        public int intRentalDetailId { get; set; }
        public int intRentalHeaderId { get; set; }
        //public RentHeader RentHeader { get; set; }
        public int intMovieId { get; set; }
        [NotMapped]
        public string strMovieName { get; set; }
        public tblVMMovie tblVMMovie { get; set; }
        public DateTime? dtmDateReturned { get; set; }
    }
}
