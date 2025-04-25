namespace BTVN_Chuong2._2
{
    partial class ptb2
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
            label5 = new Label();
            btnSolve = new Button();
            btnExit = new Button();
            txtKQ = new TextBox();
            txtA = new TextBox();
            txtB = new TextBox();
            txtC = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(28, 23);
            label1.Name = "label1";
            label1.Size = new Size(741, 54);
            label1.TabIndex = 0;
            label1.Text = "Chương Trình Giải Phương Trình Bậc 2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(43, 132);
            label2.Name = "label2";
            label2.Size = new Size(58, 45);
            label2.TabIndex = 1;
            label2.Text = "a=";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(275, 133);
            label3.Name = "label3";
            label3.Size = new Size(61, 45);
            label3.TabIndex = 1;
            label3.Text = "b=";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(559, 133);
            label4.Name = "label4";
            label4.Size = new Size(57, 45);
            label4.TabIndex = 1;
            label4.Text = "c=";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaption;
            label5.Location = new Point(83, 252);
            label5.Name = "label5";
            label5.Size = new Size(144, 45);
            label5.TabIndex = 1;
            label5.Text = "Kết quả:";
            // 
            // btnSolve
            // 
            btnSolve.BackColor = SystemColors.ActiveCaption;
            btnSolve.FlatStyle = FlatStyle.Popup;
            btnSolve.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSolve.ForeColor = Color.Black;
            btnSolve.Location = new Point(106, 373);
            btnSolve.Name = "btnSolve";
            btnSolve.Size = new Size(144, 50);
            btnSolve.TabIndex = 3;
            btnSolve.Text = "Giải";
            btnSolve.UseVisualStyleBackColor = false;
            btnSolve.Click += btnSolve_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ActiveCaption;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Black;
            btnExit.Location = new Point(472, 373);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(144, 50);
            btnExit.TabIndex = 4;
            btnExit.Text = "Đóng";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // txtKQ
            // 
            txtKQ.BackColor = SystemColors.ActiveCaption;
            txtKQ.BorderStyle = BorderStyle.None;
            txtKQ.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtKQ.Location = new Point(249, 254);
            txtKQ.Multiline = true;
            txtKQ.Name = "txtKQ";
            txtKQ.ReadOnly = true;
            txtKQ.Size = new Size(421, 89);
            txtKQ.TabIndex = 3;
            // 
            // txtA
            // 
            txtA.Location = new Point(119, 146);
            txtA.Name = "txtA";
            txtA.Size = new Size(88, 31);
            txtA.TabIndex = 0;
            // 
            // txtB
            // 
            txtB.Location = new Point(364, 146);
            txtB.Name = "txtB";
            txtB.Size = new Size(88, 31);
            txtB.TabIndex = 1;
            // 
            // txtC
            // 
            txtC.Location = new Point(645, 146);
            txtC.Name = "txtC";
            txtC.Size = new Size(88, 31);
            txtC.TabIndex = 2;
            // 
            // ptb2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtC);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(txtKQ);
            Controls.Add(btnExit);
            Controls.Add(btnSolve);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ptb2";
            Text = "Phương Trình Bậc 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnSolve;
        private Button btnExit;
        private TextBox txtKQ;
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtC;
    }
}
