using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtnLog.Model
{
   public class Contents
    {
        public int id { get; set; }
        public string tittle { get; set; }
        public string text { get; set; }
        public string defaultImage { get; set; }
        public bool active { get; set; }
        public Nullable<DateTime> uploadDate { get; set; }

    }
}
