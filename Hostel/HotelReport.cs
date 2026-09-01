public class HotelReport
{
    public string HotelName { get; set; }

    public int TotalRooms { get; set; }

    public int OccupiedRooms { get; set; }

    public int VacantRooms { get; set; }

    public int CleaningRooms { get; set; }

    public decimal TotalRevenue { get; set; }

    public double OccupancyPercentage { get; set; }
}