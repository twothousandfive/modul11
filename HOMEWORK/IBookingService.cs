namespace HOMEWORK;

public interface IBookingService
{
    bool BookRoom(int hotelId, int userId, string roomType, DateTime checkInDate, DateTime checkOutDate);
    bool CheckRoomAvailability(int hotelId, string roomType, DateTime checkInDate, DateTime checkOutDate);
}

public class BookingService : IBookingService
{
    public bool BookRoom(int hotelId, int userId, string roomType, DateTime checkInDate, DateTime checkOutDate)
    {
        // Логика бронирования номера
        return true; // Пример успешного бронирования
    }

    public bool CheckRoomAvailability(int hotelId, string roomType, DateTime checkInDate, DateTime checkOutDate)
    {
        // Логика проверки доступности
        return true; // Пример доступности
    }
}
