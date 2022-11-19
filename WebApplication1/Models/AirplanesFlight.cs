namespace WebAppShatohin.Models
{
    public class AirplanesFlight
    {
        public Guid Id { get; set; }
        /// <summary>
        /// Айди
        /// </summary>
        public decimal Numfl { get; set; }
        /// <summary>
        /// Тип самолета
        /// </summary>
        public airplanes TypeAir { get; set; }
        /// <summary>
        /// Время прибытия
        /// </summary>
        public DateTime TimeIn { get; set; }

        public int ColPas { get; set; }
        /// <summary>
        /// Количество пассажиров
        /// </summary>
        public int ColBuil { get; set; }
        /// <summary>
        /// Количество экипажа
        /// </summary>
        public int Pass { get; set; }
        /// <summary>
        /// Сбор на пассажира
        /// </summary>
        public int Build { get; set; }
        /// <summary>
        /// Сбор на экипаж
        /// </summary>
        public int Percent { get; set; }
        /// <summary>
        /// Процент надбавки за обслуживание
        /// </summary>
        public long Result { get; set; }
        /// <summary>
        /// Общая сумма
        /// </summary>
    }
}
