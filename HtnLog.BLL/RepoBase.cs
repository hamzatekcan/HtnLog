using HtnLog.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtnLog.BLL
{
    public class RepoBase<T, param> where T:class
    {
        protected HtnLogEntities context =new HtnLogEntities();   
        public List<T> GetAll()
        {
            return
        }
    }
}
