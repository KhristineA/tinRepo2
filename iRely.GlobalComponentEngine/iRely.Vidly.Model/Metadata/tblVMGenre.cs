using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRely.Vidly.Model.Metadata
{
    public class tblVMGenre : iRely.Common.BaseEntity
    {
        public int intGenreId { get; set; }

        [Required]
        [StringLength(255)]
        public string strName { get; set; }
    }
}
