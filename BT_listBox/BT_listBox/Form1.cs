namespace BT_listBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Label lblInput;
        private TextBox txtInput;
        private Button btnAdd;
        private Button btnDel;
        private ListBox lb;
        private void CreateControl()
        {
            lblInput = new Label();
            lblInput.Text = " Enter a color name: ";
            lblInput.Name = "lblInput";
            lblInput.Location = new Point(50, 100);
            lblInput.AutoSize = true;
            this.Controls.Add(lblInput);
            txtInput = new TextBox();
            txtInput.Name = "txtInput";
            txtInput.Location = new Point(250, 100);
            txtInput.Size=new Size(200, 30);
            this.Controls.Add(txtInput);
            btnAdd = new Button();
            btnAdd.Name = "btnAdd";
            btnAdd.Text = "add Color";
            btnAdd.Size = new Size(100, 30);
            btnAdd.Location = new Point(100, 200);
            this.Controls.Add(btnAdd);
            btnDel = new Button();
            btnDel.Name = "btnDel";
            btnDel.Text = "Delete Color";
            btnDel.Size = new Size(100, 30);
            btnDel.Location = new Point(300, 200);
            this.Controls.Add(btnDel);
            lb = new ListBox();
            lb.Location = new Point(100, 250);
            lb.Size = new Size(300, 200);
            lb.Name = "lb";
            this.Controls.Add(lb);
            attachEvents_add();
            attachEvents_del();
        }
        private void attachEvents_add()
        {
            btnAdd.Click += Add;
        }
        private void Add(object sender,EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtInput.Text))
                {
                    throw new Exception("Color can not be empty");
                }
                if (lb.Items.Contains(txtInput.Text))
                {
                    throw new Exception("Color Already exists in the list box. Please choose or enter a different color name");
                }
                lb.Items.Add(txtInput.Text);
                txtInput.Clear();
                txtInput.Focus();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txtInput.Clear();
                txtInput.Focus();
            }
        }
        private void attachEvents_del()
        {
            btnDel.Click += Del;
        }
        private void Del(object sender,EventArgs e)
        {
            try
            {
                if (lb.SelectedItem == null)
                {
                    throw new Exception("Please select an item to delete");
                }
                lb.Items.Remove(lb.SelectedItem);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CreateControl();
        }
    }
}
