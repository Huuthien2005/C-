namespace BTVN_Chuong2._1
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
            groupBox1 = new GroupBox();
            btnC1 = new Button();
            txtKqKT = new TextBox();
            txtMa = new TextBox();
            label4 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            btnC2 = new Button();
            txtKqMa = new TextBox();
            txtKT = new TextBox();
            label5 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.AppWorkspace;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(158, 21);
            label1.Name = "label1";
            label1.Size = new Size(449, 72);
            label1.TabIndex = 0;
            label1.Text = "Chuyển Mã ASCII";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnC1);
            groupBox1.Controls.Add(txtKqKT);
            groupBox1.Controls.Add(txtMa);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 129);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(293, 213);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chuyển mã ASCII qua ký tự:";
            // 
            // btnC1
            // 
            btnC1.BackColor = SystemColors.ButtonShadow;
            btnC1.FlatStyle = FlatStyle.Popup;
            btnC1.Location = new Point(142, 91);
            btnC1.Name = "btnC1";
            btnC1.Size = new Size(112, 34);
            btnC1.TabIndex = 1;
            btnC1.Text = "Chuyển";
            btnC1.UseVisualStyleBackColor = false;
            btnC1.Click += btnC1_Click;
            // 
            // txtKqKT
            // 
            txtKqKT.Location = new Point(142, 157);
            txtKqKT.Name = "txtKqKT";
            txtKqKT.ReadOnly = true;
            txtKqKT.Size = new Size(110, 31);
            txtKqKT.TabIndex = 2;
            // 
            // txtMa
            // 
            txtMa.Location = new Point(144, 39);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(110, 31);
            txtMa.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 160);
            label4.Name = "label4";
            label4.Size = new Size(76, 25);
            label4.TabIndex = 0;
            label4.Text = "Kết quả:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 39);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 0;
            label2.Text = "Mã ASCII:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnC2);
            groupBox2.Controls.Add(txtKqMa);
            groupBox2.Controls.Add(txtKT);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(427, 129);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(305, 213);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chuyển ký tự qua mã ASCII:";
            // 
            // btnC2
            // 
            btnC2.BackColor = SystemColors.ButtonShadow;
            btnC2.FlatStyle = FlatStyle.Popup;
            btnC2.Location = new Point(153, 91);
            btnC2.Name = "btnC2";
            btnC2.Size = new Size(112, 34);
            btnC2.TabIndex = 1;
            btnC2.Text = "Chuyển";
            btnC2.UseVisualStyleBackColor = false;
            btnC2.Click += btnC2_Click;
            // 
            // txtKqMa
            // 
            txtKqMa.Location = new Point(155, 160);
            txtKqMa.Name = "txtKqMa";
            txtKqMa.ReadOnly = true;
            txtKqMa.Size = new Size(110, 31);
            txtKqMa.TabIndex = 2;
            // 
            // txtKT
            // 
            txtKT.Location = new Point(155, 42);
            txtKT.Name = "txtKT";
            txtKT.Size = new Size(110, 31);
            txtKT.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 163);
            label5.Name = "label5";
            label5.Size = new Size(76, 25);
            label5.TabIndex = 0;
            label5.Text = "Kết quả:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 45);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 0;
            label3.Text = "Mã ASCII:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Chuyển Mã ASCII";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button btnC1;
        private TextBox txtMa;
        private Label label2;
        private GroupBox groupBox2;
        private Button btnC2;
        private Label label3;
        private TextBox txtKqKT;
        private Label label4;
        private TextBox txtKqMa;
        private TextBox txtKT;
        private Label label5;
    }
}
