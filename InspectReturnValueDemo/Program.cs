using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspectReturnValueDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var sphere = new Sphere();
            sphere.CalculateArea(3.0);
        }
    }
}
