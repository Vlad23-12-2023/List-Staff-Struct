using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListStaffStruct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //создать и заполнить файл, если файла нет
            if (File.Exists(@"C:\Proflist") == false)
            {
                //
                // создать массив из структур
                //

                Console.WriteLine("Введите количество сотрудников :");
                int inputStaff = int.Parse(Console.ReadLine());

                //тело метода 
                string[] Worker = new string[inputStaff]; //массив, который будет сохранен в файл

                var date = new DateTime();
                //Worker[] list = new Worker[7];

                //заполнить элементы от 0 до 6 для каждого сотрудника
                for (int i = 0; i < list.Length; i++)
                {

                    //int inputID;                          //присвоить номер по порядку

                    //string inputDtCreate = date.ToShortTimeString();                 //добавить текущее время создания

                    Console.WriteLine("Введите Ф И О");
                    string inputFIO = Console.ReadLine();

                    Console.WriteLine("Введите возраст");
                    int inputAge = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите рост");
                    int inputHeight = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите дату рождения в формате дд/мм/гггг : ");
                    DateTime inputDateBirth = DateTime.Parse(Console.ReadLine());

                    Console.WriteLine("Введите место рождения");
                    string inputPlaceBirth = Console.ReadLine();

                    //Worker[i] = i.ToString() + "#" + inputDtCreate + "#" + inputFIO + "#" + inputAge.ToString() + "#" + inputHeight.ToString() + inputDateBirth.ToString() + "#" + inputPlaceBirth;

                    //list[i] = new Worker()
                    //{
                    //    ID = i + 1,
                    //    DtCreate = inputDtCreate,
                    //    FIO = inputFIO,
                    //    Age = inputAge,
                    //    Height = inputHeight,
                    //    DateBirth = inputDateBirth,
                    //    PlaceBirth = inputPlaceBirth
                    //};

                    workers[i] = CreateWorker(
                        workers[i].Id = i + 1,
                        workers[i].DtCreate = date,
                        workers[i].FIO = inputFIO,
                        workers[i].Age = inputAge,
                        workers[i].Height = inputHeight,
                        workers[i].DateBirth = inputDateBirth,
                        workers[i].PlaceBirth = inputPlaceBirth
                    );

                }


                //
                // записать массив в файл
                //

                File.WriteAllLines(@"C:\Proflist\Proflist.txt", lines);
            }

            Console.ReadKey();
            //если файл есть, то

            Console.WriteLine($"Выберите действие: показать \nвесь файл - файл, \nэлемент с указанным id - id, \nдиапозон элементов по датам - диапозон, \nудалить элемент с указанным id - удалить id, \nдобавить новый элемент - добавить");
            string name = Console.ReadLine();

            switch (name)
            {
                case "файл":
                    Worker workers = GetAllWorkers();
                    PrintList(workers);    //создать метод
                    break;

                case "id":
                    Console.WriteLine("Ввдите ID сотрудника : ");
                    int workerId = int.Parse(Console.ReadLine());
                    Worker worker = GetWorkerById(workerId);
                    PrintList(worker);    //создать метод
                    break;

                case "диапозон":
                    Console.WriteLine("Ввдите начальную дату поиска : ");
                    DateTime dataF;

                    Console.WriteLine("Ввдите конечную дату поиска : ");
                    DateTime dataT;

                    Worker workers1 = GetWorkersBetweenTwoDates();
                    PrintList(workers1);    //создать метод
                    break;

                case "удалить id":
                    Console.WriteLine("Ввдите ID сотрудника : ");
                    int workerIddel = int.Parse(Console.ReadLine());

                    DeleteWorker(workerIddel);
                    break;

                case "добавить":

                    worker = CreateWorker();
                    AddWorker(worker);
                    break;

                default:
                    break;

            }

        }
    }
}
