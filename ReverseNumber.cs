using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class ReverseNumber
    {
       public void getReverseNumber()
        {
            Console.WriteLine("Enter Number for Reverse ");
            int iValue = Convert.ToInt32(Console.ReadLine()); //123

            int i = 0, iRev = 0, iRemainder = 0;
            while (iValue > 0)
            {
                iRemainder = iValue % 10;//  3  2
                iRev = (iRev * 10) + iRemainder;//  13    
                iValue /= 10;
            }
            Console.WriteLine(iRev);
        }
    }
}
