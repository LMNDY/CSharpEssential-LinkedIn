using System;

namespace SchoolLibrary
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public int LastName { get; set; }
        public DateTime DOB { get; set; }  //DateOnly could be used in .net 6
    }
}
