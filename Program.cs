using System;
using System.IO;
using System.Threading.Tasks;

namespace DZ_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Users/Admin/RiderProjects/Program_Todo/NewFile1.txt";
            string tasck;
            tasck = Console.ReadLine();
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(tasck);
            }
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                int i = 1;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(i+" "+line);
                    i++;
                }
            }
        }
    }
}