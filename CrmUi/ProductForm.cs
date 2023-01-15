using CrmBL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrmUi
{
    public partial class ProductForm : Form
    {
        public Product Product { get; set; }
        public ProductForm()
        {
            InitializeComponent();
        }

        public ProductForm(Product product)
            : this()
        {
            Product = product;
            txtProductName.Text = product.Name;
            nudPriceProduct.Value = product.Price;
            nudQuantityProduct.Value = product.Count;
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
           
        }

        private void btnProductEdit_Click(object sender, EventArgs e)
        {
            Product p = Product ?? new Product();
            p.Name = txtProductName.Text;
            p.Price = nudPriceProduct.Value;
            p.Count = Convert.ToInt32(nudQuantityProduct.Value);
            Product = p;
            Close();
        }
    }
}
