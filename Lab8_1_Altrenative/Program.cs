using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab8_1_Altrenative
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Windows\Globalization";
            //Console.WriteLine("Введите путь к каталогу");
            //string path = Console.ReadLine();
            //string path = @"D:\Мои документы";
            GetSubDirectory(new DirectoryInfo(path));

            Console.ReadKey();
        }

        static void GetSubDirectory(DirectoryInfo di, int nest = 0)
        {
            foreach (DirectoryInfo subDir in di.GetDirectories())
            {
                string pref = new string(' ', nest * 4);
                Console.WriteLine(pref + subDir.Name.ToUpper());

                foreach (FileInfo file in subDir.GetFiles())
                {
                    Console.WriteLine(pref+"|   " + file.Name.ToLower());
                }

                GetSubDirectory(subDir, nest + 1);
            }


        }


    }
}
