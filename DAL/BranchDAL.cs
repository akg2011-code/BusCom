using DatabaseCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testProj.DAL
{
    public class BranchDAL
    {
        DatabaseCodeFirst.contextDB.DatabaseContext context = new DatabaseCodeFirst.contextDB.DatabaseContext();
        public Branch GetBranchByName(string _name) 
        {
            return context.Branches.Where(b=>b.BranchName == _name).FirstOrDefault();
        }
    }
}
