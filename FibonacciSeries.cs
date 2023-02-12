using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class FibonacciSeries
    {
        public void getFibonacciSeris() 
        {
            int iVlaue1 = 0, iVlaue2 = 1, iVlaue3 = 0;
            Console.WriteLine("Enter Number for Fibonacci Series");
            int iValue=Convert.ToInt32(Console.ReadLine());

            for(int i=0; i<iValue; i++) 
            {
                Console.WriteLine(iVlaue3);
                iVlaue3 = iVlaue1 + iVlaue2;
                iVlaue1 = iVlaue2;
                iVlaue2 = iVlaue3;
            }     
        }     
    }
}
