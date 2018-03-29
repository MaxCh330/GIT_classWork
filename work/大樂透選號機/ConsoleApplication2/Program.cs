using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            int[] ans = new int[6];
            for (int n = 0; n < 10; n++)
            {
            
                while (ans[0] == ans[1] || ans[0] == ans[2] || ans[0] == ans[3] || ans[1] == ans[2] || ans[1] == ans[3] || ans[2] == ans[3] ||
                    ans[0] == ans[4] || ans[0] == ans[5] || ans[1] == ans[4] || ans[1] == ans[5] || ans[2] == ans[4] || ans[2] == ans[5] || ans[3] == ans[4] || ans[3] == ans[5] || ans[4] == ans[5])
                {
                    for (int i = 0; i < 6; i++)
                    {
                        ans[i] = ran.Next(0, 42);
                    }
                }
                for (int i = 0; i < 6; i++)
                {
                    Console.Write(ans[i] + " ");
                    ans[i] = 0;
                }
                
                Console.WriteLine(" ");
            }
            Console.Read();
            

        }
    }
}
