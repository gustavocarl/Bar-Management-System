namespace Bar_Management_System.Models
{
    public abstract class Base
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public Base(Guid id)
        {
            Id = id;
        }
    }
}