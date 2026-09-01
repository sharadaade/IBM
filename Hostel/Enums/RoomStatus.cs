public enum RoomStatus
{
    Vacant,
    Occupied,
    UnderCleaning,
    Maintenance,
    Reserved
}

public enum RoomType
{
    Single,
    Double,
    Deluxe,
    Suite,
    Presidential
}

public enum HousekeepingStatus
{
    Pending,
    InProgress,
    Completed
}

public enum BookingStatus
{
    Confirmed,
    CheckedIn,
    CheckedOut,
    Cancelled
}

public enum PaymentStatus
{
    Pending,
    Paid,
    Refunded
}

public enum UserRole
{
    Admin,
    Manager,
    Receptionist,
    Housekeeping,
    Accountant
}