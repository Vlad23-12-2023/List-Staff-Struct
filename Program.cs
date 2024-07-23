using System;
using System.Collections.Generic;
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
            Console.WriteLine("Введите количество сотрудников :");
            int inputStaff = int.Parse(Console.ReadLine());

            string[] Worker = new string[inputStaff]; //массив, который будет сохранен в файл

            var date = new DateTime();
            Worker[] list = new Worker[7];
            // заполнить строки массива сотрудников



            //заполнить элементы от 0 до 6 для каждого сотрудника
            for (int i=0; i < list.Length; i++)
            {

                //int inputID;                          //присвоить номер по порядку

                string inputDtCreate = date.ToShortTimeString();                 //добавить текущее время создания

                Console.WriteLine("Введите Ф И О");
                string inputFIO = Console.ReadLine();

                Console.WriteLine("Введите возраст");
                int inputAge = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите рост");
                int inputHeight = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите дату рождения");
                int inputDateBirth = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите место рождения");
                string inputPlaceBirth = Console.ReadLine();

                Worker[i] = i.ToString() + "#" + inputDtCreate + "#" + inputFIO + "#" + inputAge.ToString() + "#" + inputHeight.ToString() + inputDateBirth.ToString() + "#" + inputPlaceBirth;

                list[i] = new Worker()
                {
                    ID = i + 1,
                    DtCreate = inputDtCreate,
                    FIO = inputFIO,
                    Age = inputAge,
                    Height = inputHeight,
                    DateBirth = inputDateBirth,
                    PlaceBirth = inputPlaceBirth
                };

            }

            Console.ReadKey();
            //если файл есть, то
            //открыть для просмотра: либо весь файл,
            //                       либо отдельную запись по параметру,
            //                       либо определенный диапозон записей из файла

            //отсортировать записи по параметру

            //добавить запись и перезаписать файл

            //изменить запись и перезаписать файл

        }
    }
}
