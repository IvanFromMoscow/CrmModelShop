using System.Collections;
using System.Collections.Generic;

namespace CrmBL.Model
{
    public class Cart : IEnumerable
    {
        public Customer Customer { get; set; }
        public Dictionary<Product, int> items;
        public Cart(Customer customer)
        {
            this.Customer = customer;
            items = new Dictionary<Product, int>();
        }
        public void Add(Product product)
        {
           if(items.TryGetValue(product, out var count))
            {
                items[product] = ++count;
            } else
            {
                items.Add(product, 1);
            }
        }
        public IEnumerator GetEnumerator()
        {
            foreach(var item in items.Keys)
            {
                for(int i = 0; i < items[item]; i++)
                {
                    yield return item;
                }
            }
        }
        public List<Product> GetAll()
        {
            var result = new List<Product>();
            foreach (Product p in this)
            {
                result.Add(p);
            }
            return result;
        }
    }
}
