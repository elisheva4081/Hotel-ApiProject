using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.core.Enentities
{
    public class Date
    {
        private DateTime dateTime;
        private string v;

        public DateTime TheDate { get; set; }
        public string Butcher { get; set; }
        public string NameGuide { get; set; }

        public Date(DateTime date, string butcher,string nameGuide)
        {
            TheDate = date;
            Butcher = butcher;
           NameGuide=nameGuide;
        }

        
    }
}
