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
                    "\nIf you want to exit print 'exit'\n" +
                    "If you want to open remaimder print 'rem' ");
                string add = Console.ReadLine();
                if (add == "rem")
                    Test();
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

        public static void CreateList()
        {
            
        }

        public static void Test()
        {
            bool tumbler2 = true;
            string path2 = "C:/Users/Admin/RiderProjects/DZ_2/NewFile2.txt";
            string tasck;
            DateTime thisDay = DateTime.Today;
            string day = thisDay.ToString("d");
            List<string> list2 = new List<string>();
            List<string> list3 = new List<string>();
            while (tumbler2)
            {
                Console.WriteLine(
                    "If you want to add new tasck print 'add' " +
                    "\nIf you wont to delete your taskk print 'delete'" +
                    "\nIf you want to exit print 'exit'\n");
                string add = Console.ReadLine();
                if (add == "exit")
                    tumbler2 = false;
                if (add == "add")
                {
                    using (StreamReader sr = new StreamReader(path2))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            list2.Add(line);
                        }
                    }

                    Console.WriteLine("Remaind for today");
                    for (int i = 0; i < list2.Count; i++)
                    {
                        if (list2[i] == day)
                        {
                            Console.WriteLine(" " + list2[i - 1]);
                            list3.Add(list2[i - 1]);
                            list3.Add(list2[i]);
                            list2.Remove(list2[i - 1]);
                            list2.Remove(list2[i]);
                        }
                    }

                    Console.WriteLine("input your tasck");
                    tasck = Console.ReadLine();
                    using (StreamWriter sw = new StreamWriter(path2, true))
                    {
                        sw.WriteLine(tasck);
                    }

                    Console.WriteLine("input your data");
                    tasck = Console.ReadLine();
                    using (StreamWriter sw = new StreamWriter(path2, true))
                    {
                        sw.WriteLine(tasck);
                    }

                    using (StreamReader sr = new StreamReader(path2))
                    {
                        string line;
                        list2.Add("tasck");
                        list2.Add("tasck");
                        int k = 1;
                        while ((line = sr.ReadLine()) != null)
                        {
                            list2[k - 1] = line;
                            k++;
                        }
                    }
                }

                if (add == "delete")
                {

                    Console.WriteLine("Print the number of tasck");
                    int number = Convert.ToInt32(Console.ReadLine());
                    File.WriteAllText(path2, string.Empty);
                    list2.Remove(list2[number - 1]);
                    list2.Remove(list2[number - 2]);
                    File.AppendAllText(path2, "");
                    for (int j = 0; j < list2.Count; j++)
                    {

                        using (StreamWriter sw = new StreamWriter(path2, true))
                        {
                            sw.WriteLine(list2[j]);
                        }
                    }

                    for (int j = 0; j < list3.Count; j++)
                    {

                        using (StreamWriter sw = new StreamWriter(path2, true))
                        {
                            sw.WriteLine(list3[j]);
                        }
                    }
                }
            }
        }
    }
    }
