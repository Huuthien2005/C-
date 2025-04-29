namespace BT_chuong4._3
{
    partial class FrmMain
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
            lblName = new Label();
            lblDoB = new Label();
            txtName = new TextBox();
            dtpDoB = new DateTimePicker();
            Lv = new ListView();
            rbtnNam = new RadioButton();
            rbtnNu = new RadioButton();
            btnAdd = new Button();
            btnDel = new Button();
            txtNameUser = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(285, 43);
            label1.Name = "label1";
            label1.Size = new Size(495, 70);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Nhân Viên";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(37, 152);
            lblName.Name = "lblName";
            lblName.Size = new Size(71, 25);
            lblName.TabIndex = 1;
            lblName.Text = "Họ Tên:";
            // 
            // lblDoB
            // 
            lblDoB.AutoSize = true;
            lblDoB.Location = new Point(37, 202);
            lblDoB.Name = "lblDoB";
            lblDoB.Size = new Size(97, 25);
            lblDoB.TabIndex = 1;
            lblDoB.Text = "Ngày Sinh:";
            // 
            // txtName
            // 
            txtName.Location = new Point(147, 149);
            txtName.Name = "txtName";
            txtName.Size = new Size(293, 31);
            txtName.TabIndex = 2;
            // 
            // dtpDoB
            // 
            dtpDoB.CustomFormat = "dd/MM/yyyy";
            dtpDoB.Location = new Point(147, 202);
            dtpDoB.Name = "dtpDoB";
            dtpDoB.Size = new Size(293, 31);
            dtpDoB.TabIndex = 3;
            dtpDoB.Value = new DateTime(2025, 4, 24, 23, 59, 59, 0);
            // 
            // Lv
            // 
            Lv.Location = new Point(520, 152);
            Lv.Name = "Lv";
            Lv.Size = new Size(567, 253);
            Lv.TabIndex = 4;
            Lv.UseCompatibleStateImageBehavior = false;
            // 
            // rbtnNam
            // 
            rbtnNam.AutoSize = true;
            rbtnNam.Location = new Point(186, 272);
            rbtnNam.Name = "rbtnNam";
            rbtnNam.Size = new Size(75, 29);
            rbtnNam.TabIndex = 5;
            rbtnNam.TabStop = true;
            rbtnNam.Text = "Nam";
            rbtnNam.UseVisualStyleBackColor = true;
            // 
            // rbtnNu
            // 
            rbtnNu.AutoSize = true;
            rbtnNu.Location = new Point(351, 272);
            rbtnNu.Name = "rbtnNu";
            rbtnNu.Size = new Size(61, 29);
            rbtnNu.TabIndex = 5;
            rbtnNu.TabStop = true;
            rbtnNu.Text = "Nữ";
            rbtnNu.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(164, 331);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(328, 331);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(112, 34);
            btnDel.TabIndex = 6;
            btnDel.Text = "Xóa";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // txtNameUser
            // 
            txtNameUser.Location = new Point(145, 390);
            txtNameUser.Name = "txtNameUser";
            txtNameUser.ReadOnly = true;
            txtNameUser.Size = new Size(295, 31);
            txtNameUser.TabIndex = 7;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 450);
            Controls.Add(txtNameUser);
            Controls.Add(btnDel);
            Controls.Add(btnAdd);
            Controls.Add(rbtnNu);
            Controls.Add(rbtnNam);
            Controls.Add(Lv);
            Controls.Add(dtpDoB);
            Controls.Add(txtName);
            Controls.Add(lblDoB);
            Controls.Add(lblName);
            Controls.Add(label1);
            Name = "FrmMain";
            Text = "Quản Lý Nhân Viên";
            Load += FrmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblName;
        private Label lblDoB;
        private TextBox txtName;
        private DateTimePicker dtpDoB;
        private ListView Lv;
        private RadioButton rbtnNam;
        private RadioButton rbtnNu;
        private Button btnAdd;
        private Button btnDel;
        private TextBox txtNameUser;
    }
}
