using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntityTables;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.ComponentModel.DataAnnotations;

namespace DatabaseLayer
{
   public class UserContext : DropCreateDatabaseIfModelChanges<EntityMappingContext>
    {
        protected override void Seed(EntityMappingContext context)
        {
            IList<User> user = new List<User>();
                       
            user.Add(new User() { FirstName = "Sam", LastName = "S" });
            user.Add(new User() { FirstName = "John", LastName = "D" });
            user.Add(new User() { FirstName = "Dave", LastName = "J" });
            user.Add(new User() { FirstName = "Dim", LastName = "M" });

            foreach (User usr in user)
                context.Users.Add(usr);

            base.Seed(context);
        }

    }
}
