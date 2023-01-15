using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrmBL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBL.Model.Tests
{
    [TestClass()]
    public class CartTests
    {
        [TestMethod()]
        public void CartTest()
        {
            // arrange
            Customer customer = new Customer()
            {
                Name = "Петр"
            };
            Product product1 = new Product()
            {
                ProductId = 1,  
                Name = "Молоко",
                Price = 50,
                Count = 2
            };
            Product product2 = new Product()
            {
                ProductId = 2,
                Name = "Кофе",
                Price = 100,
                Count = 1
            };
            Cart cart = new Cart(customer);
            List<Product> expectedResults = new List<Product>()
            {
                product1, product1, product2
            };
            
            //action
            cart.Add(product1);
            cart.Add(product1);
            cart.Add(product2);
            var cartResult = cart.GetAll();
            //assert
            Assert.AreEqual(expectedResults.Count, cartResult.Count);
            for(var i = 0; i < expectedResults.Count; i++)
            {
                Assert.AreEqual(expectedResults[i], cartResult[i]);

            }


        }
    }
}