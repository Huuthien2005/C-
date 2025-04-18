using System.Security.Cryptography;

namespace BT_Chuong3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (txtA.Text != "" && txtB.Text != "" && txtC.Text != "")
            {
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                double c = double.Parse(txtC.Text);

                double max = Math.Max(a, Math.Max(b, c));
                if(a==b&&b==c)
                    lblType.Text="Tam giác đều";
                else if (max == a)
                {
                    if (b + c <= a)
                    {
                        throw new Exception("Không phải là tam giác!!!");
                    }
                    else if(Math.Pow(b,2)+Math.Pow(c,2)==Math.Pow(a,2))
                    {
                        lblType.Text="Tam giác vuông tai A";
                    }
                    else
                    {
                        lblType.Text = "Tam giác thường";
                    }
                }
                else if (max == b)
                {
                    if (a + c <= b)
                    {
                        throw new Exception("Không phải là tam giác!!!");
                    }
                    else if (Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2))
                    {
                        lblType.Text = "Tam giác vuông tai B";
                    }
                    else
                    {
                        lblType.Text = "Tam giác thường";
                    }
                }
                else if(b+a<=c)
                {
                    if (b + a <= c)
                    {
                        throw new Exception("Không phải là tam giác!!!");
                    }
                    else if (Math.Pow(b, 2) + Math.Pow(a, 2) == Math.Pow(c, 2))
                    {
                        lblType.Text = "Tam giác vuông tai C";
                    }
                    else
                    {
                        lblType.Text = "Tam giác thường";
                    }
                }
                Triangle t = new Triangle(a,b,c);
                lblCvi.Text = "Chu vi tam giác là: " + t.getPerimeter().ToString();
                lblDtich.Text = "Diện tích tam giác là: " + t.getArea().ToString();
            }
            else
                throw new Exception("Vui long nhap dung thong tin!");
            
        }
    }
}
