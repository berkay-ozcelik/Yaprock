using Yaprock.Core.Entities.BaseEntity;

namespace Yaprock.Core.Entity
{
    public class Review : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public string ReviewText { get; set; }
        public int Rating { get; set; }
    }
}
