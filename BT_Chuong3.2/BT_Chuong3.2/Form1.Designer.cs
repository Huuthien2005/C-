namespace BT_Chuong3._2
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
            txtA = new TextBox();
            txtB = new TextBox();
            txtC = new TextBox();
            lblA = new Label();
            lblB = new Label();
            lblC = new Label();
            label1 = new Label();
            lblDtich = new Label();
            lblCvi = new Label();
            lblType = new Label();
            lblCheck = new Label();
            btnTinh = new Button();
            SuspendLayout();
            // 
            // txtA
            // 
            txtA.Location = new Point(86, 94);
            txtA.Name = "txtA";
            txtA.Size = new Size(150, 31);
            txtA.TabIndex = 5;
            // 
            // txtB
            // 
            txtB.Location = new Point(344, 94);
            txtB.Name = "txtB";
            txtB.Size = new Size(150, 31);
            txtB.TabIndex = 6;
            // 
            // txtC
            // 
            txtC.Location = new Point(609, 94);
            txtC.Name = "txtC";
            txtC.Size = new Size(150, 31);
            txtC.TabIndex = 7;
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(17, 95);
            lblA.Name = "lblA";
            lblA.Size = new Size(25, 25);
            lblA.TabIndex = 1;
            lblA.Text = "a:";
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(280, 100);
            lblB.Name = "lblB";
            lblB.Size = new Size(27, 25);
            lblB.TabIndex = 1;
            lblB.Text = "b:";
            // 
            // lblC
            // 
            lblC.AutoSize = true;
            lblC.Location = new Point(539, 100);
            lblC.Name = "lblC";
            lblC.Size = new Size(24, 25);
            lblC.TabIndex = 1;
            lblC.Text = "c:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(121, 22);
            label1.Name = "label1";
            label1.Size = new Size(581, 38);
            label1.TabIndex = 2;
            label1.Text = "Chương trình tính diện tích và chu vi tam giác";
            // 
            // lblDtich
            // 
            lblDtich.AutoSize = true;
            lblDtich.Location = new Point(17, 303);
            lblDtich.Name = "lblDtich";
            lblDtich.Size = new Size(191, 25);
            lblDtich.TabIndex = 3;
            lblDtich.Text = "Diện tích tam giác là: 0";
            // 
            // lblCvi
            // 
            lblCvi.AutoSize = true;
            lblCvi.Location = new Point(424, 303);
            lblCvi.Name = "lblCvi";
            lblCvi.Size = new Size(171, 25);
            lblCvi.TabIndex = 3;
            lblCvi.Text = "Chu vi tam giác là: 0";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(424, 219);
            lblType.Name = "lblType";
            lblType.Size = new Size(90, 25);
            lblType.TabIndex = 3;
            lblType.Text = "Tam giác: ";
            // 
            // lblCheck
            // 
            lblCheck.AutoSize = true;
            lblCheck.Location = new Point(17, 219);
            lblCheck.Name = "lblCheck";
            lblCheck.Size = new Size(285, 25);
            lblCheck.TabIndex = 3;
            lblCheck.Text = "3 cạnh này là 3 cạnh tam giác: true";
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(300, 166);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(112, 34);
            btnTinh.TabIndex = 8;
            btnTinh.Text = "Tính";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTinh);
            Controls.Add(lblCvi);
            Controls.Add(lblCheck);
            Controls.Add(lblType);
            Controls.Add(lblDtich);
            Controls.Add(label1);
            Controls.Add(lblC);
            Controls.Add(lblB);
            Controls.Add(lblA);
            Controls.Add(txtC);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtC;
        private Label lblA;
        private Label lblB;
        private Label lblC;
        private Label label1;
        private Label lblDtich;
        private Label lblCvi;
        private Label lblType;
        private Label lblCheck;
        private Button btnTinh;
    }
}
