public class HousekeepingTask
{
    public int TaskId { get; set; }

    public DateTime AssignedDate { get; set; }

    public HousekeepingStatus Status { get; set; }

    public string Notes { get; set; }

    // Room relationship
    public int RoomId { get; set; }
    public Room Room { get; set; }

    // Employee relationship
    public int AssignedToUserId { get; set; }
    public User AssignedTo { get; set; }
}