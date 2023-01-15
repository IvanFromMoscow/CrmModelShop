using System.Collections.Generic;

namespace CrmBL.Model
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public virtual ICollection<Sell> Sells { get; set; }
        public override string ToString()
        {
            return Name; 
        }
        public override int GetHashCode()
        {
            return ProductId;
        }
        public override bool Equals(object obj)
        {
            var product = obj as Product;
            if (product == null) return false;
            return ProductId.Equals(product.ProductId);
        }
    }
}
