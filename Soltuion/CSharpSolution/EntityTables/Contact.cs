using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityTables
{
  public  class Contact
    {
        public Contact()
        { }

        public int ContactID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public System.DateTime AddDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }

    }
}
