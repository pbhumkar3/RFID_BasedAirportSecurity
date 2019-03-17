using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RfidbasedAirportSecurity.Models
{
    public class RfidbasedAirportSecurityContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public RfidbasedAirportSecurityContext() : base("name=RfidbasedAirportSecurityContext")
        {
        }

        public System.Data.Entity.DbSet<RfidbasedAirportSecurity.Models.RfidInventory> RfidInventories { get; set; }

        public System.Data.Entity.DbSet<RfidbasedAirportSecurity.Models.Employee> Employees { get; set; }

        public System.Data.Entity.DbSet<RfidbasedAirportSecurity.Models.FlightDetails> FlightDetails { get; set; }

        public System.Data.Entity.DbSet<RfidbasedAirportSecurity.Models.PassengerDetails> PassengerDetails { get; set; }

        public System.Data.Entity.DbSet<RfidbasedAirportSecurity.Models.Luggage> Luggages { get; set; }

        public System.Data.Entity.DbSet<RfidbasedAirportSecurity.Models.ZoneAccessMetaData> ZoneAccessMetaDatas { get; set; }

        public System.Data.Entity.DbSet<RfidbasedAirportSecurity.Models.ZoneInfoMetaData> ZoneInfoMetaDatas { get; set; }

        public System.Data.Entity.DbSet<RfidbasedAirportSecurity.Models.PassengerAreaAccess> PassengerAreaAccesses { get; set; }
    }
}
