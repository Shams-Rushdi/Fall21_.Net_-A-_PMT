using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class DataAccessFactory
    {
        static PMAEntities db;
        static DataAccessFactory()
        {
            db = new PMAEntities();
        }

    }
}
