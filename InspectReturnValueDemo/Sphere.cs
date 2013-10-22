using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspectReturnValueDemo
{
    public class Sphere
    {
        public double CalculateArea(double radius)
        {
            var circle = new Circle();
            return 4 * circle.CalculateArea(radius);
        }
    }
}
