using System.CodeDom.Compiler;

namespace BT_Chuong4._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int input=int.MinValue;
        private int result;
        private int count = 0;
        private int win = 0;
        private int lose = 0;
        private void init()
        {
            pbInput.Image = imageList1.Images[0];
            pbResult.Image = imageList1.Images[0];
            lblCount.Text = "Lần đoán: 0";
            lblWin.Text = "Lần thắng: 0";
            lblLose.Text = "Lần thua: 0";
            lbSum.Items.Clear();
        }
        private void BtnChoose(string value)
        {
            int v = int.Parse(value);
            input = v;
            pbInput.Image = imageList1.Images[v - 1];
        }
        private void random_dice(ref int count)
        {
            count++;
            Random rd = new Random();
            int value = rd.Next(0, imageList1.Images.Count);
            pbResult.Image = imageList1.Images[value];
            result = value + 1;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            init();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            init();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            BtnChoose(btn1.Text);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            BtnChoose(btn2.Text);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            BtnChoose(btn3.Text);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            BtnChoose(btn4.Text);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            BtnChoose(btn5.Text);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            BtnChoose(btn6.Text);
        }

        private void statistic()
        {

        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                if (input == int.MinValue)
                {
                    throw new Exception("Vui Lòng chọn 1 giá trị để đoán");
                }
                random_dice(ref count);
                if (input == result)
                {
                    lbSum.Items.Add(count.ToString() + ". Thắng ( đoán " + input.ToString() + " ra " + result.ToString() + ")");
                    win++;
                }
                else
                {
                    lbSum.Items.Add(count.ToString() + ". Thua ( đoán " + input.ToString() + " ra " + result.ToString() + ")");
                    lose++;
                }
                lblCount.Text = "Lần đoán: " + count.ToString();
                lblWin.Text = "Lần thắng: " + win.ToString() + "(" + ((double)win / count).ToString() + "%)";
                lblLose.Text = "Lần thua: " + lose.ToString() + "(" + ((double)lose / count).ToString() + "%)";
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
