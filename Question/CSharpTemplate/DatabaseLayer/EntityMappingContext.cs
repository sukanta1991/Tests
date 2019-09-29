using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntityTables;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.ComponentModel.DataAnnotations;

namespace DatabaseLayer
{
    public class EntityMappingContext : DbContext
    {
                  

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            

        }
    }

    
}
