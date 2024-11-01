namespace Bar_Management_System.Models
{
    public class User : Base
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public User(Guid id, string firstName, string lastName) : base(id)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}