namespace BTVN_Chuong4._2
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
            txtString = new TextBox();
            btnInsert = new Button();
            label2 = new Label();
            cbColor = new ComboBox();
            lbL = new ListBox();
            btnLR = new Button();
            btnRL = new Button();
            btnRemove = new Button();
            btnClear = new Button();
            btnExit = new Button();
            lbR = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(25, 52);
            label1.Name = "label1";
            label1.Size = new Size(120, 25);
            label1.TabIndex = 0;
            label1.Text = "Enter a string:";
            // 
            // txtString
            // 
            txtString.Location = new Point(175, 49);
            txtString.Name = "txtString";
            txtString.Size = new Size(150, 31);
            txtString.TabIndex = 1;
            // 
            // btnInsert
            // 
            btnInsert.ForeColor = SystemColors.Highlight;
            btnInsert.Location = new Point(100, 114);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(112, 34);
            btnInsert.TabIndex = 2;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(418, 55);
            label2.Name = "label2";
            label2.Size = new Size(107, 25);
            label2.TabIndex = 0;
            label2.Text = "Select color:";
            // 
            // cbColor
            // 
            cbColor.FormattingEnabled = true;
            cbColor.Location = new Point(549, 55);
            cbColor.Name = "cbColor";
            cbColor.Size = new Size(182, 33);
            cbColor.TabIndex = 3;
            // 
            // lbL
            // 
            lbL.FormattingEnabled = true;
            lbL.ItemHeight = 25;
            lbL.Location = new Point(43, 170);
            lbL.Name = "lbL";
            lbL.Size = new Size(195, 304);
            lbL.TabIndex = 4;
            // 
            // btnLR
            // 
            btnLR.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLR.ForeColor = SystemColors.Highlight;
            btnLR.Location = new Point(325, 170);
            btnLR.Name = "btnLR";
            btnLR.Size = new Size(145, 43);
            btnLR.TabIndex = 5;
            btnLR.Text = "==>";
            btnLR.UseVisualStyleBackColor = true;
            btnLR.Click += btnLR_Click;
            // 
            // btnRL
            // 
            btnRL.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRL.ForeColor = SystemColors.Highlight;
            btnRL.Location = new Point(325, 230);
            btnRL.Name = "btnRL";
            btnRL.Size = new Size(145, 43);
            btnRL.TabIndex = 5;
            btnRL.Text = "<==";
            btnRL.UseVisualStyleBackColor = true;
            btnRL.Click += btnRL_Click;
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.ForeColor = SystemColors.Highlight;
            btnRemove.Location = new Point(325, 295);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(145, 43);
            btnRemove.TabIndex = 5;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = SystemColors.Highlight;
            btnClear.Location = new Point(325, 361);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(145, 43);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear All";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.Highlight;
            btnExit.Location = new Point(325, 431);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(145, 43);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lbR
            // 
            lbR.FormattingEnabled = true;
            lbR.ItemHeight = 25;
            lbR.Location = new Point(536, 170);
            lbR.Name = "lbR";
            lbR.Size = new Size(195, 304);
            lbR.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 519);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnRemove);
            Controls.Add(btnRL);
            Controls.Add(btnLR);
            Controls.Add(lbR);
            Controls.Add(lbL);
            Controls.Add(cbColor);
            Controls.Add(btnInsert);
            Controls.Add(txtString);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtString;
        private Button btnInsert;
        private Label label2;
        private ComboBox cbColor;
        private ListBox lbL;
        private Button btnLR;
        private Button btnRL;
        private Button btnRemove;
        private Button btnClear;
        private Button btnExit;
        private ListBox lbR;
    }
}
