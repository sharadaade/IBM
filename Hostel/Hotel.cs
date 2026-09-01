public class Hotel
{
    public int HotelId { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
    public string Address { get; set; }
    public int StarRating { get; set; }

    // Relationships
    public List<Room> Rooms { get; set; } = new();
    public List<User> Users { get; set; } = new();
    public List<Booking> Bookings { get; set; } = new();
}