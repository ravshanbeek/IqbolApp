using System;
using System.Collections.Generic;
using System.Windows.Forms;
using IqbolApp.Models; // Ensure this is included for Product model

namespace IqbolApp
{
    public partial class Form2 : Form
    {
        public Form2(List<Product> products)
        {
            InitializeComponent();
            LoadData(products);
        }

        private void LoadData(List<Product> products)
        {
            // Bind the list of products to the DataGridView
            dataGridViewProducts.DataSource = products;
        }
    }
}
