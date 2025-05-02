namespace BT_Chuong4._2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbSum = new ListBox();
            gbGuess = new GroupBox();
            pbInput = new PictureBox();
            btn6 = new Button();
            btn5 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            gbRandom = new GroupBox();
            pbResult = new PictureBox();
            btnReset = new Button();
            btnEnter = new Button();
            gbStatistic = new GroupBox();
            lblLose = new Label();
            lblWin = new Label();
            lblCount = new Label();
            imageList1 = new ImageList(components);
            ttInfo = new ToolTip(components);
            gbGuess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbInput).BeginInit();
            gbRandom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbResult).BeginInit();
            gbStatistic.SuspendLayout();
            SuspendLayout();
            // 
            // lbSum
            // 
            lbSum.FormattingEnabled = true;
            lbSum.ItemHeight = 25;
            lbSum.Location = new Point(660, 34);
            lbSum.Name = "lbSum";
            lbSum.Size = new Size(360, 529);
            lbSum.TabIndex = 0;
            // 
            // gbGuess
            // 
            gbGuess.Controls.Add(pbInput);
            gbGuess.Controls.Add(btn6);
            gbGuess.Controls.Add(btn5);
            gbGuess.Controls.Add(btn3);
            gbGuess.Controls.Add(btn4);
            gbGuess.Controls.Add(btn2);
            gbGuess.Controls.Add(btn1);
            gbGuess.Location = new Point(61, 34);
            gbGuess.Name = "gbGuess";
            gbGuess.Size = new Size(496, 157);
            gbGuess.TabIndex = 1;
            gbGuess.TabStop = false;
            gbGuess.Text = "Đoán Số";
            ttInfo.SetToolTip(gbGuess, "Click 1 nút để đoán số");
            // 
            // pbInput
            // 
            pbInput.BackgroundImageLayout = ImageLayout.Zoom;
            pbInput.Location = new Point(201, 52);
            pbInput.Name = "pbInput";
            pbInput.Size = new Size(101, 75);
            pbInput.TabIndex = 1;
            pbInput.TabStop = false;
            // 
            // btn6
            // 
            btn6.BackColor = SystemColors.AppWorkspace;
            btn6.Cursor = Cursors.No;
            btn6.FlatStyle = FlatStyle.Popup;
            btn6.Location = new Point(420, 117);
            btn6.Name = "btn6";
            btn6.Size = new Size(61, 34);
            btn6.TabIndex = 0;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.BackColor = SystemColors.AppWorkspace;
            btn5.Cursor = Cursors.No;
            btn5.FlatStyle = FlatStyle.Popup;
            btn5.Location = new Point(420, 69);
            btn5.Name = "btn5";
            btn5.Size = new Size(61, 34);
            btn5.TabIndex = 0;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn3
            // 
            btn3.BackColor = SystemColors.AppWorkspace;
            btn3.Cursor = Cursors.No;
            btn3.FlatStyle = FlatStyle.Popup;
            btn3.Location = new Point(44, 117);
            btn3.Name = "btn3";
            btn3.Size = new Size(61, 34);
            btn3.TabIndex = 0;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.BackColor = SystemColors.AppWorkspace;
            btn4.Cursor = Cursors.No;
            btn4.FlatStyle = FlatStyle.Popup;
            btn4.Location = new Point(420, 29);
            btn4.Name = "btn4";
            btn4.Size = new Size(61, 34);
            btn4.TabIndex = 0;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn2
            // 
            btn2.BackColor = SystemColors.AppWorkspace;
            btn2.Cursor = Cursors.No;
            btn2.FlatStyle = FlatStyle.Popup;
            btn2.Location = new Point(44, 69);
            btn2.Name = "btn2";
            btn2.Size = new Size(61, 34);
            btn2.TabIndex = 0;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.AppWorkspace;
            btn1.Cursor = Cursors.No;
            btn1.FlatStyle = FlatStyle.Popup;
            btn1.Location = new Point(44, 29);
            btn1.Name = "btn1";
            btn1.Size = new Size(61, 34);
            btn1.TabIndex = 0;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // gbRandom
            // 
            gbRandom.Controls.Add(pbResult);
            gbRandom.Controls.Add(btnReset);
            gbRandom.Controls.Add(btnEnter);
            gbRandom.Location = new Point(61, 204);
            gbRandom.Name = "gbRandom";
            gbRandom.Size = new Size(496, 163);
            gbRandom.TabIndex = 2;
            gbRandom.TabStop = false;
            gbRandom.Text = "Quay số(sinh số ngẫu nhiên)";
            // 
            // pbResult
            // 
            pbResult.Location = new Point(191, 30);
            pbResult.Name = "pbResult";
            pbResult.Size = new Size(101, 75);
            pbResult.TabIndex = 1;
            pbResult.TabStop = false;
            // 
            // btnReset
            // 
            btnReset.BackColor = SystemColors.ActiveBorder;
            btnReset.FlatStyle = FlatStyle.Popup;
            btnReset.ForeColor = SystemColors.Highlight;
            btnReset.Location = new Point(277, 123);
            btnReset.Name = "btnReset";
            btnReset.RightToLeft = RightToLeft.No;
            btnReset.Size = new Size(204, 34);
            btnReset.TabIndex = 0;
            btnReset.Text = "Reset (ESC)";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnEnter
            // 
            btnEnter.BackColor = SystemColors.ActiveBorder;
            btnEnter.FlatStyle = FlatStyle.Popup;
            btnEnter.ForeColor = SystemColors.Highlight;
            btnEnter.Location = new Point(21, 123);
            btnEnter.Name = "btnEnter";
            btnEnter.RightToLeft = RightToLeft.No;
            btnEnter.Size = new Size(226, 34);
            btnEnter.TabIndex = 0;
            btnEnter.Text = "Quay Số (Enter)";
            btnEnter.UseVisualStyleBackColor = false;
            btnEnter.Click += btnEnter_Click;
            // 
            // gbStatistic
            // 
            gbStatistic.Controls.Add(lblLose);
            gbStatistic.Controls.Add(lblWin);
            gbStatistic.Controls.Add(lblCount);
            gbStatistic.Location = new Point(61, 389);
            gbStatistic.Name = "gbStatistic";
            gbStatistic.Size = new Size(496, 156);
            gbStatistic.TabIndex = 3;
            gbStatistic.TabStop = false;
            gbStatistic.Text = "Thống kê";
            // 
            // lblLose
            // 
            lblLose.AutoSize = true;
            lblLose.ForeColor = Color.Fuchsia;
            lblLose.Location = new Point(52, 115);
            lblLose.Name = "lblLose";
            lblLose.Size = new Size(98, 25);
            lblLose.TabIndex = 0;
            lblLose.Text = "Lần thua: 0";
            // 
            // lblWin
            // 
            lblWin.AutoSize = true;
            lblWin.ForeColor = Color.FromArgb(0, 192, 0);
            lblWin.Location = new Point(52, 74);
            lblWin.Name = "lblWin";
            lblWin.Size = new Size(112, 25);
            lblWin.TabIndex = 0;
            lblWin.Text = "Lần Thắng: 0";
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.ForeColor = SystemColors.HotTrack;
            lblCount.Location = new Point(52, 31);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(106, 25);
            lblCount.TabIndex = 0;
            lblCount.Text = "Lần Đoán: 0";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "dice_1.jpg");
            imageList1.Images.SetKeyName(1, "dice_2.jpg");
            imageList1.Images.SetKeyName(2, "dice_3.png");
            imageList1.Images.SetKeyName(3, "dice_4.jpg");
            imageList1.Images.SetKeyName(4, "dice_5.jpg");
            imageList1.Images.SetKeyName(5, "dice_6.png");
            // 
            // ttInfo
            // 
            ttInfo.ToolTipIcon = ToolTipIcon.Info;
            ttInfo.ToolTipTitle = "Đoán số";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 587);
            Controls.Add(gbStatistic);
            Controls.Add(gbRandom);
            Controls.Add(gbGuess);
            Controls.Add(lbSum);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gbGuess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbInput).EndInit();
            gbRandom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbResult).EndInit();
            gbStatistic.ResumeLayout(false);
            gbStatistic.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbSum;
        private GroupBox gbGuess;
        private GroupBox gbRandom;
        private GroupBox gbStatistic;
        private PictureBox pbInput;
        private Button btn6;
        private Button btn5;
        private Button btn3;
        private Button btn4;
        private Button btn2;
        private Button btn1;
        private Button btnEnter;
        private PictureBox pbResult;
        private Button btnReset;
        private ImageList imageList1;
        private Label lblLose;
        private Label lblWin;
        private Label lblCount;
        private ToolTip ttInfo;
    }
}
