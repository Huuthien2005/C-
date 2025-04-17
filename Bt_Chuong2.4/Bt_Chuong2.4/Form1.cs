namespace Bt_Chuong2._4
{
    public partial class lblSo1 : Form
    {
        public lblSo1()
        {
            InitializeComponent();
        }
        Random rand = new Random();
        String[] toantu = { "+", "-", "x", ":" };
        int vitri = 0;

        private void btTieptuc_Click(object sender, EventArgs e)
        {
            int so1, so2;
            do
            {
                so1 = rand.Next(10);
                so2 = rand.Next(10);
                vitri = rand.Next(0, 4);
            } while (vitri == 3 && so2 == 0);
            lbSo1.Text = so1.ToString();
            lbSo2.Text = so2.ToString();
            lblToantu.Text = toantu[vitri];
            lblResult.Text = "";
            txtDoan.Text = "";
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtDoan.Text += bt.Text;
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtDoan.Text += bt.Text;
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtDoan.Text += bt.Text;
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtDoan.Text += bt.Text;
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtDoan.Text += bt.Text;
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtDoan.Text += bt.Text;
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtDoan.Text += bt.Text;
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtDoan.Text += bt.Text;
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtDoan.Text += bt.Text;
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtDoan.Text += bt.Text;
        }

        private void btDau_Click(object sender, EventArgs e)
        {
            if (txtDoan.Text != "")
                return;
            txtDoan.Text = "-";
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (txtDoan.Text == "")
                return;
            txtDoan.Text.Substring(0, txtDoan.Text.Length - 1);
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            int kq = 0;
            switch (vitri)
            {
                case 0:
                    kq = int.Parse(lbSo1.Text) + int.Parse(lbSo2.Text);
                    break;
                case 1:
                    kq = int.Parse(lbSo1.Text) - int.Parse(lbSo2.Text);
                    break;
                case 2:
                    kq = int.Parse(lbSo1.Text) * int.Parse(lbSo2.Text);
                    break;
                case 3:
                    kq = int.Parse(lbSo1.Text) / int.Parse(lbSo2.Text);
                    break;
            }
            int doan = int.Parse(txtDoan.Text);
            try
            {
                if (doan == kq)
                {
                    lblResult.Text = "Chúc mừng bạn đã đoán đúng";
                }
                else
                {
                    lblResult.Text = String.Format("Sai rồi! đáp án là {0}", kq.ToString());
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
