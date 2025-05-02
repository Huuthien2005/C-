namespace BTVN_Chuong4._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtString.Text))
                {
                    throw new Exception("PLease, Enter a String");
                }
                lbL.Items.Add(txtString.Text);
                txtString.Clear();
                txtString.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Anouncement!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                txtString.Clear();
                txtString.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbL.Items.Clear();
            lbR.Items.Clear();
        }

        private void btnLR_Click(object sender, EventArgs e)
        {
                foreach (var item in lbL.SelectedItems)
                {
                    if (item is null)
                    {
                        MessageBox.Show("Please, select an item", "Anouncement!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                    lbR.Items.Add(item);
                    lbL.Items.Remove(item);
                }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (var item in lbL.SelectedItems)
            {
                lbL.Items.Remove(item);
            }
            foreach (var item in lbR.SelectedItems)
            {
                lbR.Items.Remove(item);
            }
        }

        private void btnRL_Click(object sender, EventArgs e)
        {
                foreach (var item in lbR.SelectedItems)
                {
                    if (item is null)
                    {
                        MessageBox.Show("Please, select an item", "Anouncement!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    lbL.Items.Add(item);
                    lbR.Items.Remove(item);
                }
        }
    }
}
