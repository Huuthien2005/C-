using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Chuong3._3
{
    internal class Circle: Diem
    {
        protected double r;
        public Circle(double x,double y,double r) : base(x, y)
        {
            this.r = r;
        }
        public double R
        {
            get { return this.r; }
            set { this.r = value; }
        }
        public double Chuvi()
        {
            return 2 * Math.PI * this.r;
        }
        public double Dtich()
        {
            return Math.PI * Math.Pow(this.r, 2);
        }
        public bool checkCircle(Diem c)
        {
            return (Math.Pow(c.X - this.x, 2) + Math.Pow(c.Y - this.y, 2) <= Math.Pow(r, 2));
        }
    }
}
