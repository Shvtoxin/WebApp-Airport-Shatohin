namespace WebAppShatohin.Models
{
    public class FlightesResult
    { 
        public int CountFlight { get; set; }
        ///<summury>
        /// Количество рейсов
        ///</summury>
        public int CountPas { get; set;  }
        ///<summury>
        /// Количество Пассажиров
        ///</summury>
        public int Countcrew { get; set;  }
        ///<summury>
        /// Количество экипажа
        ///</summury>
        public long CountSum { get; set; }
        ///<summury>
        /// Сумма всей выручки
        ///</summury>
    }
}
