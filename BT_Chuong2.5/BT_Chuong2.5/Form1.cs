namespace BT_Chuong2._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String TextOriginal = "";
        private void btChen_Click(object sender, EventArgs e)
        {
            TextOriginal = txtS1.Text;
            txtS1.Text = txtS1.Text.Insert(int.Parse(txtVitrichen.Text), txtS2.Text);
        }

        private void btThayThe_Click(object sender, EventArgs e)
        {
            TextOriginal = txtS1.Text;
            txtS1.Text = txtS1.Text.Replace(txtS2.Text, txtS3.Text);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            TextOriginal = txtS1.Text;
            int vitri = txtS1.Text.IndexOf(txtS2.Text);
            if (vitri != 1)
            {
                txtS1.Text = txtS1.Text.Remove(vitri, txtS2.Text.Length);
            }
            else
            {
                MessageBox.Show("Không tìm thấy chuỗi s2 để xóa!");
            }
        }

        private void btDao_Click(object sender, EventArgs e)
        {
            TextOriginal = txtS1.Text;
            String[] text;
            txtS1.Clear();
            text = txtS1.Text.Split(' ', '\t', '\n');
            for (int i = text.Length - 1; i >= 0; i--)
            {
                txtS1.Text += text[i] + " ";
            }
            //txtS1.Text += '\n';
        }

        private void btChuanhoa_Click(object sender, EventArgs e)
        {
            TextOriginal = txtS1.Text;
            String[] text;
            txtS1.Clear();
            text = txtS1.Text.Split(' ', '\t', '\n');
            for (int i = 0; i < text.Length; i++)
            {
                txtS1.Text += text[i].ToUpperInvariant() + " ";
            }
        }

        private void btKhoiphuc_Click(object sender, EventArgs e)
        {
            txtS1.Text = TextOriginal;
            txtS2.Clear();
            txtS3.Clear();
            txtVitrichen.Clear();
            txtVitriLay.Clear();
        }

        private void btLayChuoi_Click(object sender, EventArgs e)
        {
            //String text = txtS1.Text.Split(int.Parse(txtVitriLay.Text);
            //String newText = text.IndexOf();
        }
    }
}
