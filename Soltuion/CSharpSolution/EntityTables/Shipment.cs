using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace EntityTables
{
   public class Shipment
    {
       public Shipment()
       { }
        
        public int ShipmentID { get; set; }
        public DateTime CreatedOn { get; set; }
        public string State { get; set; }
     
              
    }
}
