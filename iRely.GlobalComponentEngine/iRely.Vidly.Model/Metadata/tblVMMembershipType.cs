using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRely.Vidly.Model.Metadata
{
    public class tblVMMembershipType : iRely.Common.BaseEntity
    {
        public int intMembershipTypeId { get; set; }
        [Required]
        [Column("strName")]
        public string strMembershipTypeName { get; set; }
        public int intSignUpFee { get; set; }
        public int intDurationInMonths { get; set; }
        public int intDiscountRate { get; set; }
    }
}
