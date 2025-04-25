using System.Security.Cryptography;

namespace BT_Chuong2._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] arr= { };
        private void btnRandom_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCount.Text == "")
                {
                    throw new Exception("Vui long nhap so phan tu!");//thong bao loi
                }
                int n = int.Parse(txtCount.Text);
                arr = new int[n];
                for (int i = 0; i < n; i++)
                {
                    arr[i] = RandomNumberGenerator.GetInt32(1, 100);
                    txtOriginArray.Text += arr[i].ToString();
                    if (i != n - 1)
                    {
                        txtOriginArray.Text += ",";
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Announce",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void sort()
        {
            for(int i = arr.Length-1; i >=0; i--)
            {
                txtReverseArray.Text += arr[i].ToString();
                if (i != 0)
                {
                    txtReverseArray.Text += ",";
                }
            }
            for(int i = 0; i < arr.Length-1; i++)
            {
                for(int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                txtIncreaseArray.Text += arr[i].ToString();
                if (i != arr.Length - 1)
                {
                    txtIncreaseArray.Text += ",";
                }
            }

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                txtDecreaseArray.Text += arr[i].ToString();
                if (i != 0)
                {
                    txtDecreaseArray.Text += ",";
                }
            }

        }
        private void SortSpecial()
        {
            int[] odd = { };//mang le
            int[] even = { };//mang chan
            int evenIndex = 0;
            int oddIndex = 0;
            int index = 0;
            int[] result = new int[arr.Length];
            var evenNumbers = arr.Where(x => x % 2 == 0).OrderBy(x=>x).ToArray();
            var oddNumbers = arr.Where(x => x % 2 != 0).OrderByDescending(x=>x).ToArray();
            while (evenIndex != evenNumbers.Length)
            {
                result[index++] = evenNumbers[evenIndex++];
            }
            while (oddIndex != oddNumbers.Length)
            {
                result[index++] = oddNumbers[oddIndex++];
            }
            for(int i = 0; i < arr.Length; i++)
            {
                txtSpecialSort.Text += result[i].ToString();
                if (i != arr.Length - 1)
                {
                    txtSpecialSort.Text += ",";
                }
            }
        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            sort();
            SortSpecial();
        }
    }
}
