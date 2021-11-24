using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPO
{
    class Program
    {
        static void Main(string[] args)
        {
            string writePath = @"E:\testCommit.txt";
            string hello = "Hello World!";
            string text = "My name is Dastan Urazov"; 
            Random random = new Random();
            int number = random.Next(0,100);
            try
            {
                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(text);
                    sw.WriteLine(hello);
                    sw.WriteLine(number);
                    Console.WriteLine(hello);
                    Console.WriteLine(number);
                }
                Console.WriteLine("Запись выполнена");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
