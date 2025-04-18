using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Chuong3._2
{
    internal class Triangle
    {
        protected double a;
        protected double b;
        protected double c;
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double A{
            get { return a; }
            set { this.a = value; }
        } 
        public double B
        {
            get { return b; }
            set { this.b = value; }
        }
        public double C
        {
            get { return c; }
            set { this.c = value; }
        }
        public double getPerimeter()
        {
            return a + b + c;
        }
        public double getArea()
        {
            return Math.Sqrt(getPerimeter()/2 * (getPerimeter()/2 - a) * (getPerimeter()/2 - b) * (getPerimeter()/2 - c));
        }
    }
}
