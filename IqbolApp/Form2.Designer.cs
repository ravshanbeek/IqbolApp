namespace IqbolApp
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Button buttonRed;
        private System.Windows.Forms.DataGridViewImageColumn imageColumn;

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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.imageColumn = new System.Windows.Forms.DataGridViewImageColumn();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();

            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imageColumn});
            this.dataGridViewProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewProducts.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.RowTemplate.Height = 25;
            this.dataGridViewProducts.Size = new System.Drawing.Size(800, 400);
            this.dataGridViewProducts.TabIndex = 0;

            // 
            // imageColumn
            // 
            this.imageColumn.HeaderText = "Product Image";
            this.imageColumn.Name = "imageColumn";
            this.imageColumn.Width = 150;

            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRed);
            this.Controls.Add(this.dataGridViewProducts);
            this.Name = "Form2";
            this.Text = "Product List";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            // Your logic for the Red button click event
        }
    }
}
