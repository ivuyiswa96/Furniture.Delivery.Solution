using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DispatchMe.Web.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public int AddressTypeId { get; set; }

        public string UnitNumber { get; set; }
        public string City { get; set; }
        public string Suburb { get; set; }
        public string StreetNumber { get; set; }

        public double Longitude { get; set; }
        public double Latitude { get; set; }

        public string ComplexName { get; set; }

        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
        public virtual AddressType AddressType  { get; set; }

    }
}
