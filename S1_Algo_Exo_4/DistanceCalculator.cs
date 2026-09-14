using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo_Exo_4
{
    internal class DistanceCalculator
    {
        public static double PointDistanceCalculator(double xA, double yA, double xB, double yB)
        {
            return Math.Sqrt(Math.Pow((xB - xA), 2) + Math.Pow((yB - yA),2));
        }
    }
}
