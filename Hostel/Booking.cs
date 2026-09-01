
public class Booking
{
    public int BookingId { get; set; }

    public DateTime CheckInDate { get; set; }
    public DateTime CheckOutDate { get; set; }

    public int NumberOfGuests { get; set; }

    public BookingStatus Status { get; set; }

    public decimal TotalAmount { get; set; }

    // Guest relationship
    public int GuestId { get; set; }
    public Guest Guest { get; set; }

    // Hotel relationship
    public int HotelId { get; set; }
    public Hotel Hotel { get; set; }

    // Room relationship
    public int RoomId { get; set; }
    public Room Room { get; set; }

    // Payment relationship
    public Payment Payment { get; set; }
}