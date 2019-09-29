using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using DatabaseLayer;
using EntityTables;

namespace CodeFirst_UserModel
{
    public class ReportQuery
    {
        public ReportQuery() { }

        public static void StoredProcedure()
        {
            using (var ctx = new EntityMappingContext ())
            {
                var parmv = new SqlParameter { ParameterName = "@ContactId", Value = 1, DbType = System.Data.DbType.String };
                var Cnt = ctx.Database.SqlQuery<Contact>("EXEC GetContactId @ContactId", parmv).ToList<Contact>();

                
                foreach (Contact e in Cnt)
                    Console.WriteLine("{0},{1},{2}", e.FirstName,e.LastName,e.Title);

            }

        }

        public static void AddCount()
        {
            EntityMappingContext db = new EntityMappingContext();
            var query = db.Users.Count();
            Console.WriteLine(query);

        }

        public static void UserOrderby()
        {
            EntityMappingContext db = new EntityMappingContext();
            var query = from c in db.Users 
                        orderby c.FirstName descending
                        select c;

            foreach (User e in query)
                Console.WriteLine("{0},{1}", e.FirstName, e.UserID);

        }
        
    }
}
