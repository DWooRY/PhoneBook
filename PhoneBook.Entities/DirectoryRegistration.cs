using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Entities
{
    public class DirectoryRegistration
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneI { get; set; }
        public string PhoneII { get; set; }
        public string PhoneIII { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }
        public string Website { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }





    }
}
