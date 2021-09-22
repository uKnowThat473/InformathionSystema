using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformathionSystem
{
    class Worker
    {
        public Worker(int Id, string Name,string LastName, int Deportament, int Age,int Salary,int Progect)
        {
            this.Id = Id;
            this.Name = Name;
            this.LastName = LastName;
            this.Deportament = Deportament;
            this.Age = Age;
            this.Salary = Salary;
            this.Progect = Progect;
        }

        /// <summary>
        /// Вывод сотрудников
        /// </summary>
        /// <param name="worker">Список сотрудников на вывод</param>
        static void PrintWorkers(Worker worker)
        {
            worker.Print();
        }
        /// <summary>
        /// Редактор сотрудников
        /// </summary>
        /// <param name="worker">Сотрудник которого надо отредактировать</param>
        /// <returns></returns>
        static public Worker WorkerRedact(ref Worker worker) 
        {
            Console.WriteLine("\tСтарые данные:");
            worker.Print();
            Console.WriteLine();
            Console.WriteLine("\tВведиет новые данные");
            Console.Write("Введите новое имя сотрудника: ");
            worker.Name = Console.ReadLine();
            Console.Write("Введиет новую фамилию сотружника: ");
            worker.LastName = Console.ReadLine();
            Console.Write("Введите возраст сотрудника: ");
            worker.Age = int.Parse(Console.ReadLine());
            Console.Write("Введите зарплату сотрудника: ");
            worker.Salary = int.Parse(Console.ReadLine());
            Console.Write("Введите колличество проектов сотрудника: ");
            worker.Progect = int.Parse(Console.ReadLine());
            return worker;
        }
        /// <summary>
        /// Вывод сотрудника
        /// </summary>
        public void Print() 
        {
            Console.WriteLine($"{this.Id,2}{this.Name,10}{this.LastName,18}{this.Age,12}{"",9}Отдел_{this.Deportament}{this.Salary,14}{this.Progect,11}");
        }
        #region Поля
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Deportament { get; set; }
        public int Age { get; set; }
        public int Id { get; set; }
        public int Salary { get; set; }
        public int Progect { get; set; }
        #endregion
    }
}
