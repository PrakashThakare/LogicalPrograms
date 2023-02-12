using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PrimeNumber
    {
        public void getPrimeNumber()
        {
            Console.WriteLine("Enter Number for Check Prime Number or Not");
            int iValue = Convert.ToInt32(Console.ReadLine());

            for(int i=2;i< iValue; i++)
            {
                if(iValue%i==0)
                {
                    Console.WriteLine("It Is Not Prime Number");
                    return;
                }
            }
            Console.WriteLine("It is Prime Number");
        }
    }
}
