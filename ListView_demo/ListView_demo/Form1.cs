namespace ListView_demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtHocVan.Text))
                {
                    throw new Exception("vui nhập đầy đủ thông tin");
                }
                ListViewItem item = new ListViewItem(txtName.Text);
                item.SubItems.Add(txtHocVan.Text);
                if (rbtnM.Checked)
                    item.SubItems.Add("Nam");
                else
                    item.SubItems.Add("Nữ");
                item.SubItems.Add(DateTime.Now.ToString("dd/MM/yyyy"));
                Lv.Items.Add(item);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                txtName.Clear();
                txtHocVan.Clear();
                txtName.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Lv.View = View.Details;
            Lv.Columns.Add("Họ tên", 150);
            Lv.Columns.Add("Học vấn", 80, HorizontalAlignment.Center);
            Lv.Columns.Add("Giới tính", 80, HorizontalAlignment.Center);
            Lv.Columns.Add("Ngay dang ky ", 100, HorizontalAlignment.Right);
            rbtnM.Checked = true;
            cbView.Items.AddRange(new String[] { "Detail", "Large", "Small", "List", "Title" });
            cbView.SelectedItem = "Detail";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in Lv.SelectedItems)
            {
                Lv.Items.Remove(item);
            }
        }

        private void cbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lv.View = (View)cbView.SelectedIndex;
        }
    }
}
