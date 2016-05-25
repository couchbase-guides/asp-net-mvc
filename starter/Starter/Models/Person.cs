using System.Collections.Generic;

namespace Starter.Models
{
    public class Person
    {
        public Person() { Type = "Person"; }

        public string Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; } 
        public string Address { get; set; }
    }
}