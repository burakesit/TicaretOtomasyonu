namespace Entities
{

    public class Product : IEntityValidation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string StockUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int Stock { get; set; }
        public bool IsSale { get; set; }
        public int CategoryId { get; set; }
        public int SupplierId { get; set; }

        public bool Validate()
        {
            //if (string.IsNullOrEmpty(Name)) return false;
            //if (CategoryId == 0) return false;
            //if (SupplierId == 0) return false;

            //return true;

            return ValidateWithMessage() == string.Empty;
        }

        public string ValidateWithMessage()
        {
            if (string.IsNullOrEmpty(Name)) return "Ürün adı boş geçilemez.";
            if (CategoryId == 0) return "Kategori boş geçilemez.";
            if (SupplierId == 0) return "Tedarikçi boş geçilemez.";

            return string.Empty;
        }
    }
}
