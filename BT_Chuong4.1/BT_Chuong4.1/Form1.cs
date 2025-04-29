using System.CodeDom;

namespace BT_Chuong4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private MenuStrip menuBar;
        private ToolStripMenuItem menuFile, menuEdit, menuFileNew, menuFileExit, menuFileOpen, menuEditCut, menuEditCopy, menuEditPaste, menuEditDelete;
        private void createMenu()
        {
            menuBar = new MenuStrip();
            menuBar.Font = new Font("Arial", 12, FontStyle.Regular);
            menuFile = new ToolStripMenuItem("File");
            menuFileNew = new ToolStripMenuItem("New");
            menuFileNew.ShortcutKeys = Keys.Control | Keys.N;
            menuFileOpen = new ToolStripMenuItem("Open");
            menuFileExit = new ToolStripMenuItem("Exit");
            menuFile.DropDownItems.AddRange(new ToolStripMenuItem[] { menuFileNew, menuFileOpen, menuFileExit });
            menuEdit = new ToolStripMenuItem("Edit");
            menuEditCut = new ToolStripMenuItem("Cut");
            menuEditCopy = new ToolStripMenuItem("Copy");
            menuEditPaste = new ToolStripMenuItem("Paste");
            menuEditDelete = new ToolStripMenuItem("Delete");
            menuEdit = new ToolStripMenuItem("Edit");
            menuEdit.DropDownItems.AddRange(new ToolStripMenuItem[] { menuEditCut, menuEditCopy, menuEditPaste, menuEditDelete });
            menuBar.Items.AddRange(new ToolStripMenuItem[] { menuFile, menuEdit });
            this.Controls.Add(menuBar);
            attachEvent();
        }
        private void attachEvent()
        {
            menuFileExit.Click += processClick;
        }
        private void processClick(object o,EventArgs e)
        {
            if (o.Equals(menuFileExit))
            {
                DialogResult result=MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    return;
                }
            }
        }
        private TextBox txtInput;
        private Label lblInput;
        private Button btnCalCulate;
        private void CreateControl()
        {
            txtInput = new TextBox();
            txtInput.Name = "txtInput";
            txtInput.Location = new Point(390, 190);
            txtInput.Size = new Size(150, 30);
            txtInput.TabIndex = 0;
            this.Controls.Add(txtInput);
            lblInput = new Label();
            lblInput.Name = "lblInput";
            lblInput.Text = "Enter a number: ";
            lblInput.Location = new Point(190, 190);
            this.Controls.Add((Label)lblInput);
            btnCalCulate = new Button();
            btnCalCulate.Name = "btnCalculate";
            btnCalCulate.Text = "Calculate";
            btnCalCulate.Size = new Size(110, 30);
            btnCalCulate.Location = new Point(280, 280);
            btnCalCulate.TabIndex = 1;
            this.Controls.Add((Button)btnCalCulate);
            btnCalCulate.Click += BtnCalculate_Click;
        }
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtInput.Text == ""|| !int.TryParse(txtInput.Text,out _))
                {
                    throw new Exception("please Enter a number!");
                }
                int n = int.Parse(txtInput.Text);
                if (n < 0)
                {
                    throw new Exception("please Enter a positive number!");
                }
                //txtInput.Text = String.Format("gia tri cua {0} la {1}", n, Math.Pow(n, 2));
                MessageBox.Show("gia tri cua " + n.ToString() + " la: " + (Math.Pow(n, 2)).ToString());
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
        
        private void Form1_Load(object sender, EventArgs e)
        {
            createMenu();
            CreateControl();
        }
    }
}
