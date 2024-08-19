using IqbolApp.Models;
using IqbolApp.Services;
using System;
using System.Drawing;
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
            txtName.Location = new Point(30, 30);
            txtName.Size = new Size(200, 30);
            txtName.PlaceholderText = "Enter Product Name";
            // 
            // txtActualAmount
            // 
            txtActualAmount.Location = new Point(30, 80);
            txtActualAmount.Size = new Size(200, 30);
            txtActualAmount.PlaceholderText = "Enter Actual Amount";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(30, 130);
            txtAmount.Size = new Size(200, 30);
            txtAmount.PlaceholderText = "Enter Amount";
            // 
            // txtCount
            // 
            txtCount.Location = new Point(30, 180);
            txtCount.Size = new Size(200, 30);
            txtCount.PlaceholderText = "Enter Count";
            // 
            // pictureBoxProduct
            // 
            pictureBoxProduct.Location = new Point(250, 30);
            pictureBoxProduct.Size = new Size(200, 200);
            pictureBoxProduct.BorderStyle = BorderStyle.FixedSingle;
            // 
            // btnUploadImage
            // 
            btnUploadImage.Location = new Point(250, 240);
            btnUploadImage.Size = new Size(200, 30);
            btnUploadImage.Text = "Upload Image";
            btnUploadImage.Click += btnUploadImage_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(30, 240);
            btnSave.Size = new Size(100, 30);
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(140, 240);
            btnBack.Size = new Size(100, 30);
            btnBack.Text = "Back";
            btnBack.Click += btnBack_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif";
            openFileDialog.Title = "Select an Image";

            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 300);
            Controls.Add(txtName);
            Controls.Add(txtActualAmount);
            Controls.Add(txtAmount);
            Controls.Add(txtCount);
            Controls.Add(pictureBoxProduct);
            Controls.Add(btnUploadImage);
            Controls.Add(btnSave);
            Controls.Add(btnBack);
            Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string fileName = Guid.NewGuid().ToString();

                // Set the root directory where the image will be saved
                string rootDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "root");

                // Ensure the root directory exists
                if (!Directory.Exists(rootDirectory))
                {
                    Directory.CreateDirectory(rootDirectory);
                }

                // Save the image in the root directory
                string savePath = Path.Combine(rootDirectory, fileName);
                File.Copy(filePath, savePath, true);

                // Store the saved path for later use when saving the product
                uploadedImagePath = savePath;

                // Load and display the image in PictureBox
                pictureBoxProduct.Image = Image.FromFile(savePath);
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(uploadedImagePath))
            {
                MessageBox.Show("Please upload an image before saving the product.");
                return;
            }

            // Create a new Product instance from input fields
            Product product = new Product
            {
                Id = 0, // This can be handled by the database or set to a unique identifier like GUID
                Name = txtName.Text,
                ActualAmount = float.Parse(txtActualAmount.Text),
                Amount = float.Parse(txtAmount.Text),
                Count = int.Parse(txtCount.Text),
                PhotoId = Guid.Parse(Path.GetFileName(uploadedImagePath)) // Save only the file name or path if needed
            };

            productService.AddProduct(product);

            // Logic to save the product object to your database or collection
            MessageBox.Show("Product saved successfully!");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Logic to go back to the previous form
            this.Close();
        }
    }
}
