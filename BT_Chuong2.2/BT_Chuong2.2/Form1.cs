namespace BT_Chuong2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btTinh_Click(object sender, EventArgs e)
        {
            try
            {
                int a = checked(int.Parse(txtSo1.Text));
                int b = checked(int.Parse(txtSo2.Text));
                if (rdCong.Checked)
                {
                    lbKqua.Text = String.Format("{0}",checked(a + b));
                }
                else if (rdTru.Checked)
                {
                    lbKqua.Text = String.Format("{0}", checked(a - b));
                }
                else if (rdNhan.Checked)
                {
                    lbKqua.Text = String.Format("{0}", checked(a * b));
                }
                else if (rdChia.Checked)
                {
                    if (b == 0)
                    {
                        throw new DivideByZeroException("Khong the chia cho 0");
                    }
                    else
                    {
                        lbKqua.Text = String.Format("{0:0.00}", (double) a/b);
                    }
                }
                else
                {
                    lbKqua.Text = String.Format("{0}", a % b);
                }
            }catch(FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(DivideByZeroException ex)
            {
                lbKqua.Text = ex.Message;
            }
            catch(OverflowException ex)
            {
                lbKqua.Text = "khong the xu ly so qua lon!";
            }
        }
    }
}
