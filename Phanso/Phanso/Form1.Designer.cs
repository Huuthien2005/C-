namespace Phanso
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
            Tso1 = new Label();
            Mso1 = new Label();
            Tso2 = new Label();
            Mso2 = new Label();
            txtTso1 = new TextBox();
            txtMso1 = new TextBox();
            txtMso2 = new TextBox();
            txtTso2 = new TextBox();
            bt1 = new Button();
            bt2 = new Button();
            bt3 = new Button();
            bt4 = new Button();
            lblKQ = new Label();
            txtTso = new TextBox();
            txtMso = new TextBox();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(214, 51);
            label.Name = "label";
            label.Size = new Size(277, 25);
            label.TabIndex = 0;
            label.Text = "Program that calculates 2 fraction";
            // 
            // Tso1
            // 
            Tso1.AutoSize = true;
            Tso1.Location = new Point(39, 108);
            Tso1.Name = "Tso1";
            Tso1.Size = new Size(101, 25);
            Tso1.TabIndex = 1;
            Tso1.Text = "nhap tu so:";
            // 
            // Mso1
            // 
            Mso1.AutoSize = true;
            Mso1.Location = new Point(39, 180);
            Mso1.Name = "Mso1";
            Mso1.Size = new Size(120, 25);
            Mso1.TabIndex = 1;
            Mso1.Text = "nhap mau so:";
            // 
            // Tso2
            // 
            Tso2.AutoSize = true;
            Tso2.Location = new Point(424, 108);
            Tso2.Name = "Tso2";
            Tso2.Size = new Size(101, 25);
            Tso2.TabIndex = 1;
            Tso2.Text = "nhap tu so:";
            // 
            // Mso2
            // 
            Mso2.AutoSize = true;
            Mso2.Location = new Point(424, 180);
            Mso2.Name = "Mso2";
            Mso2.Size = new Size(120, 25);
            Mso2.TabIndex = 1;
            Mso2.Text = "nhap mau so:";
            // 
            // txtTso1
            // 
            txtTso1.Location = new Point(171, 108);
            txtTso1.Name = "txtTso1";
            txtTso1.Size = new Size(150, 31);
            txtTso1.TabIndex = 2;
            // 
            // txtMso1
            // 
            txtMso1.Location = new Point(171, 174);
            txtMso1.Name = "txtMso1";
            txtMso1.Size = new Size(150, 31);
            txtMso1.TabIndex = 2;
            // 
            // txtMso2
            // 
            txtMso2.Location = new Point(550, 174);
            txtMso2.Name = "txtMso2";
            txtMso2.Size = new Size(150, 31);
            txtMso2.TabIndex = 2;
            // 
            // txtTso2
            // 
            txtTso2.Location = new Point(550, 105);
            txtTso2.Name = "txtTso2";
            txtTso2.Size = new Size(150, 31);
            txtTso2.TabIndex = 2;
            // 
            // bt1
            // 
            bt1.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt1.Location = new Point(77, 241);
            bt1.Name = "bt1";
            bt1.Size = new Size(63, 60);
            bt1.TabIndex = 3;
            bt1.Text = "+";
            bt1.UseVisualStyleBackColor = true;
            bt1.Click += bt1_Click;
            // 
            // bt2
            // 
            bt2.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt2.Location = new Point(282, 241);
            bt2.Name = "bt2";
            bt2.Size = new Size(63, 60);
            bt2.TabIndex = 3;
            bt2.Text = "-";
            bt2.UseVisualStyleBackColor = true;
            bt2.Click += bt2_Click;
            // 
            // bt3
            // 
            bt3.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt3.Location = new Point(481, 241);
            bt3.Name = "bt3";
            bt3.Size = new Size(63, 60);
            bt3.TabIndex = 3;
            bt3.Text = "x";
            bt3.UseVisualStyleBackColor = true;
            bt3.Click += bt3_Click;
            // 
            // bt4
            // 
            bt4.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt4.Location = new Point(637, 241);
            bt4.Name = "bt4";
            bt4.Size = new Size(63, 60);
            bt4.TabIndex = 3;
            bt4.Text = "/";
            bt4.UseVisualStyleBackColor = true;
            bt4.Click += bt4_Click;
            // 
            // lblKQ
            // 
            lblKQ.AutoSize = true;
            lblKQ.Location = new Point(64, 354);
            lblKQ.Name = "lblKQ";
            lblKQ.Size = new Size(76, 25);
            lblKQ.TabIndex = 4;
            lblKQ.Text = "Ket qua:";
            // 
            // txtTso
            // 
            txtTso.Location = new Point(171, 348);
            txtTso.Name = "txtTso";
            txtTso.Size = new Size(150, 31);
            txtTso.TabIndex = 5;
            // 
            // txtMso
            // 
            txtMso.Location = new Point(171, 407);
            txtMso.Name = "txtMso";
            txtMso.Size = new Size(150, 31);
            txtMso.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtMso);
            Controls.Add(txtTso);
            Controls.Add(lblKQ);
            Controls.Add(bt4);
            Controls.Add(bt3);
            Controls.Add(bt2);
            Controls.Add(bt1);
            Controls.Add(txtTso2);
            Controls.Add(txtMso2);
            Controls.Add(txtMso1);
            Controls.Add(txtTso1);
            Controls.Add(Tso2);
            Controls.Add(Mso2);
            Controls.Add(Mso1);
            Controls.Add(Tso1);
            Controls.Add(label);
            Name = "Form1";
            Text = "calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private Label Tso1;
        private Label Mso1;
        private Label Tso2;
        private Label Mso2;
        private TextBox txtTso1;
        private TextBox txtMso1;
        private TextBox txtMso2;
        private TextBox txtTso2;
        private Button bt1;
        private Button bt2;
        private Button bt3;
        private Button bt4;
        private Label lblKQ;
        private TextBox txtTso;
        private TextBox txtMso;
    }
}
