using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using EntityTables;

namespace DatabaseLayer
{
    class UserContext : DropCreateDatabaseIfModelChanges<EntityMappingContext>
    {

    }
}
