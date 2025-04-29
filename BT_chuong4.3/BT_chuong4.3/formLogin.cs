using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_chuong4._3
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }
        public string UserName
        {
            get { return txtUser.Text; }
        }
        private void btnSignin_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPassword.Text))
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                }
                if (txtPassword.Text.Equals("admin"))
                {
                    FrmMain f = new FrmMain(txtUser.Text);
                    this.Hide();
                    f.Update();
                    f.Dispose(); 
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                txtUser.Clear();
                txtPassword.Clear();
                txtUser.Focus();
            }
        }

        private void btnEsc_Click(object sender, EventArgs e)
        {
            DialogResult result=MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                txtUser.Clear();
                txtPassword.Clear();
                txtUser.Focus();
            }
        }
    }
}
