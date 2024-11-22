namespace HOMEWORK;

public interface IHotelService
{
    List<Hotel> SearchHotels(string location, string roomType, decimal priceRange);
    Hotel GetHotelDetails(int hotelId);
}

public class HotelService : IHotelService
{
    public List<Hotel> SearchHotels(string location, string roomType, decimal priceRange)
    {
        // Логика поиска отелей
        return new List<Hotel>
        {
            new Hotel { Id = 1, Name = "Grand Hotel", Location = "New York", Price = 150 },
            new Hotel { Id = 2, Name = "Beach Resort", Location = "Miami", Price = 200 }
        };
    }

    public Hotel GetHotelDetails(int hotelId)
    {
        return new Hotel { Id = hotelId, Name = "Grand Hotel", Location = "New York", Price = 150 };
    }
}

public class Hotel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }
    public decimal Price { get; set; }
}
