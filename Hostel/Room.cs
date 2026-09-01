public class Room
{
    public int RoomId { get; set; }
    public string RoomNumber { get; set; }

    public RoomType Type { get; set; }
    public decimal PricePerNight { get; set; }

    public RoomStatus Status { get; set; }

    // Relationship
    public int HotelId { get; set; }
    public Hotel Hotel { get; set; }

    // Relationships
    public List<Booking> Bookings { get; set; } = new();
    public List<HousekeepingTask> HousekeepingTasks { get; set; } = new();
}