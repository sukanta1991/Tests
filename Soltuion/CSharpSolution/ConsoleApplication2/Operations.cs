using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using DatabaseLayer;
using EntityTables;

namespace CodeFirst_UserModel
{
    public class Operations
    {
        public static void AddEntity()
        {
            //Add Entity values

            var context = new EntityMappingContext();
          
            IList<Address> AdrrList = new List<Address>();
            AdrrList.Add (new Address () {AddressID = 1,Street ="YoungSt",City ="Toronto"});
            AdrrList.Add(new Address() { AddressID = 2, Street = "ThomsonSt", City = "Newyork", PostalCode ="506000"});
            AdrrList.Add(new Address() { AddressID = 3, Street = "JohnsonSt", City = "Chicago", PostalCode ="390043"});
            AdrrList.Add(new Address() { AddressID = 4, Street = "JamesSt", City = "Newjersy" });

            foreach (Address  adr in AdrrList )
                context.Addresses.Add(adr);
            context.SaveChanges();
                                       
       }

        
        public static void Add1Entity()
        {
            

            //Update Entity values
            var context = new EntityMappingContext();

            User usr = context.Users.Where(p => p.FirstName == "John").FirstOrDefault();
            usr.LastName = "A";
                              
            context.SaveChanges();
          
           
        }

        public static void DeleteEntity()
        {
            //Delete entity values
            var context = new EntityMappingContext();
            User user = context.Users.Where(p => p.UserID == 1).First();
            context.Entry<User >(user).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();

        }


    }

}
