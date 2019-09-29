using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DatabaseLayer;

namespace CodeFirst_UserModel
{
    class MainCall
    {
        static void Main(string[] args)
        {
            SeedUser.AddUserValue();
            Operations.AddEntity();
            Operations.Add1Entity();
            Operations.DeleteEntity();
            ReportQuery.StoredProcedure();
            ReportQuery.AddCount();
            ReportQuery.UserOrderby();


        }
    }
}
