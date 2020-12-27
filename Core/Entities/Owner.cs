
namespace Core.Entities
{
    public class Owner : EntityBase
    {
        public string FullName { get; set; }
        public string Profile { get; set; } //.net Developer
        public string Avatar { get; set; } //pic
        public Address Address { get; set; }

    }
}
