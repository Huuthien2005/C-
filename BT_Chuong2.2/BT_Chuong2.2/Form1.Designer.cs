namespace BT_Chuong2._2
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
            label = new Label();
            lbSo1 = new Label();
            lbSo2 = new Label();
            txtSo1 = new TextBox();
            txtSo2 = new TextBox();
            gb1 = new GroupBox();
            rdMode = new RadioButton();
            rdChia = new RadioButton();
            rdNhan = new RadioButton();
            rdTru = new RadioButton();
            rdCong = new RadioButton();
            Labelkqua = new Label();
            lbKqua = new Label();
            btTinh = new Button();
            gb1.SuspendLayout();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.Location = new Point(109, 9);
            label.Name = "label";
            label.Size = new Size(549, 45);
            label.TabIndex = 0;
            label.Text = "CAC PHEP TINH DON GIAN";
            // 
            // lbSo1
            // 
            lbSo1.AutoSize = true;
            lbSo1.Location = new Point(46, 88);
            lbSo1.Name = "lbSo1";
            lbSo1.Size = new Size(83, 25);
            lbSo1.TabIndex = 1;
            lbSo1.Text = "So thu 1:";
            // 
            // lbSo2
            // 
            lbSo2.AutoSize = true;
            lbSo2.Location = new Point(422, 88);
            lbSo2.Name = "lbSo2";
            lbSo2.Size = new Size(83, 25);
            lbSo2.TabIndex = 1;
            lbSo2.Text = "So thu 2:";
            // 
            // txtSo1
            // 
            txtSo1.Location = new Point(201, 88);
            txtSo1.Name = "txtSo1";
            txtSo1.Size = new Size(150, 31);
            txtSo1.TabIndex = 2;
            // 
            // txtSo2
            // 
            txtSo2.Location = new Point(556, 88);
            txtSo2.Name = "txtSo2";
            txtSo2.Size = new Size(150, 31);
            txtSo2.TabIndex = 2;
            // 
            // gb1
            // 
            gb1.BackColor = SystemColors.ActiveCaption;
            gb1.Controls.Add(rdMode);
            gb1.Controls.Add(rdChia);
            gb1.Controls.Add(rdNhan);
            gb1.Controls.Add(rdTru);
            gb1.Controls.Add(rdCong);
            gb1.Location = new Point(239, 181);
            gb1.Name = "gb1";
            gb1.Size = new Size(467, 88);
            gb1.TabIndex = 3;
            gb1.TabStop = false;
            gb1.Text = "Chon phep toan";
            // 
            // rdMode
            // 
            rdMode.AutoSize = true;
            rdMode.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdMode.Location = new Point(403, 43);
            rdMode.Name = "rdMode";
            rdMode.Size = new Size(53, 29);
            rdMode.TabIndex = 0;
            rdMode.TabStop = true;
            rdMode.Text = "%";
            rdMode.UseVisualStyleBackColor = true;
            // 
            // rdChia
            // 
            rdChia.AutoSize = true;
            rdChia.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdChia.Location = new Point(317, 43);
            rdChia.Name = "rdChia";
            rdChia.Size = new Size(45, 29);
            rdChia.TabIndex = 0;
            rdChia.TabStop = true;
            rdChia.Text = "/";
            rdChia.UseVisualStyleBackColor = true;
            // 
            // rdNhan
            // 
            rdNhan.AutoSize = true;
            rdNhan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdNhan.Location = new Point(219, 43);
            rdNhan.Name = "rdNhan";
            rdNhan.Size = new Size(47, 29);
            rdNhan.TabIndex = 0;
            rdNhan.TabStop = true;
            rdNhan.Text = "x";
            rdNhan.UseVisualStyleBackColor = true;
            // 
            // rdTru
            // 
            rdTru.AutoSize = true;
            rdTru.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdTru.Location = new Point(132, 43);
            rdTru.Name = "rdTru";
            rdTru.Size = new Size(44, 29);
            rdTru.TabIndex = 0;
            rdTru.TabStop = true;
            rdTru.Text = "-";
            rdTru.UseVisualStyleBackColor = true;
            // 
            // rdCong
            // 
            rdCong.AutoSize = true;
            rdCong.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdCong.Location = new Point(29, 43);
            rdCong.Name = "rdCong";
            rdCong.Size = new Size(50, 29);
            rdCong.TabIndex = 0;
            rdCong.TabStop = true;
            rdCong.Text = "+";
            rdCong.UseVisualStyleBackColor = true;
            // 
            // Labelkqua
            // 
            Labelkqua.AutoSize = true;
            Labelkqua.Location = new Point(46, 325);
            Labelkqua.Name = "Labelkqua";
            Labelkqua.Size = new Size(76, 25);
            Labelkqua.TabIndex = 1;
            Labelkqua.Text = "Ket qua:";
            // 
            // lbKqua
            // 
            lbKqua.AutoSize = true;
            lbKqua.BackColor = SystemColors.ActiveCaption;
            lbKqua.Location = new Point(175, 328);
            lbKqua.Name = "lbKqua";
            lbKqua.Size = new Size(108, 25);
            lbKqua.TabIndex = 4;
            lbKqua.Text = "........................";
            // 
            // btTinh
            // 
            btTinh.BackColor = SystemColors.AppWorkspace;
            btTinh.Location = new Point(422, 328);
            btTinh.Name = "btTinh";
            btTinh.Size = new Size(112, 34);
            btTinh.TabIndex = 5;
            btTinh.Text = "Tinh";
            btTinh.UseVisualStyleBackColor = false;
            btTinh.Click += btTinh_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(btTinh);
            Controls.Add(lbKqua);
            Controls.Add(gb1);
            Controls.Add(txtSo2);
            Controls.Add(txtSo1);
            Controls.Add(lbSo2);
            Controls.Add(Labelkqua);
            Controls.Add(lbSo1);
            Controls.Add(label);
            Name = "Form1";
            Text = "Form1";
            gb1.ResumeLayout(false);
            gb1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private Label lbSo1;
        private Label lbSo2;
        private TextBox txtSo1;
        private TextBox txtSo2;
        private GroupBox gb1;
        private RadioButton rdChia;
        private RadioButton rdNhan;
        private RadioButton rdTru;
        private RadioButton rdCong;
        private Label Labelkqua;
        private Label lbKqua;
        private Button btTinh;
        private RadioButton rdMode;
    }
}
