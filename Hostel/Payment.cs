public class Payment
{
    public int PaymentId { get; set; }

    public decimal Amount { get; set; }

    public DateTime PaymentDate { get; set; }

    public PaymentStatus Status { get; set; }

    public string PaymentMethod { get; set; }

    // Relationship
    public int BookingId { get; set; }
    public Booking Booking { get; set; }
}