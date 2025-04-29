using System.Security.Cryptography;

namespace BTVN_chuong2._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool SNT(int n)
        {
            if (n < 2)
                return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        private void btnCal_Click(object sender, EventArgs e)
        {

            try
            {
                int countEven = 0;
                int countOdd = 0;
                int summary = 0;
                if (txtInput.Text == "")
                    throw new Exception(Name + " không hợp lệ! Vui lòng nhập lại số nguyên dương.");
                int n = int.Parse(txtInput.Text);
                if (n < 0 || n.GetType() != typeof(int))
                    throw new Exception(Name + " không hợp lệ! Vui lòng nhập lại số nguyên dương.");
                int[] arr = new int[n];
                for (int i = 0; i < n; i++)
                {
                    arr[i] = RandomNumberGenerator.GetInt32(1, 100);
                    txtShow.Text += arr[i] + " ";
                }

                for (int i = 0; i < n; i++)
                {
                    summary += arr[i]; // Tính tổng các số trong mảng
                    if (arr[i] % 2 == 0)
                    {
                        countEven += arr[i];// Tính tổng các số chẵn
                    }
                    else
                    {
                        countOdd += arr[i];// Tính tổng các số lẻ
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    if (SNT(arr[i]))
                    {
                        txtSNT.Text += arr[i] + " ";
                    }
                }
                txtAverage.Text = (summary / n).ToString();
                txtSumEven.Text = countEven.ToString();
                txtSumOdd.Text = countOdd.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
            finally
            {
                txtInput.Clear();
                txtInput.Focus();
            }
        }

        private void btnTry_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtInput.Focus();
            txtShow.Clear();
            txtAverage.Clear();
            txtSumEven.Clear();
            txtSumOdd.Clear();
            txtSNT.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }
    }
}
