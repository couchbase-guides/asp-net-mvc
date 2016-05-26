namespace Starter.Models
{
    public class Person
    {
        public Person() { Type = "Person"; }

        public string Type { get; set; }
        public string FirstName { get; set; } 
        public string LastName { get; set; }
    }
}