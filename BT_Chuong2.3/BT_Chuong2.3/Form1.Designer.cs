namespace BT_Chuong2._3
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
            rd3 = new RadioButton();
            groupBox1 = new GroupBox();
            rd11 = new RadioButton();
            btQuay = new Button();
            lbSo1 = new Label();
            lbSo2 = new Label();
            lbSo3 = new Label();
            lbDiem = new Label();
            lbKqua = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // rd3
            // 
            rd3.Appearance = Appearance.Button;
            rd3.AutoSize = true;
            rd3.Checked = true;
            rd3.Location = new Point(106, 40);
            rd3.Name = "rd3";
            rd3.Size = new Size(59, 35);
            rd3.TabIndex = 0;
            rd3.TabStop = true;
            rd3.Text = "3-10";
            rd3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rd11);
            groupBox1.Controls.Add(rd3);
            groupBox1.Location = new Point(87, 161);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(508, 101);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chon";
            // 
            // rd11
            // 
            rd11.Appearance = Appearance.Button;
            rd11.AutoSize = true;
            rd11.Location = new Point(337, 40);
            rd11.Name = "rd11";
            rd11.Size = new Size(69, 35);
            rd11.TabIndex = 0;
            rd11.Text = "11-18";
            rd11.UseVisualStyleBackColor = true;
            // 
            // btQuay
            // 
            btQuay.Location = new Point(87, 341);
            btQuay.Name = "btQuay";
            btQuay.Size = new Size(112, 34);
            btQuay.TabIndex = 2;
            btQuay.Text = "Quay so";
            btQuay.UseVisualStyleBackColor = true;
            btQuay.Click += btQuay_Click;
            // 
            // lbSo1
            // 
            lbSo1.AutoSize = true;
            lbSo1.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSo1.Location = new Point(131, 51);
            lbSo1.Name = "lbSo1";
            lbSo1.Size = new Size(62, 74);
            lbSo1.TabIndex = 3;
            lbSo1.Text = "0";
            // 
            // lbSo2
            // 
            lbSo2.AutoSize = true;
            lbSo2.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSo2.Location = new Point(331, 51);
            lbSo2.Name = "lbSo2";
            lbSo2.Size = new Size(62, 74);
            lbSo2.TabIndex = 3;
            lbSo2.Text = "0";
            // 
            // lbSo3
            // 
            lbSo3.AutoSize = true;
            lbSo3.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSo3.Location = new Point(533, 51);
            lbSo3.Name = "lbSo3";
            lbSo3.Size = new Size(62, 74);
            lbSo3.TabIndex = 3;
            lbSo3.Text = "0";
            // 
            // lbDiem
            // 
            lbDiem.AutoSize = true;
            lbDiem.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDiem.Location = new Point(434, 321);
            lbDiem.Name = "lbDiem";
            lbDiem.Size = new Size(125, 54);
            lbDiem.TabIndex = 4;
            lbDiem.Text = "Diem:";
            // 
            // lbKqua
            // 
            lbKqua.AutoSize = true;
            lbKqua.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbKqua.Location = new Point(579, 307);
            lbKqua.Name = "lbKqua";
            lbKqua.Size = new Size(62, 74);
            lbKqua.TabIndex = 4;
            lbKqua.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbKqua);
            Controls.Add(lbDiem);
            Controls.Add(lbSo3);
            Controls.Add(lbSo2);
            Controls.Add(lbSo1);
            Controls.Add(btQuay);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Random number";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rd3;
        private GroupBox groupBox1;
        private RadioButton rd11;
        private Button btQuay;
        private Label lbSo1;
        private Label lbSo2;
        private Label lbSo3;
        private Label lbDiem;
        private Label lbKqua;
    }
}
