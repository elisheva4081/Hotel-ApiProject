using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.core.Enentities
{
    public class Date
    {
        [Key]
        public DateTime TheDate { get; set; }
        public string Butcher { get; set; }
        public string NameGuide { get; set; }

    }
}
