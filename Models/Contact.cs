using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DispatchMe.Web.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        public int ContactTypeId { get; set; }
        public string PhoneNumber { get; set; }
        public string TellNumber { get; set; }
        public string WorkNumber { get; set; }
        public string PersonalEmail { get; set; }
        public string WorkEmail { get; set; }
        public virtual ContactType ContactType { get; set; }
        public  virtual Person Person  { get; set; }
    }
}
