public class User
{
    public int UserId { get; set; }

    public string? Name { get; set; }
    public string? Email { get; set; }

    public UserRole Role { get; set; }

    // Relationship
    public int? HotelId { get; set; }
    public Hotel? Hotel { get; set; }

    // For housekeeping employees
    public List<HousekeepingTask> HousekeepingTasks { get; set; } = new();
}