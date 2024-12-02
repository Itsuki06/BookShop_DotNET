namespace BookShop
{
    partial class Billing
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnLogOut = new Button();
            lblTitle = new Label();
            panel2 = new Panel();
            lblTotal = new Label();
            btnPrintBill = new Button();
            btnReset = new Button();
            btnAdd = new Button();
            lblMiniTitle = new Label();
            lblBill = new Label();
            lblList = new Label();
            tbPrice = new TextBox();
            tbClientName = new TextBox();
            tbQuantity = new TextBox();
            tbBookName = new TextBox();
            lblPrice = new Label();
            lblClientName = new Label();
            lblQuantity = new Label();
            lblBookName = new Label();
            dgvList = new DataGridView();
            dgvBill = new DataGridView();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBill).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SaddleBrown;
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(lblTitle);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 737);
            panel1.TabIndex = 0;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.SaddleBrown;
            btnLogOut.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Location = new Point(14, 671);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(173, 50);
            btnLogOut.TabIndex = 16;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(14, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(173, 37);
            lblTitle.TabIndex = 12;
            lblTitle.Text = "BookShop";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FloralWhite;
            panel2.Controls.Add(lblTotal);
            panel2.Controls.Add(btnPrintBill);
            panel2.Controls.Add(btnReset);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(lblMiniTitle);
            panel2.Controls.Add(lblBill);
            panel2.Controls.Add(lblList);
            panel2.Controls.Add(tbPrice);
            panel2.Controls.Add(tbClientName);
            panel2.Controls.Add(tbQuantity);
            panel2.Controls.Add(tbBookName);
            panel2.Controls.Add(lblPrice);
            panel2.Controls.Add(lblClientName);
            panel2.Controls.Add(lblQuantity);
            panel2.Controls.Add(lblBookName);
            panel2.Controls.Add(dgvList);
            panel2.Controls.Add(dgvBill);
            panel2.Location = new Point(205, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(1047, 737);
            panel2.TabIndex = 1;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.FlatStyle = FlatStyle.Flat;
            lblTotal.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.Crimson;
            lblTotal.Location = new Point(712, 546);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(242, 37);
            lblTotal.TabIndex = 16;
            lblTotal.Text = "Total:                ";
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPrintBill
            // 
            btnPrintBill.BackColor = Color.SaddleBrown;
            btnPrintBill.Font = new Font("Microsoft Sans Serif", 15.75F);
            btnPrintBill.ForeColor = Color.White;
            btnPrintBill.Location = new Point(736, 613);
            btnPrintBill.Name = "btnPrintBill";
            btnPrintBill.Size = new Size(140, 42);
            btnPrintBill.TabIndex = 15;
            btnPrintBill.Text = "Print Bill";
            btnPrintBill.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.SaddleBrown;
            btnReset.Font = new Font("Microsoft Sans Serif", 15.75F);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(268, 282);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(100, 42);
            btnReset.TabIndex = 14;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.SaddleBrown;
            btnAdd.Font = new Font("Microsoft Sans Serif", 15.75F);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(75, 282);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(140, 42);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add To Bill";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblMiniTitle
            // 
            lblMiniTitle.AutoSize = true;
            lblMiniTitle.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMiniTitle.ForeColor = Color.SaddleBrown;
            lblMiniTitle.Location = new Point(437, 10);
            lblMiniTitle.Name = "lblMiniTitle";
            lblMiniTitle.Size = new Size(119, 25);
            lblMiniTitle.TabIndex = 12;
            lblMiniTitle.Text = "BookShop";
            // 
            // lblBill
            // 
            lblBill.AutoSize = true;
            lblBill.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBill.ForeColor = Color.SaddleBrown;
            lblBill.Location = new Point(721, 67);
            lblBill.Name = "lblBill";
            lblBill.Size = new Size(143, 31);
            lblBill.TabIndex = 11;
            lblBill.Text = "Books Bill";
            // 
            // lblList
            // 
            lblList.AutoSize = true;
            lblList.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblList.ForeColor = Color.SaddleBrown;
            lblList.Location = new Point(196, 346);
            lblList.Name = "lblList";
            lblList.Size = new Size(150, 31);
            lblList.TabIndex = 10;
            lblList.Text = "Books List";
            // 
            // tbPrice
            // 
            tbPrice.Enabled = false;
            tbPrice.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPrice.Location = new Point(268, 224);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(100, 31);
            tbPrice.TabIndex = 9;
            // 
            // tbClientName
            // 
            tbClientName.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbClientName.Location = new Point(26, 224);
            tbClientName.Name = "tbClientName";
            tbClientName.Size = new Size(220, 31);
            tbClientName.TabIndex = 8;
            // 
            // tbQuantity
            // 
            tbQuantity.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbQuantity.Location = new Point(268, 136);
            tbQuantity.Name = "tbQuantity";
            tbQuantity.Size = new Size(100, 31);
            tbQuantity.TabIndex = 7;
            // 
            // tbBookName
            // 
            tbBookName.Enabled = false;
            tbBookName.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbBookName.Location = new Point(26, 136);
            tbBookName.Name = "tbBookName";
            tbBookName.Size = new Size(220, 31);
            tbBookName.TabIndex = 6;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(268, 189);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(61, 25);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "Price";
            // 
            // lblClientName
            // 
            lblClientName.AutoSize = true;
            lblClientName.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClientName.Location = new Point(26, 189);
            lblClientName.Name = "lblClientName";
            lblClientName.Size = new Size(129, 25);
            lblClientName.TabIndex = 4;
            lblClientName.Text = "Client Name";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuantity.Location = new Point(268, 102);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(92, 25);
            lblQuantity.TabIndex = 3;
            lblQuantity.Text = "Quantity";
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBookName.Location = new Point(26, 102);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(123, 25);
            lblBookName.TabIndex = 2;
            lblBookName.Text = "Book Name";
            // 
            // dgvList
            // 
            dgvList.BackgroundColor = Color.White;
            dgvList.BorderStyle = BorderStyle.Fixed3D;
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvList.Location = new Point(28, 391);
            dgvList.MultiSelect = false;
            dgvList.Name = "dgvList";
            dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvList.Size = new Size(500, 330);
            dgvList.TabIndex = 1;
            dgvList.CellContentClick += dgvList_CellContentClick;
            // 
            // dgvBill
            // 
            dgvBill.BackgroundColor = Color.White;
            dgvBill.BorderStyle = BorderStyle.Fixed3D;
            dgvBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBill.Location = new Point(565, 110);
            dgvBill.Name = "dgvBill";
            dgvBill.Size = new Size(450, 400);
            dgvBill.TabIndex = 0;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // Billing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Chocolate;
            ClientSize = new Size(1264, 761);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Billing";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formBilling";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBill).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvList;
        private DataGridView dgvBill;
        private Label lblBookName;
        private TextBox tbPrice;
        private TextBox tbClientName;
        private TextBox tbQuantity;
        private TextBox tbBookName;
        private Label lblPrice;
        private Label lblClientName;
        private Label lblQuantity;
        private Label lblBill;
        private Label lblList;
        private Label lblTitle;
        private Button btnAdd;
        private Label lblMiniTitle;
        private Button btnLogOut;
        private Button btnPrintBill;
        private Button btnReset;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label lblTotal;
    }
}
