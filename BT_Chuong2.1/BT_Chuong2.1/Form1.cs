namespace BT_Chuong2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                a = int.Parse(txtSo1.Text);
                b = int.Parse(txtSo2.Text);
                Kqua.Text = String.Format("{0}", a + b);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txtSo1.Clear();
                txtSo2.Clear();
            }
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                a = int.Parse(txtSo1.Text);
                b = int.Parse(txtSo2.Text);
                Kqua.Text = String.Format("{0}", a - b);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txtSo1.Clear();
                txtSo2.Clear();
            }
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                a = int.Parse(txtSo1.Text);
                b = int.Parse(txtSo2.Text);
                Kqua.Text = String.Format("{0}", a * b);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txtSo1.Clear();
                txtSo2.Clear();
            }
        }

        private void btChia_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                a = int.Parse(txtSo1.Text);
                b = int.Parse(txtSo2.Text);
                if (b == 0)
                {
                    throw new DivideByZeroException("Can't divide by zero!");
                }
                Kqua.Text = String.Format("{0:0.00}", (double)a / b);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txtSo1.Clear();
                txtSo2.Clear();
            }
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
