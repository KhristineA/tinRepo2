using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRely.Vidly.Model.Metadata
{
    public class tblVMRentalHeader : iRely.Common.BaseEntity
    {
        [Key]
        public int intRentalHeaderId { get; set; }
        public int intCustomerId { get; set; }
        public tblVMCustomer tblVMCustomer { get; set; }
        public DateTime dtmDateRented { get; set; }
        //public List<RentDetail> RentDetail { get; set; } = new List<RentDetail>();
    }
}
