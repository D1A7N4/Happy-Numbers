using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
namespace Happy_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int found = 0;
            int i = 1;
            int H;
            int attempts;
            int sum;
            do
            {
                sum = i;
                attempts = 1;
                do
                {
                    H = sum;
                    sum = 0;
                    for (int j = 0; j < H.ToString().Length; j++)
                    {
                        sum += int.Parse(H.ToString()[j].ToString()) * int.Parse(H.ToString()[j].ToString());
                    }
                    attempts++;
                } while (sum != 1 & attempts != 30);
                if (sum == 1)
                {
                    Console.WriteLine(i);
                    found++;
                }
                i++;
            } while (found < 8);
        }
    }
}