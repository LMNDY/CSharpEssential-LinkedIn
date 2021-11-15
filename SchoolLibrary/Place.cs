using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    public abstract class Place
    {
        //Add address format
        public string Address { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        // Add uk postcode format
        public string PostCode { get; set; }
    }
}
