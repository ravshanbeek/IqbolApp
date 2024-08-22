using IqbolApp.Services;
using System.Windows.Forms;

namespace IqbolApp
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private readonly IProductService _productService;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridViewProducts = new DataGridView();
            productBindingSource = new BindingSource(components);
            pictureBox1 = new PictureBox();
            back = new Button();
            imageColumn = new DataGridViewImageColumn();
            deleteColumn = new DataGridViewButtonColumn();
            updateColumn = new DataGridViewButtonColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            actualAmountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            amountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            countDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.AllowUserToAddRows = false;
            dataGridViewProducts.AutoGenerateColumns = false;
            dataGridViewProducts.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Columns.AddRange(new DataGridViewColumn[] { imageColumn, deleteColumn, updateColumn, nameDataGridViewTextBoxColumn, actualAmountDataGridViewTextBoxColumn, amountDataGridViewTextBoxColumn, countDataGridViewTextBoxColumn, idDataGridViewTextBoxColumn });
            dataGridViewProducts.DataSource = productBindingSource;
            dataGridViewProducts.Dock = DockStyle.Top;
            dataGridViewProducts.GridColor = SystemColors.InactiveCaptionText;
            dataGridViewProducts.Location = new Point(0, 0);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.Size = new Size(1805, 961);
            dataGridViewProducts.TabIndex = 0;
            dataGridViewProducts.CellContentClick += dataGridView1_CellContentClick;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Models.Product);
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(624, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(359, 213);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // back
            // 
            back.BackColor = Color.Red;
            back.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            back.Location = new Point(624, 476);
            back.Name = "back";
            back.Size = new Size(102, 50);
            back.TabIndex = 2;
            back.Text = "Orqaga";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // imageColumn
            // 
            imageColumn.HeaderText = "Rasm";
            imageColumn.Name = "imageColumn";
            imageColumn.Width = 60;
            // 
            // deleteColumn
            // 
            deleteColumn.HeaderText = "O'chirish";
            deleteColumn.Name = "deleteColumn";
            deleteColumn.Text = "❌";
            deleteColumn.UseColumnTextForButtonValue = true;
            deleteColumn.Width = 60;
            // 
            // updateColumn
            // 
            updateColumn.HeaderText = "Yangilash";
            updateColumn.Name = "updateColumn";
            updateColumn.Text = "✅";
            updateColumn.UseColumnTextForButtonValue = true;
            updateColumn.Width = 60;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Nomi";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // actualAmountDataGridViewTextBoxColumn
            // 
            actualAmountDataGridViewTextBoxColumn.DataPropertyName = "ActualAmount";
            actualAmountDataGridViewTextBoxColumn.HeaderText = "Tan natxi";
            actualAmountDataGridViewTextBoxColumn.Name = "actualAmountDataGridViewTextBoxColumn";
            actualAmountDataGridViewTextBoxColumn.Width = 80;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            amountDataGridViewTextBoxColumn.HeaderText = "Sotuvdagi narxi";
            amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            amountDataGridViewTextBoxColumn.Width = 80;
            // 
            // countDataGridViewTextBoxColumn
            // 
            countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            countDataGridViewTextBoxColumn.HeaderText = "Miqdori";
            countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            countDataGridViewTextBoxColumn.Width = 80;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 60;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1805, 964);
            Controls.Add(back);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridViewProducts);
            Name = "Form2";
            Text = "Product List";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    DataGridViewRow selectedRow = dataGridViewProducts.Rows[e.RowIndex];
                    var productId = (int)selectedRow.Cells[7].Value;
                    var product = _productService.GetById(productId);

                    if (product is null)
                        MessageBox.Show("Siz maxsulot bo'lmagan qatorni tanladiz");

                    string rootDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "root");
                    string filePath = Path.Combine(rootDirectory, product.PhotoId);

                    if (File.Exists(filePath))
                    {
                        pictureBox1.Image = Image.FromFile(filePath); // Load the image into the PictureBox
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // Optional: Adjust size mode
                        pictureBox1.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Rasm topilmadi!");
                    }
                }
                else if (e.ColumnIndex == 1)
                {
                    DataGridViewRow selectedRow = dataGridViewProducts.Rows[e.RowIndex];
                    var productId = (int)selectedRow.Cells[7].Value;
                    var product = _productService.GetById(productId);

                    if (product is null)
                        MessageBox.Show("Siz maxsulot bo'lmagan qatorni tanladiz");

                    _productService.DeleteProduct(productId);
                    var products = _productService.GetAllProducts();
                    this.Close();

                    // Create and show the new form with the product list
                    var productListForm = new Form2(products, _productService);
                    productListForm.Show();
                    //var productListForm = new Form2(products, _productService);
                    //productListForm.Show();
                }
                else if (e.ColumnIndex == 2)
                {
                    DataGridViewRow selectedRow = dataGridViewProducts.Rows[e.RowIndex];
                    var productId = (int)selectedRow.Cells[7].Value;
                    var product = _productService.GetById(productId);

                    if (product is null)
                        MessageBox.Show("Siz maxsulot bo'lmagan qatorni tanladiz");

                    if (!selectedRow.Cells[4].Value.ToString().Trim().All(x => char.IsDigit(x))
                        || !selectedRow.Cells[5].Value.ToString().Trim().All(x => char.IsDigit(x))
                        || !selectedRow.Cells[6].Value.ToString().Trim().All(x => char.IsDigit(x)))
                        MessageBox.Show("Tan narxi, Sotuvdagi narxi va Miqdori faqat raqam bulishi kerak");

                    product.Name = selectedRow.Cells[3].Value.ToString();
                    product.ActualAmount = (float)selectedRow.Cells[4].Value;
                    product.Amount = (float)selectedRow.Cells[5].Value;
                    product.Count = (int)selectedRow.Cells[6].Value;

                    _productService.UpdateProduct(product);
                    var products = _productService.GetAllProducts();

                }
                
            }
            catch (Exception) { }
        }
        private void buttonRed_Click(object sender, EventArgs e)
        {
            // Your logic for the Red button click event
        }
        private BindingSource productBindingSource;
        private PictureBox pictureBox1;
        private Button back;
        private DataGridViewImageColumn imageColumn;
        private DataGridViewButtonColumn deleteColumn;
        private DataGridViewButtonColumn updateColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn actualAmountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    }
}
