using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntityTables;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseLayer
{
    public class EntityMappingContext : DbContext
    {
      public EntityMappingContext(): base(@"Data Source=.\SQLEXPRESS; Initial Catalog=UserDatabase;Integrated Security=true")
        {

        }
             
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Shipment> Shipments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
     
            
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
                                   
            modelBuilder.Entity<Address>().HasKey<int>(s => s.AddressID);
            modelBuilder.Entity<User>().HasKey<int>(s => s.UserID);
            modelBuilder.Entity<Shipment>().HasKey<int>(s => s.ShipmentID);
            modelBuilder.Entity<Contact>().HasKey<int>(s => s.ContactID);
        
            modelBuilder.Entity<User>().Property(p => p.UserID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<User>().Property(p => p.FirstName).IsOptional();
            modelBuilder.Entity<User>().Property(p => p.LastName).IsOptional();

            modelBuilder.Entity<Shipment>().Property(p => p.ShipmentID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<Shipment>().Property(p => p.CreatedOn).IsRequired();
            modelBuilder.Entity<Shipment >().Property(p => p.State).IsOptional();
            
            modelBuilder.Entity<Address>().Property(p => p.AddressID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<Address>().Property(p => p.Street).IsOptional();
            modelBuilder.Entity<Address>().Property(p => p.City).IsOptional();
            modelBuilder.Entity<Address>().Property(p => p.PostalCode).IsOptional();
        
            modelBuilder.Entity<Contact>().Property(p => p.ContactID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<Contact>().Property(p => p.FirstName).IsRequired();
            modelBuilder.Entity<Contact>().Property(p => p.LastName).IsRequired();
            modelBuilder.Entity<Contact>().Property(p => p.Title).IsOptional();
            modelBuilder.Entity<Contact>().Property(p => p.AddDate).IsRequired();
            modelBuilder.Entity<Contact>().Property(p => p.ModifiedDate).IsRequired();
          
           base.OnModelCreating(modelBuilder);
      

        }
    }

    
}
