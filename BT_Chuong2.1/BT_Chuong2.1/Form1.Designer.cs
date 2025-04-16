namespace BT_Chuong2._1
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
            lbSo1 = new Label();
            lbSo2 = new Label();
            btCong = new Button();
            btTru = new Button();
            btNhan = new Button();
            btChia = new Button();
            lbkqua = new Label();
            llKqua = new Label();
            btDong = new Button();
            txtSo1 = new TextBox();
            txtSo2 = new TextBox();
            Kqua = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(117, 26);
            label1.Name = "label1";
            label1.Size = new Size(549, 45);
            label1.TabIndex = 0;
            label1.Text = "CAC PHEP TINH DON GIAN";
            // 
            // lbSo1
            // 
            lbSo1.AutoSize = true;
            lbSo1.Location = new Point(63, 108);
            lbSo1.Name = "lbSo1";
            lbSo1.Size = new Size(83, 25);
            lbSo1.TabIndex = 1;
            lbSo1.Text = "So thu 1:";
            // 
            // lbSo2
            // 
            lbSo2.AutoSize = true;
            lbSo2.Location = new Point(430, 114);
            lbSo2.Name = "lbSo2";
            lbSo2.Size = new Size(83, 25);
            lbSo2.TabIndex = 1;
            lbSo2.Text = "So thu 2:";
            // 
            // btCong
            // 
            btCong.BackColor = Color.DimGray;
            btCong.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCong.Location = new Point(139, 198);
            btCong.Name = "btCong";
            btCong.Size = new Size(56, 59);
            btCong.TabIndex = 2;
            btCong.Text = "+";
            btCong.UseVisualStyleBackColor = false;
            btCong.Click += btCong_Click;
            // 
            // btTru
            // 
            btTru.BackColor = Color.DimGray;
            btTru.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btTru.Location = new Point(242, 198);
            btTru.Name = "btTru";
            btTru.Size = new Size(56, 59);
            btTru.TabIndex = 2;
            btTru.Text = "-";
            btTru.UseVisualStyleBackColor = false;
            btTru.Click += btTru_Click;
            // 
            // btNhan
            // 
            btNhan.BackColor = Color.DimGray;
            btNhan.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btNhan.Location = new Point(358, 198);
            btNhan.Name = "btNhan";
            btNhan.Size = new Size(56, 59);
            btNhan.TabIndex = 2;
            btNhan.Text = "x";
            btNhan.UseVisualStyleBackColor = false;
            btNhan.Click += btNhan_Click;
            // 
            // btChia
            // 
            btChia.BackColor = Color.DimGray;
            btChia.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btChia.Location = new Point(457, 198);
            btChia.Name = "btChia";
            btChia.Size = new Size(56, 59);
            btChia.TabIndex = 2;
            btChia.Text = "/";
            btChia.UseVisualStyleBackColor = false;
            btChia.Click += btChia_Click;
            // 
            // lbkqua
            // 
            lbkqua.AutoSize = true;
            lbkqua.Location = new Point(63, 336);
            lbkqua.Name = "lbkqua";
            lbkqua.Size = new Size(76, 25);
            lbkqua.TabIndex = 1;
            lbkqua.Text = "Ket qua:";
            // 
            // llKqua
            // 
            llKqua.AutoSize = true;
            llKqua.Location = new Point(242, 336);
            llKqua.Name = "llKqua";
            llKqua.Size = new Size(0, 25);
            llKqua.TabIndex = 1;
            // 
            // btDong
            // 
            btDong.BackColor = Color.Gray;
            btDong.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btDong.ForeColor = Color.Black;
            btDong.Location = new Point(468, 336);
            btDong.Name = "btDong";
            btDong.Size = new Size(119, 34);
            btDong.TabIndex = 3;
            btDong.Text = "Dong";
            btDong.UseVisualStyleBackColor = false;
            btDong.Click += btDong_Click;
            // 
            // txtSo1
            // 
            txtSo1.Location = new Point(170, 108);
            txtSo1.Name = "txtSo1";
            txtSo1.Size = new Size(150, 31);
            txtSo1.TabIndex = 4;
            // 
            // txtSo2
            // 
            txtSo2.Location = new Point(541, 111);
            txtSo2.Name = "txtSo2";
            txtSo2.Size = new Size(150, 31);
            txtSo2.TabIndex = 4;
            // 
            // Kqua
            // 
            Kqua.AutoSize = true;
            Kqua.Location = new Point(205, 336);
            Kqua.Name = "Kqua";
            Kqua.Size = new Size(131, 25);
            Kqua.TabIndex = 5;
            Kqua.Text = "_________________";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(Kqua);
            Controls.Add(txtSo2);
            Controls.Add(txtSo1);
            Controls.Add(btDong);
            Controls.Add(btChia);
            Controls.Add(btNhan);
            Controls.Add(btTru);
            Controls.Add(btCong);
            Controls.Add(lbSo2);
            Controls.Add(llKqua);
            Controls.Add(lbkqua);
            Controls.Add(lbSo1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Cac phep tinh";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbSo1;
        private Label lbSo2;
        private Button btCong;
        private Button btTru;
        private Button btNhan;
        private Button btChia;
        private Label lbkqua;
        private Label llKqua;
        private Button btDong;
        private TextBox txtSo1;
        private TextBox txtSo2;
        private Label Kqua;
    }
}
