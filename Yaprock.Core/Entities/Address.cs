using Yaprock.Core.Entities.BaseEntity;

namespace Yaprock.Core.Entity
{
    public class Address : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
    }
}
