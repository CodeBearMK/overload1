using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overload1
{
    internal class CMath
    {
        public void GetMax(int num1, int num2)
        {
            if (num1 > num2)
            {
                Console.WriteLine("{0},{1} 較大值為{1}", num2, num1);
            }
            else
            {
                Console.WriteLine("{0},{1} 較大值為{1}", num1, num2);
            }
        }

        public void GetMax(int[] numAry)
        {
            string outputstr = "";
            Array.Sort(numAry);
            for (int i = 0; i < numAry.Length; i++)
            {
                if (i != numAry.Length - 1)
                {
                    outputstr += numAry[i].ToString() + ",";
                }
                else
                {
                    outputstr += numAry[i].ToString();
                }
                
            }
            Console.WriteLine("{0} 中最大值為 {1}", outputstr, numAry[numAry.Length-1]);
        }
    }
}
