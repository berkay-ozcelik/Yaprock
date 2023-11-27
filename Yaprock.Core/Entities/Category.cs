using Yaprock.Core.Entities.BaseEntity;

namespace Yaprock.Core.Entity
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public string CategoryImage { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}