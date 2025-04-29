namespace BT_chuong4._3
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        public FrmMain(string text) : this()
        {
            txtNameUser.Text = text;
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in Lv.SelectedItems)
            {
                Lv.Items.Remove(item);
            }
        }
        private formLogin formlogin = new formLogin();
        private void FrmMain_Load(object sender, EventArgs e)
        {
            //this.Hide();
            formlogin.ShowDialog();
            txtNameUser.Text = formlogin.UserName;

        }
        private int count = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //lap tung cot cho listview
                //ListView listView = new ListView();
                Lv.View = View.Details;
                Lv.Columns.Add("STT", 50);
                Lv.Columns.Add("Họ tên", 200);
                Lv.Columns.Add("Giới tính", 100);
                Lv.Columns.Add("Ngày sinh", 150);
                
                if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(dtpDoB.Text))
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                }
                else if (!rbtnNam.Checked && !rbtnNu.Checked)
                {
                    throw new Exception("Vui lòng chọn giới tính");
                }
                //tao 1 item moi
                ListViewItem item = new ListViewItem((count++).ToString());
                item.SubItems.Add(txtName.Text);
                if (rbtnNam.Checked)
                    item.SubItems.Add("Nam");
                else
                    item.SubItems.Add("Nữ");
                //string.Format("{dd/MM/yyyy}", dtpDoB.ToString())
                dtpDoB.Format = DateTimePickerFormat.Custom;
                item.SubItems.Add(dtpDoB.Format.ToString());
                //them vao listview theo dong
                Lv.Items.Add(item);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                txtName.Clear();
                dtpDoB.ResetText();
                txtName.Focus();
                rbtnNam.Checked = false;
                rbtnNu.Checked = false;
            }
        }
    }
}
