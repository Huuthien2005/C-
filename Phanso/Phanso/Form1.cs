namespace Phanso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            Fraction a, b, kq;
            kq = new Fraction();
            try
            {
                a = new Fraction(int.Parse(txtTso1.Text), int.Parse(txtMso1.Text));
                b = new Fraction(int.Parse(txtTso2.Text), int.Parse(txtMso2.Text));
                kq = a.plus(b);
                txtTso.Text = kq.Tso.ToString();
                txtMso.Text = kq.Mso.ToString();
                //Console.WriteLine(kq.Tso.ToString() + "/" + kq.Mso.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
            finally
            {
                txtTso1.Clear();
                txtMso1.Clear();
                txtTso2.Clear();
                txtMso2.Clear();
                txtTso.Clear();
                txtMso.Clear();
            }
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            Fraction a, b, kq;
            kq = new Fraction();
            try
            {
                a = new Fraction(int.Parse(txtTso1.Text), int.Parse(txtMso1.Text));
                b = new Fraction(int.Parse(txtTso2.Text), int.Parse(txtMso2.Text));
                kq = a.minus(b);
                txtTso.Text = kq.Tso.ToString();
                txtMso.Text = kq.Mso.ToString();
                //Console.WriteLine(kq.Tso.ToString() + "/" + kq.Mso.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
            finally
            {
                txtTso1.Clear();
                txtMso1.Clear();
                txtTso2.Clear();
                txtMso2.Clear();
                txtTso.Clear();
                txtMso.Clear();
            }
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            Fraction a, b, kq;
            kq = new Fraction();
            try
            {
                a = new Fraction(int.Parse(txtTso1.Text), int.Parse(txtMso1.Text));
                b = new Fraction(int.Parse(txtTso2.Text), int.Parse(txtMso2.Text));
                kq = a.multiply(b);
                txtTso.Text = kq.Tso.ToString();
                txtMso.Text = kq.Mso.ToString();
                //Console.WriteLine(kq.Tso.ToString() + "/" + kq.Mso.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
            finally
            {
                txtTso1.Clear();
                txtMso1.Clear();
                txtTso2.Clear();
                txtMso2.Clear();
                txtTso.Clear();
                txtMso.Clear();
            }
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            Fraction a, b, kq;
            kq = new Fraction();
            try
            {
                a = new Fraction(int.Parse(txtTso1.Text), int.Parse(txtMso1.Text));
                b = new Fraction(int.Parse(txtTso2.Text), int.Parse(txtMso2.Text));
                kq =a.divide(b);
                txtTso.Text = kq.Tso.ToString();
                txtMso.Text = kq.Mso.ToString();
                //Console.WriteLine(kq.Tso.ToString() + "/" + kq.Mso.ToString());
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
            finally
            {
                txtTso1.Clear();
                txtMso1.Clear();
                txtTso2.Clear();
                txtMso2.Clear();
                txtTso.Clear();
                txtMso.Clear();
            }
        }
    }
    public class Fraction
    {
        int tso;
        int mso;
        public Fraction()
        {
            this.tso = 0;
            this.mso = 1;
        }
        public Fraction(int a, int b)
        {
            this.tso = a;
            this.mso = b;
        }
        public int Tso
        {
            get { return this.tso; }
            set { this.tso = value; }
        }
        public int Mso
        {
            get { return this.mso; }
            set { this.mso = value; }
        }
        public int UCLN(int a, int b)
        {
            if (b == 0)
                return a;
            return UCLN(b, a % b);
        }
        public void rutGon(Fraction a)
        {
            int ucln = UCLN(a.tso, a.mso);
            a.tso = a.tso / ucln;
            a.mso = a.mso / ucln;
        }
        public Fraction plus(Fraction a)
        {
            Fraction f = new Fraction();
            f.tso = this.tso * a.mso + a.tso * this.mso;
            f.mso = a.mso * this.mso;
            //rutGon(f);
            return f;
        }
        public Fraction minus(Fraction a)
        {
            Fraction f=new Fraction();
            f.tso = this.tso * a.mso - a.tso * this.mso;
            f.mso = a.mso * this.mso;
            //rutGon(f);
            return f;
        }
        public Fraction multiply(Fraction a)
        {
            Fraction f = new Fraction();
            f.tso = this.tso * a.tso;
            f.mso = this.mso * a.mso;
            //rutGon(f);
            return f;
        }
        public Fraction divide(Fraction a)
        {
            Fraction f = new Fraction();
            f.tso = this.tso * a.mso;
            f.mso = this.mso * a.tso;
            //rutGon(f);
            return f;
        }


    }
}
