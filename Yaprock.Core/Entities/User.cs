using Yaprock.Core.Entities.BaseEntity;

namespace Yaprock.Core.Entity
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public ICollection<Address> Addresses { get; set; }
    }
}
