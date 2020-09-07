using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Danila_Nesterko
{
    class Triangle
    {
        public double a;
        public double b;
        public double c;
        public double h;

        public Triangle()
        {
            
        }
        public Triangle(double A, double B, double C)
        {
            a = A;
            b = B;
            c = C;
        }
        public Triangle(double A, double H)
        {
            a = A;
            h = H;
        }
        public string outputA()
        {
            return Convert.ToString(a);
        }
        public string outputB()
        {
            return Convert.ToString(b);
        }
        public string outputH()
        {
            return Convert.ToString(h);
        }
        public string outputC()
        {
            return Convert.ToString(c);
        }
        public string Ttype()
        {
            var type = " ";

            if ((a == b) || (b == c) || (a == c)) 
            {
                type = "Равнобедренный";
            }
            if ((a == b) && (b == c) && (a == c))
            {
                type = "Равносторонний";
            }
            if ((a != b) && (b != c) && (a != c))
            {
                type = "Разносторонний";
            }
            return type;
        }
        public double Perimeter()
        {
            double p = 0;
            p = a + b + c;
            return p;
        }
        public double Surface() 
        {
            double s = 0;
            double p = 0;
            p = (a + b + c) / 2;
            s = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
            return s;
        }
        public double SurfaceH()
        {
            double s = 0;
            double p = 0;
            p = a * 0.5;
            s = Math.Sqrt(p * h);
            return s;
        }
        public double Half_Perimeter()
        {
            double p = 0;
            p = a + b + c;
            p = p / 2;
            return p;
        }
        public double GetSetA
        {
            get
            { return a; }
            set
            { a = value; }
        }
        public double GetSetB
        {
            get
            { return b; }
            set
            { b = value; }
        }
        public double GetSetC
        {
            get
            { return c; }
            set
            { c = value; }
        }
        public double GetSetH
        {
            get
            { return h; }
            set
            { h = value; }
        }
        public bool ExistTriangle //свойство свойства свойства свойства
        {
            get
            {
                if ((a < b + c) && (b < a + c) && (c < a + b))
                return true;
                else return false;
            }
        }
    }

}

