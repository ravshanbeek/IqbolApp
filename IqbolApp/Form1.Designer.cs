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
            titleLabel = new Label();
            dateTimeLabel = new Label();
            btnAdd = new Button();
            btnView = new Button();
            txtSearch = new TextBox();
            btnAddToBucket = new Button();
            lblSalesTitle = new Label();
            lblTotal = new Label();
            dataGridView1 = new DataGridView();
            listBox = new ListBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Arial", 36F, FontStyle.Bold);
            titleLabel.ForeColor = Color.Goldenrod;
            titleLabel.Location = new Point(480, 20);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(428, 70);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "DOKON NOMI";
            // 
            // dateTimeLabel
            // 
            dateTimeLabel.AutoSize = true;
            dateTimeLabel.Font = new Font("Arial", 14F);
            dateTimeLabel.Location = new Point(20, 20);
            dateTimeLabel.Name = "dateTimeLabel";
            dateTimeLabel.Size = new Size(0, 27);
            dateTimeLabel.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Arial", 14F);
            btnAdd.ForeColor = Color.Blue;
            btnAdd.Location = new Point(50, 270);
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
            btnView.Location = new Point(50, 340);
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
            txtSearch.Location = new Point(303, 134);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(515, 52);
            txtSearch.TabIndex = 5;
            // 
            // btnAddToBucket
            // 
            btnAddToBucket.BackColor = Color.Green;
            btnAddToBucket.FlatStyle = FlatStyle.Flat;
            btnAddToBucket.Font = new Font("Arial", 14F);
            btnAddToBucket.ForeColor = Color.White;
            btnAddToBucket.Location = new Point(852, 134);
            btnAddToBucket.Name = "btnAddToBucket";
            btnAddToBucket.Size = new Size(186, 52);
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
            lblSalesTitle.Location = new Point(1221, 34);
            lblSalesTitle.Name = "lblSalesTitle";
            lblSalesTitle.Size = new Size(158, 32);
            lblSalesTitle.TabIndex = 11;
            lblSalesTitle.Text = "SOTUVDA:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Arial", 16F, FontStyle.Bold);
            lblTotal.ForeColor = Color.Green;
            lblTotal.Location = new Point(1134, 666);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(95, 32);
            lblTotal.TabIndex = 13;
            lblTotal.Text = "JAMI: ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(303, 249);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(515, 335);
            dataGridView1.TabIndex = 14;
            //dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.Location = new Point(1134, 139);
            listBox.Name = "listBox";
            listBox.Size = new Size(338, 424);
            listBox.TabIndex = 15;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(1354, 588);
            button1.Name = "button1";
            button1.Size = new Size(118, 41);
            button1.TabIndex = 16;
            button1.Text = "Sotildi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            BackColor = Color.White;
            ClientSize = new Size(1507, 767);
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
            Text = "Small Business Shop";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView dataGridView1;
        private ListBox listBox;
        private Button button1;
    }
}
