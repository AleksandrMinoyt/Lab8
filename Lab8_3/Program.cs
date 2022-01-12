using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "Text.txt";

            int simbol = 0;
            int word = 0;
            int row = 0;

            using (StreamReader sr = new StreamReader(path))
            {

                while (!sr.EndOfStream)
                {
                    string st = sr.ReadLine();
                    row++;

                    string[] arrayString = st.Split();
                    word += arrayString.Length;
                    simbol += st.Length;                 

                }
            }

            Console.WriteLine("Строк={0}, Слов={1}, Символов={2}", row, word, simbol);
            Console.ReadKey();
        }
    }
}
