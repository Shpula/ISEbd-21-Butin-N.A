using System;
namespace WindowsFormsCars
{
    /// <summary>
    /// Класс-ошибка "Если место, на которое хотим поставить автомобиль уже занято"
    /// </summary>
    public class ParkingOccupiedPlaceException : InvalidOperationException
    {
        public ParkingOccupiedPlaceException(int i) : base("На месте " + i + " уже стоит автомобиль")
        { }
    }
}
