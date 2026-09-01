public class Guest
{
    public int GuestId { get; set; }

    public string Name { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Country { get; set; }

    // Relationship
    public List<Booking> Bookings { get; set; } = new();
}