using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleStuff
{
    public class SuperList: List<double>
    {
        public double GetMinMax1(out List<double> list)
        {
            list=(9,2);
            return(list.Min(),list.Max());
        }
        struct list
        {
            public double GetMinMax2(List<double> list)
            {
                return(list.Min(),list.Max());
            }
        } 
        public static Tuple<double,double> GetMinMax3(List<double> list)
        {
            return Tuple.Create(list.Min(),list.Max());
        }
        public static (double min, double max) GetMinMax4(List<double> list)
        {
            return(list.Min(),list.Max());
        }
    }
}