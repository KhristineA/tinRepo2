using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRely.Vidly.Model.Metadata
{
    public class tblVMCustomer : iRely.Common.BaseEntity
    {
        public int intCustomerId { get; set; }
        [Required]
        [StringLength(255)]
        [Column("strName")]
        public string strCustomerName { get; set; }

        public bool ysnIsSubscribedToNewsletter { get; set; }
        public tblVMMembershipType tblVMMembershipType { get; set; }
        [NotMapped]
        public string strMembershipTypeName { get; set; }
        public int intMembershipTypeId { get; set; }
        public DateTime? dtmBirthdate { get; set; }
    }
}
