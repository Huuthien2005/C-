namespace BTVN_Chuong2._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<string> dssv = new List<string>();
        private void capnhatListBox()
        {
            lstShow.Items.Clear();
            foreach (var it in dssv)
            {
                lstShow.Items.Add(it);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string mssv = txtMSSV.Text.Trim();
            string ho = txtLName.Text.Trim();
            string ten = txtFName.Text.Trim();
            try
            {

                if (string.IsNullOrEmpty(mssv) || string.IsNullOrEmpty(ho) || string.IsNullOrEmpty(ten))
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                }
                string sinhVien = $"{mssv} - {ho} {ten}";
                dssv.Add(sinhVien);
                capnhatListBox();
                txtMSSV.Clear();
                txtFName.Clear();
                txtLName.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                txtMSSV.Clear();
                txtLName.Clear();
                txtFName.Clear();
                txtMSSV.Focus();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string tukhoa = txtSearch.Text.Trim().ToLower();
            var kqua = dssv.Where(s =>
            {
                string[] parts = s.Split('-');
                if (parts.Length < 2) return false;
                string mssv = parts[0].Trim().ToLower();
                string hoTen = parts[1].Trim();
                string ten = hoTen.Split(' ').Last().ToLower();
                return mssv.Contains(tukhoa) || ten.Contains(tukhoa);
            }).ToList();
            foreach(var it in kqua)
            {
                lstShow.Items.Add(it);
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            dssv.Sort((a, b) =>
            {
                string tenA = a.Split('-')[1].Trim().Split(' ').Last();
                string tenB = b.Split('-')[1].Trim().Split(' ').Last();
                return a.CompareTo(b);
            });
            capnhatListBox();
        }
    }
}
