using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo_userControl
{
    public partial class Clock : UserControl
    {
        public Clock()
        {
            InitializeComponent();
        }
        private void Clock_Load(object sender,EventArgs e)
        {
            label1.BackColor= Color.Transparent;
            label1.ForeColor = Color.White;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = String.Format("{0}:{1:##}:{2:##}", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
        }
    }
}
