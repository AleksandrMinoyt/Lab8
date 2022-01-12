using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\test.txt";
            //Console.WriteLine("Введите путь и имя файла");
            //string path = Console.ReadLine();
                          
            using(StreamWriter sw =new StreamWriter(path))
            {
                Random rnd = new Random();
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(rnd.Next(1,100));
                }
            }

            int summ=0;

            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    summ += Convert.ToInt32(sr.ReadLine()); 
                }
            }

            Console.WriteLine("Сумма чисел={0}", summ);
            Console.ReadKey();
        }
    }
}
