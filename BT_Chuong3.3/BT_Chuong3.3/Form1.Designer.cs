namespace BT_Chuong3._3
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
            lblX = new Label();
            lblY = new Label();
            lblR = new Label();
            txtOx = new TextBox();
            txtOy = new TextBox();
            txtR = new TextBox();
            lblDt = new Label();
            lblCv = new Label();
            lblX1 = new Label();
            txtX = new TextBox();
            lblX2 = new Label();
            txtY = new TextBox();
            lblCheck = new Label();
            btnTinh = new Button();
            btnCheck = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(117, 9);
            label1.Name = "label1";
            label1.Size = new Size(535, 45);
            label1.TabIndex = 0;
            label1.Text = "Chương trình kiểm tra đường tròn";
            // 
            // lblX
            // 
            lblX.AutoSize = true;
            lblX.Location = new Point(26, 78);
            lblX.Name = "lblX";
            lblX.Size = new Size(187, 25);
            lblX.TabIndex = 1;
            lblX.Text = "nhập tọa độ tâm O(x):";
            // 
            // lblY
            // 
            lblY.AutoSize = true;
            lblY.Location = new Point(26, 145);
            lblY.Name = "lblY";
            lblY.Size = new Size(188, 25);
            lblY.TabIndex = 1;
            lblY.Text = "nhập tọa độ tâm O(y):";
            // 
            // lblR
            // 
            lblR.AutoSize = true;
            lblR.Location = new Point(26, 207);
            lblR.Name = "lblR";
            lblR.Size = new Size(206, 25);
            lblR.TabIndex = 1;
            lblR.Text = "nhập bán kính hình tròn:";
            // 
            // txtOx
            // 
            txtOx.Location = new Point(264, 79);
            txtOx.Name = "txtOx";
            txtOx.Size = new Size(89, 31);
            txtOx.TabIndex = 6;
            // 
            // txtOy
            // 
            txtOy.Location = new Point(264, 145);
            txtOy.Name = "txtOy";
            txtOy.Size = new Size(89, 31);
            txtOy.TabIndex = 7;
            // 
            // txtR
            // 
            txtR.Location = new Point(264, 204);
            txtR.Name = "txtR";
            txtR.Size = new Size(89, 31);
            txtR.TabIndex = 8;
            // 
            // lblDt
            // 
            lblDt.AutoSize = true;
            lblDt.Location = new Point(26, 385);
            lblDt.Name = "lblDt";
            lblDt.Size = new Size(177, 25);
            lblDt.TabIndex = 3;
            lblDt.Text = "Diện tích hình tròn: 0";
            // 
            // lblCv
            // 
            lblCv.AutoSize = true;
            lblCv.Location = new Point(26, 322);
            lblCv.Name = "lblCv";
            lblCv.Size = new Size(157, 25);
            lblCv.TabIndex = 3;
            lblCv.Text = "Chu vi hình tròn: 0";
            // 
            // lblX1
            // 
            lblX1.AutoSize = true;
            lblX1.Location = new Point(412, 82);
            lblX1.Name = "lblX1";
            lblX1.Size = new Size(172, 25);
            lblX1.TabIndex = 1;
            lblX1.Text = "nhập tọa độ điểm x:";
            // 
            // txtX
            // 
            txtX.Location = new Point(650, 83);
            txtX.Name = "txtX";
            txtX.Size = new Size(89, 31);
            txtX.TabIndex = 10;
            // 
            // lblX2
            // 
            lblX2.AutoSize = true;
            lblX2.Location = new Point(412, 153);
            lblX2.Name = "lblX2";
            lblX2.Size = new Size(173, 25);
            lblX2.TabIndex = 1;
            lblX2.Text = "nhập tọa độ điểm y:";
            // 
            // txtY
            // 
            txtY.Location = new Point(650, 154);
            txtY.Name = "txtY";
            txtY.Size = new Size(89, 31);
            txtY.TabIndex = 11;
            // 
            // lblCheck
            // 
            lblCheck.AutoSize = true;
            lblCheck.Location = new Point(446, 322);
            lblCheck.Name = "lblCheck";
            lblCheck.Size = new Size(249, 25);
            lblCheck.TabIndex = 3;
            lblCheck.Text = "Điểm trên có nằm trên O: true";
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(241, 270);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(112, 34);
            btnTinh.TabIndex = 9;
            btnTinh.Text = "Tính";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(446, 270);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(112, 34);
            btnCheck.TabIndex = 12;
            btnCheck.Text = "Kiểm tra";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCheck);
            Controls.Add(btnTinh);
            Controls.Add(lblCheck);
            Controls.Add(lblCv);
            Controls.Add(lblDt);
            Controls.Add(txtR);
            Controls.Add(txtOy);
            Controls.Add(txtY);
            Controls.Add(txtX);
            Controls.Add(txtOx);
            Controls.Add(lblR);
            Controls.Add(lblY);
            Controls.Add(lblX2);
            Controls.Add(lblX1);
            Controls.Add(lblX);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Chương trình kiểm tra đường tròn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblX;
        private Label lblY;
        private Label lblR;
        private TextBox txtOx;
        private TextBox txtOy;
        private TextBox txtR;
        private Label lblDt;
        private Label lblCv;
        private Label lblX1;
        private TextBox txtX;
        private Label lblX2;
        private TextBox txtY;
        private Label lblCheck;
        private Button btnTinh;
        private Button btnCheck;
    }
}
