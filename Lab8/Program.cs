using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\Windows\Globalization";
            //Console.WriteLine("Введите путь к каталогу");
            //string path = Console.ReadLine();

            string[] dir = Directory.GetDirectories(path);

            foreach (string str in dir)
            {
                Console.WriteLine("Папка " + str.Substring(str.LastIndexOf('\\') + 1).ToUpper());
                string[] dirs = Directory.GetDirectories(str);
                foreach (string d in dirs)
                {
                    Console.WriteLine("  Папка " + d.Substring(d.LastIndexOf('\\') + 1).ToUpper());
                }
                string[] files = Directory.GetFiles(str);
                foreach (string file in files)
                {
                    Console.WriteLine("  Файл " + file.Substring(file.LastIndexOf('\\') + 1).ToLower());
                }
            }
            Console.ReadKey();
        }
    }
}
