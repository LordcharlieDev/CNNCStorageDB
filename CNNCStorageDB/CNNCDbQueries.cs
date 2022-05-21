using CNNCStorageDB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNNCStorageDB
{
    public class CNNCDbQueries
    {
        private readonly CNNCDbContext db;

        public CNNCDbQueries(CNNCDbContext context)
        {
            db = context;
        }
    }
}
