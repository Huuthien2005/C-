namespace ListView_demo
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
            lblName = new Label();
            lblHocVan = new Label();
            txtHocVan = new TextBox();
            txtName = new TextBox();
            label1 = new Label();
            rbtnM = new RadioButton();
            rbtnF = new RadioButton();
            btnAdd = new Button();
            btnDel = new Button();
            Lv = new ListView();
            cbView = new ComboBox();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(134, 45);
            lblName.Name = "lblName";
            lblName.Size = new Size(71, 25);
            lblName.TabIndex = 0;
            lblName.Text = "Họ Tên:";
            // 
            // lblHocVan
            // 
            lblHocVan.AutoSize = true;
            lblHocVan.Location = new Point(134, 119);
            lblHocVan.Name = "lblHocVan";
            lblHocVan.Size = new Size(154, 25);
            lblHocVan.TabIndex = 0;
            lblHocVan.Text = "Trình Độ Học Vấn:";
            // 
            // txtHocVan
            // 
            txtHocVan.Location = new Point(347, 113);
            txtHocVan.Name = "txtHocVan";
            txtHocVan.Size = new Size(150, 31);
            txtHocVan.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(347, 42);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 31);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 190);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 0;
            label1.Text = "Giới Tính:";
            // 
            // rbtnM
            // 
            rbtnM.AutoSize = true;
            rbtnM.Location = new Point(347, 190);
            rbtnM.Name = "rbtnM";
            rbtnM.Size = new Size(75, 29);
            rbtnM.TabIndex = 2;
            rbtnM.TabStop = true;
            rbtnM.Text = "Nam";
            rbtnM.UseVisualStyleBackColor = true;
            // 
            // rbtnF
            // 
            rbtnF.AutoSize = true;
            rbtnF.Location = new Point(445, 190);
            rbtnF.Name = "rbtnF";
            rbtnF.Size = new Size(61, 29);
            rbtnF.TabIndex = 2;
            rbtnF.TabStop = true;
            rbtnF.Text = "Nữ";
            rbtnF.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(654, 190);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(654, 258);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(112, 34);
            btnDel.TabIndex = 3;
            btnDel.Text = "Xóa";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // Lv
            // 
            Lv.Location = new Point(87, 225);
            Lv.Name = "Lv";
            Lv.Size = new Size(509, 198);
            Lv.TabIndex = 4;
            Lv.UseCompatibleStateImageBehavior = false;
            // 
            // cbView
            // 
            cbView.FormattingEnabled = true;
            cbView.Location = new Point(654, 314);
            cbView.Name = "cbView";
            cbView.Size = new Size(116, 33);
            cbView.TabIndex = 5;
            cbView.SelectedIndexChanged += cbView_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbView);
            Controls.Add(Lv);
            Controls.Add(btnDel);
            Controls.Add(btnAdd);
            Controls.Add(rbtnF);
            Controls.Add(rbtnM);
            Controls.Add(txtName);
            Controls.Add(txtHocVan);
            Controls.Add(label1);
            Controls.Add(lblHocVan);
            Controls.Add(lblName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblHocVan;
        private TextBox txtHocVan;
        private TextBox txtName;
        private Label label1;
        private RadioButton rbtnM;
        private RadioButton rbtnF;
        private Button btnAdd;
        private Button btnDel;
        private ListView Lv;
        private ComboBox cbView;
    }
}
