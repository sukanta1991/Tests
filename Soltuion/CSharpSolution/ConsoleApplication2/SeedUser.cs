using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using DatabaseLayer;
using EntityTables;


namespace CodeFirst_UserModel
{
    class SeedUser
    {
        public static void AddUserValue()
        {

            Database.SetInitializer<EntityMappingContext>(new UserContext());
            EntityMappingContext db = new EntityMappingContext();

            var query = db.Users.Where(d => d.FirstName.StartsWith("D")).Count();
            Console.WriteLine(query);

        }

    }
}
