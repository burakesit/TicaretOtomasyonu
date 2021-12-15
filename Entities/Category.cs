using System;

namespace Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> ParentId { get; set; }
        public string Description { get; set; }
        public bool IsSale { get; set; }
        public decimal TaxRate { get; set; }
    }
}
