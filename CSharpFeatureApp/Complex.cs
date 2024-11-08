using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatureApp
{
    public class Complex
    {
        private int real, img;
        public Complex(int real, int img)
        {
            this.real = real;
            this.img = img;
        }

        public override string ToString()
        {
            return this.real + " " + this.img;
        }

    }
}
