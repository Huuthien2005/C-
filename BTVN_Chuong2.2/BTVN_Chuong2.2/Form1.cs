namespace BTVN_Chuong2._2
{
    public partial class ptb2 : Form
    {
        public ptb2()
        {
            InitializeComponent();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            int c = int.Parse(txtC.Text);
            double delta = Math.Pow(b, 2) - 4 * a * c;
            if (delta > 0)
            {
                txtKQ.Text="phuong trinh co 2 nghiem phan biet\n";
                txtKQ.Text+= "x1=" + (((double)-b + Math.Sqrt(delta)) / (2 * a)) + "\n" +
                    "x2=" + ((double)-b - Math.Sqrt(delta)) / (2 * a);
            }
            else if (delta == 0)
            {
                txtKQ.Text="phuong trinh co 1 nghiem";
                txtKQ.Text = ((double)-b / (2 * a)).ToString();
            }
            else
            {
                txtKQ.Text = "phuong trinh vo nghiem";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ptb2.ActiveForm.Close();
        }
    }
}
