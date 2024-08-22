using System;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace IqbolApp
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private Label dateTimeLabel;
        private Label titleLabel;
        private Button btnAdd;
        private Button btnView;
        private TextBox txtSearch;
        private Button btnAddToBucket;
        private Label lblSalesTitle;
        private Label lblTotal;
        private void StartRealTimeClock()
        {
            // Initialize the timer
            timer = new Timer();
            timer.Interval = 1000; // 1 second (1000 ms)
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Update the date and time label with the current time
            dateTimeLabel.Text = DateTime.Now.ToString("dd.MM.yyyy\nHH:mm:ss");
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            titleLabel = new Label();
            dateTimeLabel = new Label();
            btnAdd = new Button();
            btnView = new Button();
            txtSearch = new TextBox();
            btnAddToBucket = new Button();
            lblSalesTitle = new Label();
            lblTotal = new Label();
            dataGridView1 = new DataGridView();
            productBindingSource = new BindingSource(components);
            listBox = new ListBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            View = new DataGridViewImageColumn();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            amountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            countDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Arial", 36F, FontStyle.Bold);
            titleLabel.ForeColor = Color.Goldenrod;
            titleLabel.Location = new Point(468, 26);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(191, 56);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "IXIProg";
            // 
            // dateTimeLabel
            // 
            dateTimeLabel.AutoSize = true;
            dateTimeLabel.Font = new Font("Arial", 14F);
            dateTimeLabel.Location = new Point(20, 20);
            dateTimeLabel.Name = "dateTimeLabel";
            dateTimeLabel.Size = new Size(0, 22);
            dateTimeLabel.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Arial", 14F);
            btnAdd.ForeColor = Color.Blue;
            btnAdd.Location = new Point(59, 346);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(149, 50);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "QO'SHISH";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnView
            // 
            btnView.BackColor = Color.White;
            btnView.FlatStyle = FlatStyle.Flat;
            btnView.Font = new Font("Arial", 14F);
            btnView.ForeColor = Color.Blue;
            btnView.Location = new Point(59, 416);
            btnView.Name = "btnView";
            btnView.Size = new Size(149, 50);
            btnView.TabIndex = 4;
            btnView.Text = "KO'RISH";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Arial", 14F);
            txtSearch.Location = new Point(291, 140);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(434, 52);
            txtSearch.TabIndex = 5;
            // 
            // btnAddToBucket
            // 
            btnAddToBucket.BackColor = Color.Green;
            btnAddToBucket.FlatStyle = FlatStyle.Flat;
            btnAddToBucket.Font = new Font("Arial", 14F);
            btnAddToBucket.ForeColor = Color.White;
            btnAddToBucket.Location = new Point(731, 140);
            btnAddToBucket.Name = "btnAddToBucket";
            btnAddToBucket.Size = new Size(120, 52);
            btnAddToBucket.TabIndex = 10;
            btnAddToBucket.Text = "Qidirish";
            btnAddToBucket.UseVisualStyleBackColor = false;
            btnAddToBucket.Click += btnAddToBucket_Click;
            // 
            // lblSalesTitle
            // 
            lblSalesTitle.AutoSize = true;
            lblSalesTitle.Font = new Font("Arial", 16F, FontStyle.Bold);
            lblSalesTitle.ForeColor = Color.Green;
            lblSalesTitle.Location = new Point(977, 29);
            lblSalesTitle.Name = "lblSalesTitle";
            lblSalesTitle.Size = new Size(128, 26);
            lblSalesTitle.TabIndex = 11;
            lblSalesTitle.Text = "SOTUVDA:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Arial", 16F, FontStyle.Bold);
            lblTotal.ForeColor = Color.Green;
            lblTotal.Location = new Point(890, 661);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(74, 26);
            lblTotal.TabIndex = 13;
            lblTotal.Text = "JAMI: ";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = SystemColors.InactiveBorder;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { View, idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, amountDataGridViewTextBoxColumn, countDataGridViewTextBoxColumn });
            dataGridView1.DataSource = productBindingSource;
            dataGridView1.Location = new Point(291, 223);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(434, 335);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Models.Product);
            // 
            // listBox
            // 
            listBox.BackColor = SystemColors.ButtonFace;
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(890, 134);
            listBox.Name = "listBox";
            listBox.Size = new Size(338, 424);
            listBox.TabIndex = 15;
            listBox.MouseDoubleClick += listBox1_MouseDoubleClick;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button1.ForeColor = Color.Green;
            button1.Location = new Point(890, 578);
            button1.Name = "button1";
            button1.Size = new Size(118, 41);
            button1.TabIndex = 16;
            button1.Text = "Sotildi";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(273, 215);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(1101, 578);
            button2.Name = "button2";
            button2.Size = new Size(118, 41);
            button2.TabIndex = 18;
            button2.Text = "Tozalash";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // View
            // 
            View.HeaderText = "Rasmi";
            View.Name = "View";
            View.ReadOnly = true;
            View.Width = 60;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 60;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Nomi";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            amountDataGridViewTextBoxColumn.HeaderText = "Narxi";
            amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            amountDataGridViewTextBoxColumn.ReadOnly = true;
            amountDataGridViewTextBoxColumn.Width = 80;
            // 
            // countDataGridViewTextBoxColumn
            // 
            countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            countDataGridViewTextBoxColumn.HeaderText = "Miqdori";
            countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            countDataGridViewTextBoxColumn.ReadOnly = true;
            countDataGridViewTextBoxColumn.Width = 80;
            // 
            // Form1
            // 
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1798, 774);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(listBox);
            Controls.Add(dataGridView1);
            Controls.Add(titleLabel);
            Controls.Add(dateTimeLabel);
            Controls.Add(btnAdd);
            Controls.Add(btnView);
            Controls.Add(txtSearch);
            Controls.Add(btnAddToBucket);
            Controls.Add(lblSalesTitle);
            Controls.Add(lblTotal);
            Name = "Form1";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "Small Business Shop";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView dataGridView1;
        private ListBox listBox;
        private Button button1;
        private BindingSource productBindingSource;
        private System.ComponentModel.IContainer components;
        private PictureBox pictureBox1;
        private Button button2;
        private DataGridViewImageColumn View;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
    }
}
