namespace BTVN_chuong2._5
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
            txtInput = new TextBox();
            label1 = new Label();
            btnCal = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtSumEven = new TextBox();
            txtSumOdd = new TextBox();
            txtSNT = new TextBox();
            txtAverage = new TextBox();
            txtShow = new TextBox();
            label6 = new Label();
            btnTry = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(236, 38);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(150, 31);
            txtInput.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 38);
            label1.Name = "label1";
            label1.Size = new Size(150, 25);
            label1.TabIndex = 1;
            label1.Text = "Nhập số phần tử:";
            // 
            // btnCal
            // 
            btnCal.Location = new Point(413, 38);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(112, 34);
            btnCal.TabIndex = 2;
            btnCal.Text = "Thống kê";
            btnCal.UseVisualStyleBackColor = true;
            btnCal.Click += btnCal_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 186);
            label2.Name = "label2";
            label2.Size = new Size(190, 25);
            label2.TabIndex = 1;
            label2.Text = "Tổng số phần tử chẵn:\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 245);
            label3.Name = "label3";
            label3.Size = new Size(165, 25);
            label3.TabIndex = 1;
            label3.Text = "Tổng số Phần tử lẻ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 306);
            label4.Name = "label4";
            label4.Size = new Size(342, 25);
            label4.TabIndex = 1;
            label4.Text = "Trung bình cộng các phần tử trong mảng:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 365);
            label5.Name = "label5";
            label5.Size = new Size(254, 25);
            label5.TabIndex = 1;
            label5.Text = "Các số nguyên tố trong mảng:";
            // 
            // txtSumEven
            // 
            txtSumEven.Location = new Point(441, 179);
            txtSumEven.Name = "txtSumEven";
            txtSumEven.ReadOnly = true;
            txtSumEven.Size = new Size(300, 31);
            txtSumEven.TabIndex = 3;
            // 
            // txtSumOdd
            // 
            txtSumOdd.Location = new Point(441, 245);
            txtSumOdd.Name = "txtSumOdd";
            txtSumOdd.ReadOnly = true;
            txtSumOdd.Size = new Size(300, 31);
            txtSumOdd.TabIndex = 3;
            // 
            // txtSNT
            // 
            txtSNT.Location = new Point(441, 362);
            txtSNT.Name = "txtSNT";
            txtSNT.ReadOnly = true;
            txtSNT.Size = new Size(300, 31);
            txtSNT.TabIndex = 3;
            // 
            // txtAverage
            // 
            txtAverage.Location = new Point(441, 306);
            txtAverage.Name = "txtAverage";
            txtAverage.ReadOnly = true;
            txtAverage.Size = new Size(300, 31);
            txtAverage.TabIndex = 3;
            // 
            // txtShow
            // 
            txtShow.Location = new Point(441, 108);
            txtShow.Name = "txtShow";
            txtShow.ReadOnly = true;
            txtShow.Size = new Size(300, 31);
            txtShow.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(57, 108);
            label6.Name = "label6";
            label6.Size = new Size(131, 25);
            label6.TabIndex = 1;
            label6.Text = "Random Array:";
            // 
            // btnTry
            // 
            btnTry.Location = new Point(548, 38);
            btnTry.Name = "btnTry";
            btnTry.Size = new Size(112, 34);
            btnTry.TabIndex = 4;
            btnTry.Text = "Thử lại";
            btnTry.UseVisualStyleBackColor = true;
            btnTry.Click += btnTry_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(676, 38);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 5;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnTry);
            Controls.Add(txtAverage);
            Controls.Add(txtSNT);
            Controls.Add(txtSumOdd);
            Controls.Add(txtShow);
            Controls.Add(txtSumEven);
            Controls.Add(btnCal);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtInput);
            Name = "Form1";
            Text = "Chương trình thống kê";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Label label1;
        private Button btnCal;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtSumEven;
        private TextBox txtSumOdd;
        private TextBox txtSNT;
        private TextBox txtAverage;
        private TextBox txtShow;
        private Label label6;
        private Button btnTry;
        private Button btnExit;
    }
}
