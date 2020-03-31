using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace DZ_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Users/Admin/RiderProjects/DZ_2/NewFile1.txt";
            string tasck;
            List<string> list=new List<string>();
            tasck = Console.ReadLine();
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(tasck);
                sw.Close();
            }
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                  list.Add(line);
                }
            }
            File.WriteAllText(path, string.Empty);
            int i = 1;
            for (int j = 0; j <list.Count; j++)
            {
                if (j == 3 - 1)
                    continue;
                Console.WriteLine(i+" "+list[j]);
                i++;
                using (StreamWriter sw1 = new StreamWriter(path, true))
                {
                    sw1.WriteLine(list[j]);
                    sw1.Close();
                }
            }
        }
    }
}