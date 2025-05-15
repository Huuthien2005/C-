namespace Bt_chuong4._1._2
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
            picBall = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            paddle = new Panel();
            ((System.ComponentModel.ISupportInitialize)picBall).BeginInit();
            SuspendLayout();
            // 
            // picBall
            // 
            picBall.Image = (Image)resources.GetObject("picBall.Image");
            picBall.InitialImage = (Image)resources.GetObject("picBall.InitialImage");
            picBall.Location = new Point(12, 12);
            picBall.Name = "picBall";
            picBall.Size = new Size(81, 75);
            picBall.SizeMode = PictureBoxSizeMode.Zoom;
            picBall.TabIndex = 0;
            picBall.TabStop = false;
            picBall.WaitOnLoad = true;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // paddle
            // 
            paddle.BackColor = SystemColors.ActiveCaptionText;
            paddle.BorderStyle = BorderStyle.FixedSingle;
            paddle.Location = new Point(237, 399);
            paddle.Name = "paddle";
            paddle.Size = new Size(300, 39);
            paddle.TabIndex = 1;
            paddle.MouseMove += paddle_MouseMove;
            paddle.Move += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 450);
            Controls.Add(paddle);
            Controls.Add(picBall);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)picBall).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picBall;
        private System.Windows.Forms.Timer timer1;
        private Panel paddle;
    }
}
