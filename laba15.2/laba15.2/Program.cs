using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace laba15._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread myThread = new Thread(func); //Создаем новый объект потока (Thread) 
            myThread.Start(); //запускаем поток 
            string str = "многопоточное";
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine("Поток 1: " + str[i]);
                Thread.Sleep(0);
            }
            Console.Read(); //Приостановим основной поток 
        }
        static void func()
        {
            string str = "программирование";
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine("Поток 2: " + str[i]);
                Thread.Sleep(0);
            }

        }
    }
}
