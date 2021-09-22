using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformathionSystem
{
    class Program
    {
        /// <summary>
        /// Добавление депортаментов в ручную
        /// </summary>
        /// <param name="deport">Ссылка на созданый экземпляр депортамента</param>
        /// <returns></returns>
        static public DeportamenWorkerHand AddDeports(ref DeportamenWorkerHand deport)
        {
            Console.Clear();
            Console.Write("Введите название депортамента: ");
            string name = Console.ReadLine();
            Console.Write("Введте дату созданя депортамента: ");
            DateTime data = DateTime.Parse(Console.ReadLine());
            Console.Write("Введте колличество сотрудников в депортаменте: ");
            int Count = int.Parse(Console.ReadLine());
            deport.AddDeports(name,data,Count);
            Console.WriteLine($"Депортамент {name} c {Count} сотрудниками добавлен!");
            Console.ReadLine();
            Console.Clear();
            return deport;
        }
        static void Main(string[] args)
        {
            DeportamenWorkerHand deport = new DeportamenWorkerHand(1);
            int count = 0;
            bool cheker = true;
            while (true)
            {
                Console.WriteLine("1 - добавить депортамент");
                Console.WriteLine("2 - вывести список депортаментов");
                Console.WriteLine("3 - вывести список депортаментов с сотрудниками");
                Console.WriteLine("4 - вывести список всех сотрудников со всех депортаментов");
                Console.WriteLine("5 - редоктировать параметры депортаментов");
                Console.WriteLine("6 - редактировать сотрудника в депортаменте");
                Console.WriteLine("7 - удалить депортамент");
                Console.WriteLine("8 - удалить сотрудника из депортамента");
                Console.WriteLine("9 - отсортировать всех сотрудников по оплате труда");
                Console.WriteLine("10 - импортировать всю ифнормацию из файла");
                Console.WriteLine("11 - записать всю информацию в файл");
                int chek = int.Parse(Console.ReadLine());
                if (chek == 1)
                {
                    count++;
                    deport = AddDeports(ref deport);
                    cheker = false;

                }
                else if (chek == 2)
                {
                    if (cheker)
                    {
                        Console.Clear();
                        Console.WriteLine("Остутсвуют депортаменты!");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    Console.Clear();
                    deport.PrintAllDeports();
                    Console.ReadLine();
                    Console.Clear();

                }
                else if (chek == 3)
                {
                    if (cheker)
                    {
                        Console.Clear();
                        Console.WriteLine("Остутсвуют депортаменты!");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    Console.Clear();
                    deport.PrintFullInfoDeports();
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (chek == 4)
                {
                    if (cheker)
                    {
                        Console.Clear();
                        Console.WriteLine("Остутсвуют депортаменты!");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    Console.Clear();
                    deport.PrintAllWorker();
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (chek == 5)
                {
                    if (cheker)
                    {
                        Console.Clear();
                        Console.WriteLine("Остутсвуют депортаменты!");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    Console.Clear();
                    deport.RedactDeport();
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (chek == 6)
                {
                    if (cheker)
                    {
                        Console.Clear();
                        Console.WriteLine("Остутсвуют депортаменты!");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    Console.Clear();
                    deport.RedactWorker();
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (chek == 7)
                {
                    if (cheker)
                    {
                        Console.Clear();
                        Console.WriteLine("Остутсвуют депортаменты!");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    Console.Clear();
                    deport.RemoveDeport();
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (chek == 8)
                {
                    if (cheker)
                    {
                        Console.Clear();
                        Console.WriteLine("Остутсвуют депортаменты!");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    Console.Clear();
                    deport.RemoveWorker();
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (chek == 9)
                {
                    if (cheker)
                    {
                        Console.Clear();
                        Console.WriteLine("Остутсвуют депортаменты!");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    Console.Clear();
                    deport.SortWorkerBySalary();
                    Console.WriteLine("Сотрудники отсортированны!");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (chek == 10) 
                {
                    Console.Clear();
                    deport.ReadJson();
                    Console.WriteLine("Файл успешно имортирован");
                    Console.ReadLine();
                    cheker = false;
                    Console.Clear();
                }
                else if (chek == 11)
                {
                    if (cheker)
                    {
                        Console.Clear();
                        Console.WriteLine("Вы пытаетесь записать пустой файл!");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    deport.ConvertToJson();
                }
                else break;
            }
            
        }
    }
}
