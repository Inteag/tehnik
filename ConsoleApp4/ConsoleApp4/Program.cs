using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread myThread = new Thread(func); //Создаем новый объект потока (Thread) 
            myThread.Start(); //запускаем поток 
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Поток 1: " + i);
                Thread.Sleep(0);
            }
            Console.Read(); //Приостановим основной поток 
        }
        static void func()
        {
            Thread myThread2 = new Thread(func2); //Создаем новый объект потока (Thread) 
            myThread2.Start(); //запускаем поток 
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Поток 2: " + i.ToString());
                Thread.Sleep(0);
            }
        }
        static void func2()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Поток 3: " + i.ToString());
                Thread.Sleep(0);
            }
        }

    }
}
