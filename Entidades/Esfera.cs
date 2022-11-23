using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Esfera
    {
    public double radio { get; set; }
    public Color Color { get; set; }
    public Trazo Trazo { get; set; }

        public double GetVolumen()
        {
            int n = 3;
            double volumen = 1.333333333 * Math.PI * Math.Pow(radio, n);
            return volumen;
        }
        public double GetArea()
        {
            int n = 2;
            double area = 4*Math.PI*Math.Pow(radio,n);
            return area;

        }
    }
}
