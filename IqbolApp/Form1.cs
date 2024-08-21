using IqbolApp.Models;
using IqbolApp.Services;
using System.Net.Sockets;
using System.Text.Json;
using System.Windows.Forms;

namespace IqbolApp
{
    public partial class Form1 : Form
    {
        private readonly IProductService _productService;
        public Form1(IProductService productService)
        {
            InitializeComponent();
            _productService = productService;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            UpdateBucketListDisplay(LoadBucketFromJsonFile());
        }

        private void btnView_Click(object sender, EventArgs e)
        {

            var products = _productService.GetAllProducts();

            // Create and show the new form with the product list
            var productListForm = new Form2(products);
            productListForm.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var f3 = new Form3(_productService);
            f3.Show();
            //f3.btnAdd_Click(sender, e);
        }

        private void btnAddToBucket_Click(object sender, EventArgs e)
        {
            var data = _productService.GetAllProducts()
                .Where(x => x.Name.ToLower().Contains(txtSearch.Text.ToLower()))
                .Select(x => new ProductDto()
                {
                    Name = x.Name,
                    Count = x.Count,
                    Amount = x.Amount
                })
                .ToList();

            dataGridView1.DataSource = data;
        }

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    dataGridView1_CellDoubleClick(sender, e);
        //}
        private void dataGridView1_RowContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1_CellDoubleClick(sender, e);
        }
        //private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        //{
        //    if (dataGridView1.SelectedRows.Count > 0)
        //    {
        //        // Get the selected row
        //        DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

        //        // Perform your logic here, e.g., retrieve data from the row
        //        var productName = selectedRow.Cells["Name"].Value.ToString();
        //        MessageBox.Show($"Selected Product: {productName}");
        //    }
        //}

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)  // Ensure the clicked row is valid
            {
                // Get the double-clicked row
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Perform your logic here, e.g., retrieve data from the row
                var productName = selectedRow.Cells["Name"].Value.ToString();

                var list = LoadBucketFromJsonFile();
                list.Add(new BucketItem()
                {
                    ProductName = selectedRow.Cells["Name"].Value.ToString(),
                    Count = 1,
                    Cost = (float)selectedRow.Cells["Amount"].Value
                });

                SaveBucketToJsonFile(list);

                UpdateBucketListDisplay(list);
            }
        }

        private void SaveBucketToJsonFile(List<BucketItem> bucket)
        {
            string json = JsonSerializer.Serialize(bucket);
            File.WriteAllText("bucket.json", json);
        }
        private List<BucketItem> LoadBucketFromJsonFile()
        {
            List<BucketItem> bucket = new List<BucketItem>();
            if (File.Exists("bucket.json"))
            {
                string json = File.ReadAllText("bucket.json");
                bucket = JsonSerializer.Deserialize<List<BucketItem>>(json);

                if(bucket is null)
                    return new List<BucketItem>();
                return bucket;
            }
            else
            {
                return bucket; // Return an empty list if the file does not exist
            }
        }
        private void UpdateBucketListDisplay(List<BucketItem> bucketList)
        {
            listBox.Items.Clear(); // Clear the current items in the ListBox
            if (bucketList is null)
                return;
            foreach (var item in bucketList)
            {
                listBox.Items.Add($"{item.ProductName} - Soni: {item.Count}, Narxi: {item.Cost}");
            }
            lblTotal.Text = $"Umumiy: {bucketList.Sum(x => x.Cost)}";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Load the bucket from JSON file
            var bucketList = LoadBucketFromJsonFile();

            // Display the loaded bucket in the ListBox
            UpdateBucketListDisplay(bucketList);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveBucketToJsonFile(null);

        }
    }
}
