using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PerfectNumber
    {
        public void getPerfectNumber()
        {
            Console.WriteLine("Enter Number for Perfect Number");
            int iValue = Convert.ToInt32(Console.ReadLine());
            int iSum = 0;
            for(int i=1;i<iValue;i++)
            {
                if (iValue % i == 0)
                {
                    iSum = iSum + i;
                }
            }
            if(iSum == iValue)
            {
                Console.WriteLine("It is Perfect Number");
            }
            else
            {
                Console.WriteLine("It is Not Perfect Number");
            }


        }
    }
}
