using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListStaffStruct
{
    public struct Worker
    {
        /// <summary>
        /// Номер по ведомости
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Дата и время создания записи
        /// </summary>
        public DateTime DtCreate { get; set; }

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
        public DateTime DateBirth { get; set; }

        /// <summary>
        /// Место рождения
        /// </summary>
        public string PlaceBirth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dtCreate"></param>
        /// <param name="fio"></param>
        /// <param name="age"></param>
        /// <param name="height"></param>
        /// <param name="dateBirth"></param>
        /// <param name="placeBirth"></param>
        
        public Worker(int id, DateTime dtCreate, string fio, int age, int height, DateTime dateBirth, string placeBirth)
        {
            this.ID = id;
            this.DtCreate = dtCreate;
            this.FIO = fio;
            this.Age = age;
            this.Height = height;
            this.DateBirth = dateBirth;
            this.PlaceBirth = placeBirth;
        }

        public Worker(int id) :
            this(DtCreate, FIO, Age, Height, DateBirth, PlaceBirth)
        {

        }

        public Worker CreateWorker(int id, DateTime dtCreate, string fio, int age, int height, DateTime dateBirth, string placeBirth)
        {
            return new Worker()
            {
                id = id,
                DtCreate = dtCreate,
                FIO = fio,
                Age = age,
                Height = height,
                DateBirth = dateBirth,
                PlaceBirth = placeBirth
            };
        }
    }
}
