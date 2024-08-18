using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListStaffStruct
{
    class Repository
    {
        /// <summary>
        /// чтение из файла в массив
        /// </summary>
        /// <returns></returns>
        public Worker[] GetAllWorkers()
        {
            // здесь происходит чтение из файла
            // и возврат массива считанных экземпляров

            //считать файл построчно в массив, каждый элемент которой строка
            string[] lines = File.ReadAllLines(@"C:\Proflist\Proflist.txt");

            Worker[] workers = new Worker[7];

            for (int i=0; i < lines.Length; i++)
            {
                //каждый элемент массива строк разбить на массив слов; длина массива lenght.lines
                string[] words = lines[i].Split(new char[] { '#' });

                //каждый элемент массива слов должен передать значение соответствующему полю структуры               
                workers[i] = new Worker()
                {
                    ID = int.Parse(words[0]),
                    DtCreate = DateTime.Parse(words[1]),
                    FIO = words[2],
                    Age = int.Parse(words[3]),
                    Height = int.Parse(words[4]),
                    DateBirth = DateTime.Parse(words[5]),
                    PlaceBirth = words[6]
                };

            }


            return workers;

        }
        /// <summary>
        /// выделение структуры с указанным id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Worker GetWorkerById(int id)
        {
            // происходит чтение из файла, возвращается Worker
            // с запрашиваемым ID
            Worker worker = new Worker();
            Worker[] workers = GetAllWorkers();
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].ID == id)
                {
                    worker = workers[i];
                    break;
                }
            }

            return worker;
        }

        /// <summary>
        /// удаление структуры с указанным id
        /// </summary>
        /// <param name="id"></param>
        public void DeleteWorker(int id)
        {
            // считывается файл, находится нужный Worker
            // происходит запись в файл всех Worker,
            // кроме удаляемого            

            Worker[] workers = GetAllWorkers();
            string[] lines = new string[workers.Length-1];

            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].ID != id)
                {
                    lines[i] = $"{workers[i].ID}#{workers[i].DtCreate}#{workers[i].FIO}#{workers[i].Age}#{workers[i].Height}#{workers[i].DateBirth}#{workers[i].PlaceBirth}";
                    
                }
            }
            File.WriteAllLines(@"C:\Proflist\Proflist.txt", lines);
        }

        public void AddWorker(Worker worker)
        {
            // присваиваем worker уникальный ID,
            // дописываем нового worker в файл
            Worker[] workers = GetAllWorkers();
            int n = workers.Length + 1;
            Worker[] workers1 = new Worker[n];

            for (int i = 0; i < workers.Length; i++)
            {
                workers1[i] = new Worker()
                {
                    ID = workers[i].ID,
                    DtCreate = workers[i].DtCreate,
                    FIO = workers[i].FIO,
                    Age = workers[i].Age,
                    Height = workers[i].Height,
                    DateBirth = workers[i].DateBirth,
                    PlaceBirth = workers[i].PlaceBirth
                };
                
            }

            Console.WriteLine("Для нового сотрудника ID = " + n);

            // вынести ввод параметров worker в основную программу
            var date = new DateTime();
            //string inputDtCreate = date.ToShortTimeString();                 //добавить текущее время создания
            Console.WriteLine("Дата и время создания записи о новом сотруднике " + date);

            Console.WriteLine("Введите Ф И О");
            string inputFIO = Console.ReadLine();

            Console.WriteLine("Введите возраст");
            int inputAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите рост");
            int inputHeight = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите дату рождения");
            DateTime inputDateBirth = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Введите место рождения");
            string inputPlaceBirth = Console.ReadLine();

            // переприсвоить значение ID

            workers1[n].ID = n;
            workers1[n].DtCreate = date;
            workers1[n].FIO = inputFIO;
            workers1[n].Age = inputAge;
            workers1[n].Height = inputHeight;
            workers1[n].DateBirth = inputDateBirth;
            workers1[n].PlaceBirth = inputPlaceBirth;

            string[] lines = new string[workers.Length + 1];

            for (int i = 0; i < workers1.Length; i++)
            {
                lines[i] = $"{workers[i].ID}#{workers[i].DtCreate}#{workers[i].FIO}#{workers[i].Age}#{workers[i].Height}#{workers[i].DateBirth}#{workers[i].PlaceBirth}";

            }
            File.WriteAllLines(@"C:\Proflist\Proflist.txt", lines);


        }

        /// <summary>
        /// фильтрация нужных записей в диапазоне дат
        /// </summary>
        /// <param name="dateFrom"></param>
        /// <param name="dateTo"></param>
        /// <returns></returns>
        public Worker[] GetWorkersBetweenTwoDates(DateTime dateFrom, DateTime dateTo)
        {
            // здесь происходит чтение из файла
            // фильтрация нужных записей
            // и возврат массива считанных экземпляров
            Worker[] workers = GetAllWorkers();
            int counter = 0;
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].DtCreate > dateFrom && workers[i].DtCreate < dateTo)
                {
                    counter++;
                }
            }

            Worker[] workers1 = new Worker[counter];

            for (int i = 0; i < counter; i++)
            {
                workers1[i] = new Worker()
                {
                    ID = workers[i].ID,
                    DtCreate = workers[i].DtCreate,
                    FIO = workers[i].FIO,
                    Age = workers[i].Age,
                    Height = workers[i].Height,
                    DateBirth = workers[i].DateBirth,
                    PlaceBirth = workers[i].PlaceBirth
                };

            }


            return workers1;
        }
    }
}
