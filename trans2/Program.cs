using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trans2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int alt, right=0, num, left, num1, newnum, count1 = 0,count2=0, maxdigit = -1;
            //Console.WriteLine("enter num");
            //num=int.Parse(Console.ReadLine());
            //alt = left = num1 = num;
            //while (alt > 0)
            //{
            //    count1++;
            //    count2++;
            //    if (alt % 10 > maxdigit)
            //    {
            //        maxdigit = alt % 10;
            //    }
            //    alt /= 10;
            //}
            //for (int i = 1; i <= count1; i++)
            //{
            //    if(num%10==maxdigit)
            //    {
            //        right=right+num%10*(int)Math.Pow(10,count2-1);
            //        left=left/(int)Math.Pow(10,i)+left%(int)Math.Pow(10,i-1);
            //        count2--;
            //    }
            //    num /= 10;
            //}
            //newnum = right + left;
            //Console.WriteLine(right);
            //Console.ReadLine();
            int a = 5;
            int t = a++  + ++ a + a;
            Console.WriteLine(t);
            Console.ReadLine();
        }
    }
}
