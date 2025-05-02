using System.Reflection.Metadata;
using System.Security.Cryptography.Xml;

namespace Bt_chuong4._1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int dx = 1;
        private int dy = 1;
        private bool isMoving = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Tick += new EventHandler(update);
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            this.MouseMove += new MouseEventHandler(paddle_MouseMove);
        }
        private void update(object sender, EventArgs e)
        {
            if (!isMoving)
                return;
            picBall.Left += dx;
            picBall.Top += dy;
            if (picBall.Left < 0 || picBall.Right > this.ClientSize.Width)
                dx = -dx;
            if (picBall.Top <= 0)
                dy = -dy;
            if (picBall.Bounds.Bottom >= paddle.Bounds.Top && picBall.Bounds.Bottom <= paddle.Bounds.Bottom && picBall.Bounds.IntersectsWith(paddle.Bounds))
                dy = -dy;
            if (picBall.Bottom >= this.ClientSize.Height)
                timer1.Stop();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
            {
                isMoving = !isMoving;
                if (isMoving)
                    timer1.Start();
                else
                    timer1.Stop();
            }
            if (e.KeyCode == Keys.Left && paddle.Left > 0)
            {
                paddle.Left -= 20;
            }
            else if (e.KeyCode == Keys.Right && paddle.Right < this.ClientSize.Width)
            {
                paddle.Left += 20;
            }
        }

        private void paddle_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int newX = e.X - paddle.Width / 2;
                newX = Math.Max(0, Math.Min(this.ClientSize.Width - paddle.Width, newX));
                paddle.Left = newX;


            }
            else if (e.Button == MouseButtons.Right)
            {
                return;
            }
        }
    }
}
