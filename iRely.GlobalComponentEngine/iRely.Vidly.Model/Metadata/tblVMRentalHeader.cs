using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [NotMapped]
        public string strCustomerName { get; set; }
        public tblVMCustomer tblVMCustomer { get; set; }
        public DateTime dtmDateRented { get; set; }
        public ICollection<tblVMRentalDetail> tblVMRentalDetail { get; set; } //= new List<tblVMRentalDetail>();
    }
}
