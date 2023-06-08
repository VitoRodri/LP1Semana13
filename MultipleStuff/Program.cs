using System;

namespace MultipleStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperList<double> lis=(3,5,2,3,4,6,9);
            Console.WriteLine(SuperList.GetMinMax1(lis));
            Console.WriteLine(SuperList.list.GetMinMax2(lis));
            Tuple<double,double> items=SuperList.GetMinMax3(lis);
            Console.WriteLine(items);
            (double,double) item=SuperList.GetMinMax4(lis);
            Console.WriteLine(item);
            
        }
    }
}
