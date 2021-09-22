using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using Newtonsoft.Json;

namespace InformathionSystem
{
    struct DeportamenWorkerHand
    {
        public List<Deportament> deportaments;
        public int count;
        public DeportamenWorkerHand(int count)
        {
            deportaments = new List<Deportament>();
            this.count = count;
            
        }
        /// <summary>
        /// Создание нового депортамента
        /// </summary>
        /// <param name="Name">Имя депортамента</param>
        /// <param name="data">время создания депортамента</param>
        /// <param name="QuantityWorker">Колличество работников</param>
        public void AddDeports(string Name,DateTime data,int QuantityWorker) 
        {
            
            deportaments.Add(new Deportament(Name, data, QuantityWorker,count));
            
            count++;
        }
        /// <summary>
        /// Выводит всю информацию о депортаментах и сотрудниках
        /// </summary>
        public void PrintFullInfoDeports() 
        {
            Console.Clear();
            Console.WriteLine("1 - вывести информацию о всех депортаментах и сотрудниках");
            Console.WriteLine("2 - вывести инфорамцию об отдельном депортаменте");
            int i = int.Parse(Console.ReadLine());
            if (i == 1)
            {
                Console.Clear();
                foreach (var item in deportaments)
                {
                    item.PrintAllInfo();
                }
            }
            else 
            {
                Console.Clear();
                Console.Write("Введите номер депортамента: ");
                int t = int.Parse(Console.ReadLine());
                    t--;
                deportaments[t].PrintAllInfo();
            }
            
        }
        /// <summary>
        /// Выводит всю информацию о депортаментах без сотрудников
        /// </summary>
        public void PrintAllDeports() 
        {
            Console.WriteLine("\t\tИнформация о депортаментах");
            foreach (var item in deportaments)
            {
                item.PrintDeports();
                Console.WriteLine("-----------------------------------------");
            }
        }
        /// <summary>
        /// Выводит информацию о всех сотрудниках во всех депортаментах
        /// </summary>
        public void PrintAllWorker() 
        {
            List<Worker> workers = new List<Worker>();
            foreach (var item in deportaments)
            {
                foreach (var item2 in item.workers)
                {
                    workers.Add(item2);
                }
                
            }
            int id = 0;
            foreach (var item in workers)
            {
                item.Print();
                id++;
            }
            Console.WriteLine($"\nОбщее колличество сотрудников во всех депортаментах: {id}");
        }
        /// <summary>
        /// Редактирование депортамента
        /// </summary>
        public void RedactDeport() 
        {
            Console.Write("Введите номер депортамента который хотите редактировать: ");
            int i = int.Parse(Console.ReadLine());
            i--;
            Deportament deport = deportaments[i];
            Deportament.DeportRedacter(ref deport);
            deportaments[i] = deport;
                        
        }
        /// <summary>
        /// Редактирование сотрудника
        /// </summary>
        public void RedactWorker() 
        {
            Console.Write("Введиет номер депортамента в котором вы хотите отредактировать сотружника: ");
            int i = int.Parse(Console.ReadLine());
            Console.Write("Введите номер сотрудника которого вы хотите отредоктировать: ");
            int j = int.Parse(Console.ReadLine());

            Worker work = deportaments[i].workers[j];
            Worker.WorkerRedact(ref work);
            deportaments[i].workers[j] = work;
        }
        /// <summary>
        /// Удаление депортамента
        /// </summary>
        public void RemoveDeport() 
        {
            Console.Write("Номер депортамента который вы хотите удалить: ");
            int i = int.Parse(Console.ReadLine());
            deportaments.RemoveAt(--i);
            count--;
        }
        /// <summary>
        /// Удаление работника
        /// </summary>
        public void RemoveWorker() 
        {
            Console.Write("Введите номер депортамента в котором вы хотите удалить сотрудника: ");
            int i = int.Parse(Console.ReadLine());
            Console.Write("Введите номер сотрудника которого хотите удалить: ");
            int j = int.Parse(Console.ReadLine());
            deportaments[--i].workers.RemoveAt(--j);
        }
        /// <summary>
        /// Сортировака сотрудников по зарплате
        /// </summary>
        public void SortWorkerBySalary() 
        {
            Console.Write("Введте номер депортамента в котором вы хотите отсортировать сотрудников: ");
            int i = int.Parse(Console.ReadLine());
            i--;
            deportaments[i].SortedWorkers();
        }
        /// <summary>
        /// Конвертация информиции в Json
        /// </summary>
        public void ConvertToJson() 
        {
            Console.Write("Введите название файла в который хотите сохранить: ");
            string s = Console.ReadLine();
            string json = JsonConvert.SerializeObject(deportaments);
            File.WriteAllText($@"{s}.json", json);
            
        }
        /// <summary>
        /// Считывание данных с файла
        /// </summary>
        public void ReadJson() 
        {
            string json = File.ReadAllText("deport.json");
            deportaments = JsonConvert.DeserializeObject<List<Deportament>>(json);
        }
    }
}
