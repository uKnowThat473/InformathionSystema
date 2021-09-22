using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformathionSystem
{
    class Deportament
    {
        
        public List<Worker> workers;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="Name">Имя депортамента</param>
        /// <param name="Date">Дата создания</param>
        /// <param name="QuantityWorker">Колличество работников</param>
        /// <param name="Count">коллисчество проектов</param>
        public Deportament(string Name,DateTime Date,int QuantityWorker,int Count)
        {
            this.Name = Name;
            this.Date = Date;
            this.QuantityWorker = QuantityWorker;
            this.Count = Count;
            Repository rep = new Repository(QuantityWorker);
            workers = new List<Worker>();
            workers = (rep.Add(this.Count));
        }
        public Deportament(){ }
        
        /// <summary>
        /// Выводит всю ифнормацию о депортаменте и сотрудниках
        /// </summary>
        public void PrintAllInfo() 
        {
            Console.WriteLine("\t\tИнформация об организации");
            Console.WriteLine($"Название: {this.Name}");
            Console.WriteLine($"Дата создания: {this.Date.ToShortDateString()}");
            Console.WriteLine($"Колличесвто сотрудников: {this.QuantityWorker}");
            Console.WriteLine($"\n\t\t\tИнформация о сотрудниках\n");
            Console.WriteLine($"Id{"",5} Имя{"",10} Фамилия{"",5} Возраст{"",5} Депортамент{"",5}Зарплата{"",5}Проекты");
            foreach (var item in workers)
            {
                
                item.Print();
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        /// <summary>
        /// Выводит информацию о всех депортаментах
        /// </summary>
        public void PrintDeports() 
        {
            
            Console.WriteLine($"Название депортамента: {this.Name}");
            Console.WriteLine($"Дата создания: {this.Date.ToShortDateString()}");
            Console.WriteLine($"Колличество сотрудников: {this.QuantityWorker}");
        }
        /// <summary>
        /// Выводит всех работников из всех депортаментов
        /// </summary>
        public void PrintAllWorker() 
        {
            Console.WriteLine($"Id{"",5} Имя{"",10} Фамилия{"",5} Возраст{"",5} Депортамент{"",5}Зарплата{"",5}Проекты");
            foreach (var item in workers)
            {
                
                item.Print();
            }
        }
        /// <summary>
        /// Редактирование депортамента
        /// </summary>
        /// <param name="deport">Ссылку на депортамент который нужно отредоктировать</param>
        /// <returns></returns>
        static public Deportament DeportRedacter(ref Deportament deport)
        {
            Console.WriteLine("\tСтарые данные депортамента");
            deport.PrintDeports();
            Console.WriteLine();
            Console.Write("Введите новое имя: ");
            deport.Name = Console.ReadLine();
            Console.Write("Введите новую дату создания депортамента: ");
            deport.Date = DateTime.Parse(Console.ReadLine());
            Console.Write("Введите новое колличество сотрудников: ");
            deport.QuantityWorker = int.Parse(Console.ReadLine());
            Repository rep = new Repository(deport.QuantityWorker);
            deport.workers = (rep.Add(deport.QuantityWorker));
            return deport;
            
        }
        /// <summary>
        /// Сортировка работников по зарплате
        /// </summary>
        public void SortedWorkers() 
        {
            var SortBySalary = from u in workers
                               orderby u.Salary
                               select u;
            int count = 0;
            foreach (var item in SortBySalary)
            {
                    workers[count] = item;
                    count++;
            }
        }

        #region Поля
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int QuantityWorker { get; set; }
        public int Count { get; set; }
        #endregion
    }
}
