namespace BT_Chuong3._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double x, y, r;
            x = double.Parse(txtOx.Text);
            y = double.Parse(txtOy.Text);
            r = double.Parse(txtR.Text);
            Circle c = new Circle(x, y, r);
            lblDt.Text = "Diện tích hình tròn: " + c.Dtich().ToString();
            lblCv.Text = " Chu vi hình tròn: " + c.Chuvi().ToString();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            double x, y, r;
            x = double.Parse(txtOx.Text);
            y = double.Parse(txtOy.Text);
            r = double.Parse(txtR.Text);
            Circle c = new Circle(x, y, r);
            double x1 = double.Parse(txtX.Text);
            double y1 = double.Parse(txtY.Text);
            Diem d = new Diem(x1, y1);
            bool ktra = c.checkCircle(d);
            if (ktra)
            {
                lblCheck.Text = "Điểm trên có nằm trong O: true";
            }
            else lblCheck.Text = "Điểm trên có nằm trong O: false";
        }
    }
}
