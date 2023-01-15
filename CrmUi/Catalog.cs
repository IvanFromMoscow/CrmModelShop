using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrmBL.Model;
namespace CrmUi
{
    public partial class Catalog<T> : Form
        where T : class
    {
        DbSet<T> set;
        CrmContext db;
        public Catalog(DbSet<T> set, CrmContext db)
        {
            InitializeComponent();
            this.set = set;
            this.db = db;
            set.Load();
            dataGridView.DataSource = set.Local.ToBindingList();
            dataGridView.Refresh();
        }

        private void Catalog_Load(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            AddDataInForm<T>();
        }

        private void btnChangeItem_Click(object sender, EventArgs e)
        {
            ChangeDataInForm<T>();
        }
        private void AddDataInForm<T>()
        {
            switch (typeof(T).Name)
            {
                case "Product":
                    {
                        var form = new ProductForm();
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            db.Products.Add(form.Product);
                            db.SaveChanges();
                        }
                        break;
                    }
                case "Customer":
                    {
                        var form = new CustomerForm();
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            db.Customers.Add(form.Customer);
                            db.SaveChanges();
                        }
                        break;
                    }
                case "Seller":
                    {
                        var form = new SellerForm();
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            db.Sellers.Add(form.Seller);
                            db.SaveChanges();
                        }
                        break;
                    }
            }
        }
        private void ChangeDataInForm<T>()
        {
            var id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
            switch (typeof(T).Name)
            {
                case "Product":
                    {
                        var product = db.Products.Find(id);
                        if (product != null)
                        {
                            var form = new ProductForm(product);
                            if (form.ShowDialog() == DialogResult.OK)
                            {
                                db.SaveChanges();
                                dataGridView.Refresh();
                            }
                        }
                        break;
                    }
                case "Customer":
                    {
                        var customer = db.Customers.Find(id);
                        if (customer != null)
                        {
                            var form = new CustomerForm(customer);
                            if (form.ShowDialog() == DialogResult.OK)
                            {
                                db.SaveChanges();
                                dataGridView.Refresh();
                            }
                        }
                        break;
                    }
                case "Seller":
                    {
                        var seller = db.Sellers.Find(id);
                        if (seller != null)
                        {
                            var form = new SellerForm(seller);
                            if (form.ShowDialog() == DialogResult.OK)
                            {
                                db.SaveChanges();
                                dataGridView.Refresh();
                            }
                        }
                        break;
                    }
            }
        }
    }
}
