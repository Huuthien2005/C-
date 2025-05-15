namespace BT_Chuong2._5
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
            lblS1 = new Label();
            lblS2 = new Label();
            lblS3 = new Label();
            groupBox1 = new GroupBox();
            btChen = new Button();
            txtVitrichen = new TextBox();
            label2 = new Label();
            btVitriChen = new TextBox();
            txtS2 = new TextBox();
            txtS3 = new TextBox();
            txtS1 = new TextBox();
            btDao = new Button();
            btThayThe = new Button();
            btChuanhoa = new Button();
            btXoa = new Button();
            btKhoiphuc = new Button();
            groupBox2 = new GroupBox();
            txtSokytu = new TextBox();
            txtVitriLay = new TextBox();
            label4 = new Label();
            label3 = new Label();
            btLayChuoi = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(-2, 0);
            label1.Name = "label1";
            label1.Size = new Size(988, 67);
            label1.TabIndex = 0;
            label1.Text = "CHƯƠNG TRÌNH MINH HỌA XỬ LÝ CHUỖI";
            // 
            // lblS1
            // 
            lblS1.AutoSize = true;
            lblS1.Location = new Point(52, 109);
            lblS1.Name = "lblS1";
            lblS1.Size = new Size(82, 25);
            lblS1.TabIndex = 1;
            lblS1.Text = "chuỗi s1:";
            // 
            // lblS2
            // 
            lblS2.AutoSize = true;
            lblS2.Location = new Point(52, 184);
            lblS2.Name = "lblS2";
            lblS2.Size = new Size(82, 25);
            lblS2.TabIndex = 1;
            lblS2.Text = "chuỗi s2:";
            // 
            // lblS3
            // 
            lblS3.AutoSize = true;
            lblS3.Location = new Point(564, 184);
            lblS3.Name = "lblS3";
            lblS3.Size = new Size(82, 25);
            lblS3.TabIndex = 1;
            lblS3.Text = "chuỗi s3:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btChen);
            groupBox1.Controls.Add(txtVitrichen);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(42, 227);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 80);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chèn chuỗi s2 vào s1:";
            // 
            // btChen
            // 
            btChen.Location = new Point(205, 36);
            btChen.Name = "btChen";
            btChen.Size = new Size(89, 34);
            btChen.TabIndex = 2;
            btChen.Text = "Chèn";
            btChen.UseVisualStyleBackColor = true;
            btChen.Click += btChen_Click;
            // 
            // txtVitrichen
            // 
            txtVitrichen.Location = new Point(105, 32);
            txtVitrichen.Name = "txtVitrichen";
            txtVitrichen.Size = new Size(78, 31);
            txtVitrichen.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 38);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 1;
            label2.Text = "Vi trí chèn: ";
            // 
            // btVitriChen
            // 
            btVitriChen.Location = new Point(1193, 416);
            btVitriChen.Name = "btVitriChen";
            btVitriChen.Size = new Size(78, 31);
            btVitriChen.TabIndex = 3;
            // 
            // txtS2
            // 
            txtS2.Location = new Point(147, 181);
            txtS2.Name = "txtS2";
            txtS2.Size = new Size(262, 31);
            txtS2.TabIndex = 3;
            // 
            // txtS3
            // 
            txtS3.Location = new Point(693, 184);
            txtS3.Name = "txtS3";
            txtS3.Size = new Size(262, 31);
            txtS3.TabIndex = 3;
            // 
            // txtS1
            // 
            txtS1.Location = new Point(147, 109);
            txtS1.Name = "txtS1";
            txtS1.Size = new Size(712, 31);
            txtS1.TabIndex = 3;
            // 
            // btDao
            // 
            btDao.Location = new Point(766, 256);
            btDao.Name = "btDao";
            btDao.Size = new Size(176, 34);
            btDao.TabIndex = 2;
            btDao.Text = "Đảo từ trong s1";
            btDao.UseVisualStyleBackColor = true;
            btDao.Click += btDao_Click;
            // 
            // btThayThe
            // 
            btThayThe.Location = new Point(519, 256);
            btThayThe.Name = "btThayThe";
            btThayThe.Size = new Size(182, 34);
            btThayThe.TabIndex = 2;
            btThayThe.Text = "Thay thế s2 bằng s3";
            btThayThe.UseVisualStyleBackColor = true;
            btThayThe.Click += btThayThe_Click;
            // 
            // btChuanhoa
            // 
            btChuanhoa.Location = new Point(766, 305);
            btChuanhoa.Name = "btChuanhoa";
            btChuanhoa.Size = new Size(176, 34);
            btChuanhoa.TabIndex = 2;
            btChuanhoa.Text = "Chuẩn Hóa Chuỗi";
            btChuanhoa.UseVisualStyleBackColor = true;
            btChuanhoa.Click += btChuanhoa_Click;
            // 
            // btXoa
            // 
            btXoa.Location = new Point(519, 305);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(182, 34);
            btXoa.TabIndex = 2;
            btXoa.Text = "Xóa s2 trong s1";
            btXoa.UseVisualStyleBackColor = true;
            btXoa.Click += btXoa_Click;
            // 
            // btKhoiphuc
            // 
            btKhoiphuc.Location = new Point(678, 373);
            btKhoiphuc.Name = "btKhoiphuc";
            btKhoiphuc.Size = new Size(163, 34);
            btKhoiphuc.TabIndex = 2;
            btKhoiphuc.Text = "Khôi Phục";
            btKhoiphuc.UseVisualStyleBackColor = true;
            btKhoiphuc.Click += btKhoiphuc_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtSokytu);
            groupBox2.Controls.Add(txtVitriLay);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(btLayChuoi);
            groupBox2.Location = new Point(42, 351);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(507, 75);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lấy chuỗi con trong s1";
            // 
            // txtSokytu
            // 
            txtSokytu.Location = new Point(296, 39);
            txtSokytu.Name = "txtSokytu";
            txtSokytu.Size = new Size(78, 31);
            txtSokytu.TabIndex = 3;
            // 
            // txtVitriLay
            // 
            txtVitriLay.Location = new Point(105, 39);
            txtVitriLay.Name = "txtVitriLay";
            txtVitriLay.Size = new Size(78, 31);
            txtVitriLay.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(205, 41);
            label4.Name = "label4";
            label4.Size = new Size(85, 25);
            label4.TabIndex = 0;
            label4.Text = "Số Ký Tự:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 41);
            label3.Name = "label3";
            label3.Size = new Size(71, 25);
            label3.TabIndex = 0;
            label3.Text = "Từ vị trí";
            // 
            // btLayChuoi
            // 
            btLayChuoi.Location = new Point(400, 36);
            btLayChuoi.Name = "btLayChuoi";
            btLayChuoi.Size = new Size(101, 34);
            btLayChuoi.TabIndex = 2;
            btLayChuoi.Text = "Lấy chuỗi con";
            btLayChuoi.UseVisualStyleBackColor = true;
            btLayChuoi.Click += btLayChuoi_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 450);
            Controls.Add(btVitriChen);
            Controls.Add(groupBox2);
            Controls.Add(txtS3);
            Controls.Add(btKhoiphuc);
            Controls.Add(btXoa);
            Controls.Add(btThayThe);
            Controls.Add(btChuanhoa);
            Controls.Add(btDao);
            Controls.Add(txtS1);
            Controls.Add(txtS2);
            Controls.Add(lblS2);
            Controls.Add(groupBox1);
            Controls.Add(lblS3);
            Controls.Add(lblS1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Xử lý chuỗi";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblS1;
        private Label lblS2;
        private Label lblS3;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox btVitriChen;
        private Button btChen;
        private TextBox txtS2;
        private TextBox txtS3;
        private TextBox txtS1;
        private Button btDao;
        private Button btThayThe;
        private Button btChuanhoa;
        private Button btXoa;
        private Button btKhoiphuc;
        private GroupBox groupBox2;
        private TextBox txtSokytu;
        private TextBox txtVitriLay;
        private Label label4;
        private Label label3;
        private Button btLayChuoi;
        private TextBox txtVitrichen;
    }
}
