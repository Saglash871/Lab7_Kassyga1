using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Корутины
{
    internal class Program
    {
        public int Time;
      /// <summary>
      /// Просто пишет привет в консоль
      /// </summary>
        public int Random_time()
        {
            Random random = new Random();
            Time = random.Next(1000, 5000);

            return Time;
        }
        /// <summary>
        /// Пишет привет спустя 1000 мс
        /// </summary>
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("HEllo");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Поток при конвеере");

            for(int i = 0;i < 3; i++)
            {
                Console.WriteLine("HEllo");
                Thread.Sleep(1000);
            }
            Console.ReadLine();
        }
    }
}
