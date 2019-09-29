using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace EntityTables
{
   public class User
    {
       public User()
       { }
         
        public int UserID { get; set; }
        public string  FirstName { get; set; }
        public string  LastName { get; set; }
     
    }
}
