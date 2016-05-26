namespace Starter.Models
{
    public class Profile
    {
        public Profile() { Type = "Profile"; }

        public string Type { get; set; }
        public string FirstName { get; set; } 
        public string LastName { get; set; }
    }
}