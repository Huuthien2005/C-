using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Chuong3._3
{
    internal class Diem
    {
        protected double x;
        protected double y;
        public Diem(double x,double y)
        {
            this.x = x;
            this.y = y;
        }
        public double X
        {
            get { return x; }
            set { this.x = value; }
        }
        public double Y
        {
            get { return y; }
            set { this.y = value; }
        }
    }
}
