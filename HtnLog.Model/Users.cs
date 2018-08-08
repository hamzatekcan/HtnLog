using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
namespace HtnLog.Model
{
   public class Users
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string authority { get; set; }
        public bool active { get; set; }
    }
}
