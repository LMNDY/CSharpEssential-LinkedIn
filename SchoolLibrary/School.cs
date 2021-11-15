using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    public class School : Place
    {
        public string Name { get; set; }


        public School(string SchoolName, string SchoolAddress, 
            string SchoolCity, string SchoolCounty, string SchoolPostCode )
        {
            
            Name = SchoolName;
            Address = SchoolAddress;
            City = SchoolCity;
            County = SchoolCounty;
            PostCode = SchoolPostCode;

        }
    }
}


