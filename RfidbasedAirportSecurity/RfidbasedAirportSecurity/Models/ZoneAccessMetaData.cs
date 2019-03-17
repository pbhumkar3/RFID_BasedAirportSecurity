using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RfidbasedAirportSecurity.Models
{
    public class ZoneAccessMetaData
    {
        // Role	Type/Class	Zone1	Zone2	Zone3
        [Key]
        public string Role { get; set; }

        public string ClassType { get; set; }

        public string ZoneAccess { get; set; }


    }
}