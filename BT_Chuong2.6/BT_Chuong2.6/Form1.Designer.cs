namespace BT_Chuong2._6
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtOriginArray = new TextBox();
            txtIncreaseArray = new TextBox();
            txtDecreaseArray = new TextBox();
            txtReverseArray = new TextBox();
            txtSpecialSort = new TextBox();
            txtCount = new TextBox();
            btnRandom = new Button();
            btnSort = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 47);
            label1.Name = "label1";
            label1.Size = new Size(103, 25);
            label1.TabIndex = 0;
            label1.Text = "Số Phần tử:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 109);
            label2.Name = "label2";
            label2.Size = new Size(132, 25);
            label2.TabIndex = 0;
            label2.Text = "Mảng ban đầu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 180);
            label3.Name = "label3";
            label3.Size = new Size(103, 25);
            label3.TabIndex = 0;
            label3.Text = "Mảng tăng:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 255);
            label4.Name = "label4";
            label4.Size = new Size(107, 25);
            label4.TabIndex = 0;
            label4.Text = "Mảng giảm:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 324);
            label5.Name = "label5";
            label5.Size = new Size(98, 25);
            label5.TabIndex = 0;
            label5.Text = "Mảng đảo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 383);
            label6.Name = "label6";
            label6.Size = new Size(212, 25);
            label6.TabIndex = 0;
            label6.Text = "Mảng chẵn tăng, lẻ giảm:";
            // 
            // txtOriginArray
            // 
            txtOriginArray.Location = new Point(250, 103);
            txtOriginArray.Name = "txtOriginArray";
            txtOriginArray.ReadOnly = true;
            txtOriginArray.Size = new Size(467, 31);
            txtOriginArray.TabIndex = 1;
            // 
            // txtIncreaseArray
            // 
            txtIncreaseArray.Location = new Point(250, 180);
            txtIncreaseArray.Name = "txtIncreaseArray";
            txtIncreaseArray.ReadOnly = true;
            txtIncreaseArray.Size = new Size(467, 31);
            txtIncreaseArray.TabIndex = 1;
            // 
            // txtDecreaseArray
            // 
            txtDecreaseArray.Location = new Point(250, 255);
            txtDecreaseArray.Name = "txtDecreaseArray";
            txtDecreaseArray.ReadOnly = true;
            txtDecreaseArray.Size = new Size(467, 31);
            txtDecreaseArray.TabIndex = 1;
            // 
            // txtReverseArray
            // 
            txtReverseArray.Location = new Point(250, 318);
            txtReverseArray.Name = "txtReverseArray";
            txtReverseArray.ReadOnly = true;
            txtReverseArray.Size = new Size(467, 31);
            txtReverseArray.TabIndex = 1;
            // 
            // txtSpecialSort
            // 
            txtSpecialSort.Location = new Point(250, 377);
            txtSpecialSort.Name = "txtSpecialSort";
            txtSpecialSort.ReadOnly = true;
            txtSpecialSort.Size = new Size(467, 31);
            txtSpecialSort.TabIndex = 1;
            // 
            // txtCount
            // 
            txtCount.Location = new Point(141, 42);
            txtCount.Name = "txtCount";
            txtCount.Size = new Size(91, 31);
            txtCount.TabIndex = 0;
            // 
            // btnRandom
            // 
            btnRandom.Location = new Point(250, 47);
            btnRandom.Name = "btnRandom";
            btnRandom.Size = new Size(204, 34);
            btnRandom.TabIndex = 1;
            btnRandom.Text = "Tạo mảng ngẫu nhiên";
            btnRandom.UseVisualStyleBackColor = true;
            btnRandom.Click += btnRandom_Click;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(498, 47);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(219, 34);
            btnSort.TabIndex = 2;
            btnSort.Text = "Sắp xếp";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSort);
            Controls.Add(btnRandom);
            Controls.Add(txtSpecialSort);
            Controls.Add(txtReverseArray);
            Controls.Add(txtDecreaseArray);
            Controls.Add(txtIncreaseArray);
            Controls.Add(txtCount);
            Controls.Add(txtOriginArray);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Sắp Xếp Mảng";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtOriginArray;
        private TextBox txtIncreaseArray;
        private TextBox txtDecreaseArray;
        private TextBox txtReverseArray;
        private TextBox txtSpecialSort;
        private TextBox txtCount;
        private Button btnRandom;
        private Button btnSort;
    }
}
