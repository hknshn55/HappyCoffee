using HappyCoffee.FormUI.Business;
using HappyCoffee.FormUI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyCoffee.FormUI
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
            dgwProduct.MultiSelect = true;
        }
        private async void Order_Load(object sender, EventArgs e)
        {
            //var categories = await CategoryManager.Categories("http://localhost:8891/", "api/Category");
            //foreach (var item in categories)
            //{
            //    cmbCategory.Items.Add(item.Name);
            //}

        }
        private async void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

            //string select = cmbCategory.Text;
            //dgwProduct.DataSource = (await ProductManager.GetProducts("http://localhost:8891/", "api/Product")).Where(x => x.Category.Name == select).ToList();
        }
        private void btnChange_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < dgwProduct.SelectedRows.Count; i++)
            //{
            //    dataGridView1.DataSource = dgwProduct.SelectedRows[i];
            //    dgwProduct.SelectedRows[i].Selected = false;
            //}


            //double price = 0;
            //for (int i = 0; i < dgwProduct.SelectedRows.Count; i++)
            //{
            //    price += Convert.ToDouble(dgwProduct.CurrentRow.Cells[2].Value);
            //}
            //lblPrice.Text = price.ToString("C2");
        }

        private async void btnApproval_Click(object sender, EventArgs e)
        {
            
            List<HappyCoffee.FormUI.Models.Order> orders = new List<HappyCoffee.FormUI.Models.Order>();

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                orders.Add(new Models.Order
                {
                    CategoryId =Convert.ToInt32( dataGridView1.CurrentRow.Cells[1].Value),
                     ProductPrice=Convert.ToDecimal(dataGridView1.CurrentRow.Cells[2].Value)
                });
            }

            foreach (var item in orders)
            {
                await OrderManager.AddOrder("http://localhost:8891/", "api/Order",item);
            }
            //dataGridView1.DataSource = null;
        }
    }
}
