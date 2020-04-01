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
            bool tumbler = true;
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                int k = 1;
                while ((line = sr.ReadLine()) != null)
                {
                    list.Add(line);
                    Console.WriteLine(k+" "+line);
                    k++;
                }
            }
            while (tumbler)
            {
                Console.WriteLine(
                    "If you want to add new tasck print 'add' " +
                    "\nIf you wont to delete your taskk print 'delete'" +
                    "\nIf you want to exit print 'exit' ");
                string add = Console.ReadLine();
                if (add == "exit")
                    tumbler = false;
                if (add == "add")
                {
                    Console.WriteLine("input your tasck");
                    tasck = Console.ReadLine();
                    using (StreamWriter sw = new StreamWriter(path, true))
                    {
                        sw.WriteLine(tasck);
                    }

                    /*using (StreamReader sr = new StreamReader(path))
                    {
                        string line;
                        int k = 1;
                        while ((line = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(k + " " + line);
                            k++;
                        }
                    }*/
                    using (StreamReader sr = new StreamReader(path))
                    {
                        string line;
                        list.Add("tasck");
                        int k = 1;
                        while ((line = sr.ReadLine()) != null)
                        {
                            list[k - 1] = line;
                            Console.WriteLine(k + " " + line);
                            k++;
                        }
                    }
                }

                if (add == "delete")
                {
                    Console.WriteLine("Print the number of tasck");
                    int number = Convert.ToInt32(Console.ReadLine());
                    File.WriteAllText(path, string.Empty);
                    list.Remove(list[number - 1]);
                    File.AppendAllText(path, "");
                    for (int j = 0; j < list.Count; j++)
                    {

                        using (StreamWriter sw = new StreamWriter(path, true))
                        {
                            sw.WriteLine(list[j]);
                            Console.WriteLine(j+1+" "+list[j]);
                        }
                    }
                }
            }
        }
    }
}