namespace IqbolApp
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Button buttonRed;
        private System.Windows.Forms.DataGridViewImageColumn imageColumn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteColumn;
        private System.Windows.Forms.DataGridViewButtonColumn updateColumn;

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
            this.deleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.updateColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonRed = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();

            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imageColumn,
            this.deleteColumn,
            this.updateColumn});
            this.dataGridViewProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewProducts.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.RowTemplate.Height = 25;
            this.dataGridViewProducts.Size = new System.Drawing.Size(800, 400);
            this.dataGridViewProducts.TabIndex = 0;
            this.dataGridViewProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProducts_CellContentClick);

            // 
            // imageColumn
            // 
            this.imageColumn.HeaderText = "Product Image";
            this.imageColumn.Name = "imageColumn";
            this.imageColumn.Width = 150;

            // 
            // deleteColumn
            // 
            this.deleteColumn.HeaderText = "Delete";
            this.deleteColumn.Name = "deleteColumn";
            this.deleteColumn.Text = "❌";
            this.deleteColumn.UseColumnTextForButtonValue = true;
            this.deleteColumn.Width = 50;
            this.deleteColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;

            // 
            // updateColumn
            // 
            this.updateColumn.HeaderText = "Update";
            this.updateColumn.Name = "updateColumn";
            this.updateColumn.Text = "✅";
            this.updateColumn.UseColumnTextForButtonValue = true;
            this.updateColumn.Width = 50;
            this.updateColumn.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;

            // 
            // buttonRed
            // 
            this.buttonRed.Location = new System.Drawing.Point(350, 410);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(75, 23);
            this.buttonRed.TabIndex = 1;
            this.buttonRed.Text = "Red Button";
            this.buttonRed.UseVisualStyleBackColor = true;
            this.buttonRed.Click += new System.EventHandler(this.buttonRed_Click);

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

        private void dataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataGridViewProducts.Columns[e.ColumnIndex].Name == "deleteColumn")
                {
                    // Handle delete logic
                    MessageBox.Show("Delete row logic goes here for row: " + e.RowIndex);
                }
                else if (dataGridViewProducts.Columns[e.ColumnIndex].Name == "updateColumn")
                {
                    // Handle update logic
                    MessageBox.Show("Update logic goes here for row: " + e.RowIndex);
                }
            }
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            // Your logic for the Red button click event
        }
    }
}
