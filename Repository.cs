using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformathionSystem
{
    struct Repository
    {
        public List<Worker> workers;
        public int index;

        public Repository(int index)
        {
            workers = new List<Worker>();
            this.index = index + 1;
        }
        /// <summary>
        /// Создание сотрудников в депортаменте
        /// </summary>
        /// <param name="Count">Колличество сотрудников которе надо создать</param>
        /// <returns></returns>
        public List<Worker> Add(int Count) 
        {
            Random rnd = new Random();
            for (int i = 1; i < index; i++)
            {
                workers.Add(new Worker(i,$"Имя_{i}",$"Фамилия_{i}",Count,rnd.Next(19,35),rnd.Next(5000,10000),3));
            }
            return workers;
        }
        /// <summary>
        /// Вывод всех сотрудников в депортаменте
        /// </summary>
        public void Print() 
        {
            
            foreach (var item in workers)
            {
                item.Print();
            }
        }
    }
}
