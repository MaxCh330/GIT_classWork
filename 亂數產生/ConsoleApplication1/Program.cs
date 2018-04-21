using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {            
            Random ran = new Random();// 產生亂數物件
            //決定生產亂數的組別數量
            Console.WriteLine("生產亂數的組別數量");
            int times=int.Parse(Console.ReadLine());
            Console.WriteLine("以下是"+ times+"組隨機號碼");
            for (int i = 0; i <= times-1; i++)
            {
                // 將所有號碼放入陣列
                List<int> numberlist = new List<int>();
                for (int a = 1; a <= 42; a++)
                {
                numberlist.Add(a);
                }

                for (int b = 0; b < 6; b++)
                {
                int r = ran.Next(1, numberlist.Count);// 隨機挑選剩下的數字
                Console.Write(numberlist[r]+" ");//顯示
                
                // 從list刪除
                numberlist.RemoveAt(r);
                }
                Console.WriteLine();
            }
        // 完成
        Console.ReadLine();
        }
    }
}
