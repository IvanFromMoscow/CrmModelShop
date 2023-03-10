using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrmBL.Model;
namespace CrmUi
{
    public partial class Main : Form
    {
        CrmContext db;
        enum TypeForm
        {
            CUSTOMER,
            PRODUCT,
            SELLER
        };
       
        public Main()
        {
            InitializeComponent();
            db = new CrmContext();
        }

        private void ProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogProduct = new Catalog<Product>(db.Products, db);
            catalogProduct.Show();
        }

        private void SellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogSeller = new Catalog<Seller>(db.Sellers, db);
            catalogSeller.Show();
        }

        private void CustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogCustomer = new Catalog<Customer>(db.Customers, db);
            catalogCustomer.Show();

        }

        private void CheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogCheck = new Catalog<Check>(db.Checks, db);
            catalogCheck.Show();

        }

        private void CustomerAddToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AddDataInDBSet(TypeForm.CUSTOMER);
        }

        private void SellerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
            AddDataInDBSet(TypeForm.SELLER);
        }

        private void ProductAddToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AddDataInDBSet(TypeForm.PRODUCT);
        }
        private void AddDataInDBSet(TypeForm typeForm)
        {
            switch (typeForm)
            {
                case TypeForm.SELLER:
                    {
                        var form = new SellerForm();
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            db.Sellers.Add(form.Seller);
                            db.SaveChanges();
                        }
                        break;
                    }
                case TypeForm.CUSTOMER:
                    {
                        var form = new CustomerForm();
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            db.Customers.Add(form.Customer);
                            db.SaveChanges();
                        }
                        break;
                    }
                case TypeForm.PRODUCT:
                    {
                        var form = new ProductForm();
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            db.Products.Add(form.Product);
                            db.SaveChanges();
                        }
                        break;
                    }
            }

        }
    }
}
