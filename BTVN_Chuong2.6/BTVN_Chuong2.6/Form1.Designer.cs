namespace BTVN_Chuong2._6
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtMSSV = new TextBox();
            txtLName = new TextBox();
            txtFName = new TextBox();
            btnAdd = new Button();
            btnSearch = new Button();
            btnSort = new Button();
            lstShow = new ListBox();
            txtSearch = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(67, 31);
            label1.Name = "label1";
            label1.Size = new Size(102, 38);
            label1.TabIndex = 0;
            label1.Text = "MSSV:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(67, 94);
            label2.Name = "label2";
            label2.Size = new Size(63, 38);
            label2.TabIndex = 0;
            label2.Text = "Họ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(67, 162);
            label3.Name = "label3";
            label3.Size = new Size(70, 38);
            label3.TabIndex = 0;
            label3.Text = "Tên:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(67, 292);
            label4.Name = "label4";
            label4.Size = new Size(150, 38);
            label4.TabIndex = 0;
            label4.Text = "Tìm Kiếm:";
            // 
            // txtMSSV
            // 
            txtMSSV.Location = new Point(241, 38);
            txtMSSV.Name = "txtMSSV";
            txtMSSV.Size = new Size(379, 31);
            txtMSSV.TabIndex = 0;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(241, 102);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(379, 31);
            txtLName.TabIndex = 1;
            // 
            // txtFName
            // 
            txtFName.Location = new Point(241, 170);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(379, 31);
            txtFName.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(265, 222);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(336, 47);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Nhập Sinh Viên";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(252, 418);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(336, 47);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Tìm Kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnSort
            // 
            btnSort.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSort.Location = new Point(265, 622);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(336, 47);
            btnSort.TabIndex = 6;
            btnSort.Text = "Sắp Xếp";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // lstShow
            // 
            lstShow.FormattingEnabled = true;
            lstShow.ItemHeight = 25;
            lstShow.Location = new Point(255, 502);
            lstShow.Name = "lstShow";
            lstShow.Size = new Size(365, 104);
            lstShow.TabIndex = 7;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(241, 299);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(379, 31);
            txtSearch.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 727);
            Controls.Add(lstShow);
            Controls.Add(btnSort);
            Controls.Add(btnSearch);
            Controls.Add(btnAdd);
            Controls.Add(txtSearch);
            Controls.Add(txtFName);
            Controls.Add(txtLName);
            Controls.Add(txtMSSV);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Quản Lý Sinh Viên";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtMSSV;
        private TextBox txtLName;
        private TextBox txtFName;
        private Button btnAdd;
        private Button btnSearch;
        private Button btnSort;
        private ListBox lstShow;
        private TextBox txtSearch;
    }
}
