using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRely.Vidly.Model.Metadata
{
    public class tblVMMovie : iRely.Common.BaseEntity
    {
        public int intMovieId { get; set; }

        [Required]
        [StringLength(255)]
        public string strName { get; set; }

        public tblVMGenre tblVMGenre { get; set; }


        [Required]
        public int intGenreId { get; set; }

        public DateTime dtmDateAdded { get; set; }

        [Required]
        public DateTime dtmReleaseDate { get; set; }

        [Range(1, 20)]
        [Required]
        public int intNumberInStock { get; set; }
        public int intNumberAvailable { get; set; }
    }
}
