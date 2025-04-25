namespace BTVN_Chuong2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnC1_Click(object sender, EventArgs e)
        {
            try
            {
                String s = "";
                s = txtMa.Text;
                if (txtMa.Text == "")
                {
                    throw new Exception("nhap dung ma ASCII!");
                }
                txtKqKT.Text = char.ConvertFromUtf32(int.Parse(s)).ToString();
            }
            catch (FormatException ex)
            {

                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txtMa.Clear();
                txtMa.Focus();
                txtKT.Clear();
                txtKqMa.Clear();
                txtKqKT.Clear();
            }
        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            
            try
            {
                String s = "";
                if (txtKT.Text == "")
                {
                    throw new Exception("nhap dung ky tu!");
                }
                s = txtKT.Text;
                txtKqMa.Text = char.ConvertToUtf32(s, 0).ToString();
            }
            catch (FormatException ex)
            {

                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txtMa.Clear();
                txtMa.Focus();
                txtKT.Clear();
                txtKqMa.Clear();
                txtKqKT.Clear();
            }
        }
    }
}
