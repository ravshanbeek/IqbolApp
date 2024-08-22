using IqbolApp.Models;
using IqbolApp.Services;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace IqbolApp
{
    partial class Form3 : Form
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtName;
        private TextBox txtActualAmount;
        private TextBox txtAmount;
        private TextBox txtCount;
        private PictureBox pictureBoxProduct;
        private Button btnUploadImage;
        private Button btnSave;
        private Button btnBack;
        private OpenFileDialog openFileDialog;
        private readonly IProductService productService;
        private string uploadedImagePath = string.Empty;
        public Form3(IProductService productService)
        {
            this.productService = productService;
            InitializeComponent();
        }
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
            txtName = new TextBox();
            txtActualAmount = new TextBox();
            txtAmount = new TextBox();
            txtCount = new TextBox();
            pictureBoxProduct = new PictureBox();
            btnUploadImage = new Button();
            btnSave = new Button();
            btnBack = new Button();
            openFileDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduct).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(27, 22);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Maxsulot nomini kiriting";
            txtName.Size = new Size(259, 23);
            txtName.TabIndex = 0;
            // 
            // txtActualAmount
            // 
            txtActualAmount.Location = new Point(27, 60);
            txtActualAmount.Margin = new Padding(3, 2, 3, 2);
            txtActualAmount.Name = "txtActualAmount";
            txtActualAmount.PlaceholderText = "Maxsulotni tan narxini kiriting";
            txtActualAmount.Size = new Size(259, 23);
            txtActualAmount.TabIndex = 1;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(27, 98);
            txtAmount.Margin = new Padding(3, 2, 3, 2);
            txtAmount.Name = "txtAmount";
            txtAmount.PlaceholderText = "Foizni kiriting";
            txtAmount.Size = new Size(259, 23);
            txtAmount.TabIndex = 2;
            // 
            // txtCount
            // 
            txtCount.Location = new Point(27, 135);
            txtCount.Margin = new Padding(3, 2, 3, 2);
            txtCount.Name = "txtCount";
            txtCount.PlaceholderText = "Maxsulot sonini kiriting";
            txtCount.Size = new Size(259, 23);
            txtCount.TabIndex = 3;
            // 
            // pictureBoxProduct
            // 
            pictureBoxProduct.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxProduct.Location = new Point(340, 22);
            pictureBoxProduct.Margin = new Padding(3, 2, 3, 2);
            pictureBoxProduct.Name = "pictureBoxProduct";
            pictureBoxProduct.Size = new Size(175, 150);
            pictureBoxProduct.TabIndex = 4;
            pictureBoxProduct.TabStop = false;
            // 
            // btnUploadImage
            // 
            btnUploadImage.Location = new Point(340, 180);
            btnUploadImage.Margin = new Padding(3, 2, 3, 2);
            btnUploadImage.Name = "btnUploadImage";
            btnUploadImage.Size = new Size(175, 22);
            btnUploadImage.TabIndex = 5;
            btnUploadImage.Text = "Rasm yuklash";
            btnUploadImage.Click += btnUploadImage_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(26, 180);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(88, 22);
            btnSave.TabIndex = 6;
            btnSave.Text = "Saqlash";
            btnSave.Click += btnSave_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(198, 180);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(88, 22);
            btnBack.TabIndex = 7;
            btnBack.Text = "Orqaga";
            btnBack.Click += btnBack_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif";
            openFileDialog.Title = "Rasmni tanlang";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 225);
            Controls.Add(txtName);
            Controls.Add(txtActualAmount);
            Controls.Add(txtAmount);
            Controls.Add(txtCount);
            Controls.Add(pictureBoxProduct);
            Controls.Add(btnUploadImage);
            Controls.Add(btnSave);
            Controls.Add(btnBack);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form3";
            Text = "Maxsulot qo'shish";
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    string fileName = Guid.NewGuid().ToString() + ".png"; // Ensure the file is saved as a .png

                    // Set the root directory where the image will be saved
                    string rootDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "root");

                    // Ensure the root directory exists
                    if (!Directory.Exists(rootDirectory))
                    {
                        Directory.CreateDirectory(rootDirectory);
                    }

                    // Load the image from the selected file
                    using (Image image = Image.FromFile(filePath))
                    {
                        // Save the image as .png in the root directory
                        string savePath = Path.Combine(rootDirectory, fileName);
                        image.Save(savePath, ImageFormat.Png);

                        // Store the saved path for later use when saving the product
                        uploadedImagePath = savePath;

                        // Load and display the image in PictureBox
                        pictureBoxProduct.Image = Image.FromFile(savePath);
                    }
                }
            }
            catch (Exception ex)
            {
                // Display the error message in a MessageBox or handle it as needed
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text)
                || string.IsNullOrEmpty(txtCount.Text)
                || string.IsNullOrEmpty(txtActualAmount.Text)
                || string.IsNullOrEmpty(txtAmount.Text))
            {
                MessageBox.Show("Maxsulot nomi, Maxsulot soni, Maxsulot narxi va tannarxi bo'sh bolmasligi kerak");
                return;
            }
            // Create a new Product instance from input fields
            Product product = new Product
            {
                Id = 0, // This can be handled by the database or set to a unique identifier like GUID
                Name = txtName.Text,
                ActualAmount = float.Parse(txtActualAmount.Text),
                Amount = (float.Parse(txtAmount.Text)/100 + 1) * float.Parse(txtActualAmount.Text),
                Count = int.Parse(txtCount.Text),
                PhotoId = Path.GetFileName(uploadedImagePath)// Save only the file name or path if needed
            };

            productService.AddProduct(product);

            // Logic to save the product object to your database or collection
            MessageBox.Show("Maxsulot qo'shildi!");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Logic to go back to the previous form
            this.Close();
        }
    }
}
