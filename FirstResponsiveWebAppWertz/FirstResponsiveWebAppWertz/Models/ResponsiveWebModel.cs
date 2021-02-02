using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstResponsiveWebAppWertz.Models
{
    public class ResponsiveWebModel
    {
        public const int THIS_YEAR = 2021;
           [Required]
           public string Name { get; set; }
           [Required]
           [Range(1900, 2021)]
           public int? BirthYear { get; set; }

           public int AgeThisYear()
        {
            return THIS_YEAR - BirthYear.Value;
        }
    }
}
