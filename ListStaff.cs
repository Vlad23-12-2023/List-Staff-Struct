using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListStaffStruct
{
    public struct ListStaff
    {
        /// <summary>
        /// Номер по ведомости
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Дата и время создания записи
        /// </summary>
        public string DtCreate { get; set; }

        /// <summary>
        /// ФИО
        /// </summary>
        public string FIO { get; set; }

        /// <summary>
        /// Возраст
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Рост
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Дата рождения
        /// </summary>
        public int DateBirth { get; set; }

        /// <summary>
        /// Место рождения
        /// </summary>
        public string PlaceBirth { get; set; }

        /// <summary>
        /// Конструктор основной
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="DtCreate"></param>
        /// <param name="FIO"></param>
        /// <param name="Age"></param>
        /// <param name="Height"></param>
        /// <param name="DateBirth"></param>
        /// <param name="PlaceBirth"></param>
        public ListStaff(int ID, string DtCreate, string FIO, int Age, int Height, int DateBirth, string PlaceBirth)
        {
            this.ID = ID;
            this.DtCreate = DtCreate;
            this.FIO = FIO;
            this.Age = Age;
            this.Height = Height;
            this.DateBirth = DateBirth;
            this.PlaceBirth = PlaceBirth;
        }

        public ListStaff(int ID, string FIO) :
            this(ID, DtCreate, FIO, Age, Height, DateBirth, PlaceBirth)
        {

        }

        public string StringList()
        {
            return $"";
        }
    }
}
