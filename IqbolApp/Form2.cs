using System;
using System.Collections.Generic;
using System.Windows.Forms;
using IqbolApp.Models;
using IqbolApp.Services; // Ensure this is included for Product model

namespace IqbolApp
{
    public partial class Form2 : Form
    {
        public Form2(List<Product> products, IProductService productService)
        {
            InitializeComponent();
            LoadData(products);
            _productService = productService;
        }

        private void LoadData(List<Product> products)
        {
            // Bind the list of products to the DataGridView
            dataGridViewProducts.DataSource = products;
        }

        private void buttonRed_Click_1(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
