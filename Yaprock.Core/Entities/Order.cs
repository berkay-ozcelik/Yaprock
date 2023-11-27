using Yaprock.Core.Entities.BaseEntity;

namespace Yaprock.Core.Entity
{
    public class Order : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime OrderDate { get; set; }
        public int DeliveryStatus { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
