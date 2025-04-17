namespace BT_Chuong2._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rand = new Random();
        int diem = 0;

        private void btQuay_Click(object sender, EventArgs e)
        {
            int so1 = rand.Next(1, 7);
            int so2 = rand.Next(1, 7);
            int so3 = rand.Next(1, 7);
            lbSo1.Text = so1.ToString();
            lbSo2.Text = so2.ToString();
            lbSo3.Text = so3.ToString();

            int sum = so1 + so2 + so3;
            if (rd3.Checked)
            {
                
                if (sum <= 10)
                    diem += 10;
                else
                {
                    diem -= 10;
                }
            }
            else
            {
                if (sum > 10 && sum < 18)
                    diem += 10;
                else
                    diem -= 10;
            }
            lbKqua.Text = diem.ToString();
        }
    }
}
