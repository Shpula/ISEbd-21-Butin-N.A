using System;
namespace WindowsFormsCars
{
    /// <summary>
    /// Класс-ошибка "Если на парковке уже заняты все места"
    /// </summary>
    public class ParkingOverflowException : ArgumentOutOfRangeException
    { 
        
        public ParkingOverflowException() : base("На парковке нет свободных мест")
        { }
    }
}