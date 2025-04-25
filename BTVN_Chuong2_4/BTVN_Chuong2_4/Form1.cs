namespace BTVN_Chuong2_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txtShow.Text = "";
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            if (txtShow.Text == "")
                return;
            txtShow.Text = txtShow.Text.Substring(0, txtShow.Text.Length - 1);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtShow.Text.Contains("="))
                txtShow.Text = "";
            txtShow.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtShow.Text.Contains("="))
                txtShow.Text = "";
            txtShow.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtShow.Text.Contains("="))
                txtShow.Text = "";
            txtShow.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtShow.Text.Contains("="))
                txtShow.Text = "";
            txtShow.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtShow.Text.Contains("="))
                txtShow.Text = "";
            txtShow.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtShow.Text.Contains("="))
                txtShow.Text = "";
            txtShow.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtShow.Text.Contains("="))
                txtShow.Text = "";
            txtShow.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtShow.Text.Contains("="))
                txtShow.Text = "";
            txtShow.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtShow.Text.Contains("="))
                txtShow.Text = "";
            txtShow.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtShow.Text.Contains("="))
                txtShow.Text = "";
            txtShow.Text += "9";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (txtShow.Text.Length > 0 && txtShow.Text[txtShow.Text.Length - 1] == '+')
                return;
            if (txtShow.Text=="")
                return;
            if (txtShow.Text.Contains("="))
                txtShow.Text = "";
            txtShow.Text += "+";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (txtShow.Text.Length > 0 && txtShow.Text[txtShow.Text.Length - 1] == '-')
                return;
            if (txtShow.Text == "")
                return;
            if (txtShow.Text.Contains("="))
                txtShow.Text = "";
            txtShow.Text += "-";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (txtShow.Text.Length > 0 && txtShow.Text[txtShow.Text.Length - 1] == '*')
                return;
            if (txtShow.Text=="")
                return;
            if (txtShow.Text.Contains("="))
                txtShow.Text = "";
            txtShow.Text += "*";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (txtShow.Text.Length > 0 && txtShow.Text[txtShow.Text.Length - 1] == '/')
                return;
            if (txtShow.Text=="")
                return;
            if (txtShow.Text.Contains("="))
                txtShow.Text = "";
            txtShow.Text += "/";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (txtShow.Text == "")
                return;
            char phepToan = ' ';
            if (txtShow.Text.Contains("+"))
                phepToan = '+';
            else if (txtShow.Text.Contains("-"))
                phepToan = '-';
            else if (txtShow.Text.Contains("*"))
                phepToan = '*';
            else if (txtShow.Text.Contains("/"))
                phepToan = '/';
            else
                return;
            int s1, s2;
            String kq = "";
            string[] arr = txtShow.Text.Split(phepToan);
            s1 = int.Parse(arr[0]);
            s2= int.Parse(arr[1]);
            if (arr.Length > 2)
            {
                MessageBox.Show("Phép toán chỉ được phép có 2 toán hạng và 1 toán tử!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            switch (phepToan)
            {
                case '+':
                    kq = (s1 + s2).ToString();
                    break;
                    
                case '-':
                    kq = (s1 - s2).ToString();
                    break;
                case '*':
                    kq = (s1 * s2).ToString();
                    break;
                case '/':
                    if (s2 == 0)
                    {
                        MessageBox.Show("Phép chia cho 0 không thể thực hiện.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    kq = (s1 / s2).ToString();
                    break;
            }
            txtShow.Text += "="+kq;
        }
    }
}
