var hotels = new List<Hotel>
{
    new Hotel
    {
        HotelId = 1,
        Name = "Grand Palace Hotel",
        City = "Hyderabad",
        Address = "Banjara Hills",
        StarRating = 5
    },

    new Hotel
    {
        HotelId = 2,
        Name = "Royal Orchid Hotel",
        City = "Bangalore",
        Address = "MG Road",
        StarRating = 4
    },

    new Hotel
    {
        HotelId = 3,
        Name = "Sea View Resort",
        City = "Goa",
        Address = "Calangute Beach",
        StarRating = 5
    }
};


var rooms = new List<Room>
{
    // Grand Palace - Hyderabad
    new Room
    {
        RoomId = 1,
        RoomNumber = "101",
        Type = RoomType.Single,
        PricePerNight = 2500,
        Status = RoomStatus.Occupied,
        HotelId = 1
    },

    new Room
    {
        RoomId = 2,
        RoomNumber = "102",
        Type = RoomType.Double,
        PricePerNight = 3500,
        Status = RoomStatus.Vacant,
        HotelId = 1
    },

    new Room
    {
        RoomId = 3,
        RoomNumber = "103",
        Type = RoomType.Deluxe,
        PricePerNight = 5000,
        Status = RoomStatus.UnderCleaning,
        HotelId = 1
    },

    new Room
    {
        RoomId = 4,
        RoomNumber = "104",
        Type = RoomType.Deluxe,
        PricePerNight = 5500,
        Status = RoomStatus.Occupied,
        HotelId = 1
    },

    new Room
    {
        RoomId = 5,
        RoomNumber = "105",
        Type = RoomType.Suite,
        PricePerNight = 8000,
        Status = RoomStatus.Reserved,
        HotelId = 1
    },

    new Room
    {
        RoomId = 6,
        RoomNumber = "106",
        Type = RoomType.Single,
        PricePerNight = 2500,
        Status = RoomStatus.Vacant,
        HotelId = 1
    },

    new Room
    {
        RoomId = 7,
        RoomNumber = "201",
        Type = RoomType.Double,
        PricePerNight = 3500,
        Status = RoomStatus.Occupied,
        HotelId = 1
    },

    new Room
    {
        RoomId = 8,
        RoomNumber = "202",
        Type = RoomType.Presidential,
        PricePerNight = 15000,
        Status = RoomStatus.Vacant,
        HotelId = 1
    },

    // Royal Orchid - Bangalore
    new Room
    {
        RoomId = 9,
        RoomNumber = "301",
        Type = RoomType.Single,
        PricePerNight = 2200,
        Status = RoomStatus.Occupied,
        HotelId = 2
    },

    new Room
    {
        RoomId = 10,
        RoomNumber = "302",
        Type = RoomType.Double,
        PricePerNight = 3200,
        Status = RoomStatus.Vacant,
        HotelId = 2
    },

    new Room
    {
        RoomId = 11,
        RoomNumber = "303",
        Type = RoomType.Deluxe,
        PricePerNight = 4800,
        Status = RoomStatus.UnderCleaning,
        HotelId = 2
    },

    new Room
    {
        RoomId = 12,
        RoomNumber = "304",
        Type = RoomType.Deluxe,
        PricePerNight = 5200,
        Status = RoomStatus.Occupied,
        HotelId = 2
    },

    new Room
    {
        RoomId = 13,
        RoomNumber = "305",
        Type = RoomType.Suite,
        PricePerNight = 7500,
        Status = RoomStatus.Vacant,
        HotelId = 2
    },

    new Room
    {
        RoomId = 14,
        RoomNumber = "306",
        Type = RoomType.Single,
        PricePerNight = 2200,
        Status = RoomStatus.Maintenance,
        HotelId = 2
    },

    new Room
    {
        RoomId = 15,
        RoomNumber = "401",
        Type = RoomType.Double,
        PricePerNight = 3200,
        Status = RoomStatus.Occupied,
        HotelId = 2
    },

    new Room
    {
        RoomId = 16,
        RoomNumber = "402",
        Type = RoomType.Suite,
        PricePerNight = 7500,
        Status = RoomStatus.Reserved,
        HotelId = 2
    },

    // Sea View Resort - Goa
    new Room
    {
        RoomId = 17,
        RoomNumber = "501",
        Type = RoomType.Single,
        PricePerNight = 3000,
        Status = RoomStatus.Vacant,
        HotelId = 3
    },

    new Room
    {
        RoomId = 18,
        RoomNumber = "502",
        Type = RoomType.Double,
        PricePerNight = 4500,
        Status = RoomStatus.Occupied,
        HotelId = 3
    },

    new Room
    {
        RoomId = 19,
        RoomNumber = "503",
        Type = RoomType.Deluxe,
        PricePerNight = 6500,
        Status = RoomStatus.UnderCleaning,
        HotelId = 3
    },

    new Room
    {
        RoomId = 20,
        RoomNumber = "504",
        Type = RoomType.Deluxe,
        PricePerNight = 7000,
        Status = RoomStatus.Vacant,
        HotelId = 3
    },

    new Room
    {
        RoomId = 21,
        RoomNumber = "505",
        Type = RoomType.Suite,
        PricePerNight = 10000,
        Status = RoomStatus.Occupied,
        HotelId = 3
    },

    new Room
    {
        RoomId = 22,
        RoomNumber = "506",
        Type = RoomType.Single,
        PricePerNight = 3000,
        Status = RoomStatus.Vacant,
        HotelId = 3
    },

    new Room
    {
        RoomId = 23,
        RoomNumber = "601",
        Type = RoomType.Double,
        PricePerNight = 4500,
        Status = RoomStatus.Reserved,
        HotelId = 3
    },

    new Room
    {
        RoomId = 24,
        RoomNumber = "602",
        Type = RoomType.Presidential,
        PricePerNight = 18000,
        Status = RoomStatus.Occupied,
        HotelId = 3
    }
};


var users = new List<User>
{
    new User
    {
        UserId = 1,
        Name = "Rajesh Kumar",
        Email = "rajesh@grandpalace.com",
        Role = UserRole.Manager,
        HotelId = 1
    },

    new User
    {
        UserId = 2,
        Name = "Priya Sharma",
        Email = "priya@grandpalace.com",
        Role = UserRole.Receptionist,
        HotelId = 1
    },

    new User
    {
        UserId = 3,
        Name = "Ravi Housekeeper",
        Email = "ravi@grandpalace.com",
        Role = UserRole.Housekeeping,
        HotelId = 1
    },

    new User
    {
        UserId = 4,
        Name = "Sunita Housekeeper",
        Email = "sunita@grandpalace.com",
        Role = UserRole.Housekeeping,
        HotelId = 1
    },

    new User
    {
        UserId = 5,
        Name = "Amit Manager",
        Email = "amit@royalorchid.com",
        Role = UserRole.Manager,
        HotelId = 2
    },

    new User
    {
        UserId = 6,
        Name = "Neha Reception",
        Email = "neha@royalorchid.com",
        Role = UserRole.Receptionist,
        HotelId = 2
    },

    new User
    {
        UserId = 7,
        Name = "Mohan Housekeeper",
        Email = "mohan@royalorchid.com",
        Role = UserRole.Housekeeping,
        HotelId = 2
    },

    new User
    {
        UserId = 8,
        Name = "Kiran Housekeeper",
        Email = "kiran@royalorchid.com",
        Role = UserRole.Housekeeping,
        HotelId = 2
    },

    new User
    {
        UserId = 9,
        Name = "Vikram Manager",
        Email = "vikram@seaview.com",
        Role = UserRole.Manager,
        HotelId = 3
    },

    new User
    {
        UserId = 10,
        Name = "Anjali Reception",
        Email = "anjali@seaview.com",
        Role = UserRole.Receptionist,
        HotelId = 3
    },

    new User
    {
        UserId = 11,
        Name = "Ramesh Housekeeper",
        Email = "ramesh@seaview.com",
        Role = UserRole.Housekeeping,
        HotelId = 3
    },

    new User
    {
        UserId = 12,
        Name = "Deepa Housekeeper",
        Email = "deepa@seaview.com",
        Role = UserRole.Housekeeping,
        HotelId = 3
    }
};

var guests = new List<Guest>
{
    new Guest
    {
        GuestId = 1,
        Name = "Arjun Mehta",
        Phone = "9876500001",
        Email = "arjun@gmail.com",
        Country = "India"
    },

    new Guest
    {
        GuestId = 2,
        Name = "Sneha Reddy",
        Phone = "9876500002",
        Email = "sneha@gmail.com",
        Country = "India"
    },

    new Guest
    {
        GuestId = 3,
        Name = "John Smith",
        Phone = "9876500003",
        Email = "john@gmail.com",
        Country = "USA"
    },

    new Guest
    {
        GuestId = 4,
        Name = "David Miller",
        Phone = "9876500004",
        Email = "david@gmail.com",
        Country = "UK"
    },

    new Guest
    {
        GuestId = 5,
        Name = "Rahul Verma",
        Phone = "9876500005",
        Email = "rahul@gmail.com",
        Country = "India"
    },

    new Guest
    {
        GuestId = 6,
        Name = "Kavya Rao",
        Phone = "9876500006",
        Email = "kavya@gmail.com",
        Country = "India"
    },

    new Guest
    {
        GuestId = 7,
        Name = "Michael Brown",
        Phone = "9876500007",
        Email = "michael@gmail.com",
        Country = "USA"
    },

    new Guest
    {
        GuestId = 8,
        Name = "Emma Wilson",
        Phone = "9876500008",
        Email = "emma@gmail.com",
        Country = "UK"
    },

    new Guest
    {
        GuestId = 9,
        Name = "Vivek Shah",
        Phone = "9876500009",
        Email = "vivek@gmail.com",
        Country = "India"
    },

    new Guest
    {
        GuestId = 10,
        Name = "Pooja Singh",
        Phone = "9876500010",
        Email = "pooja@gmail.com",
        Country = "India"
    },

    new Guest
    {
        GuestId = 11,
        Name = "Daniel Garcia",
        Phone = "9876500011",
        Email = "daniel@gmail.com",
        Country = "Spain"
    },

    new Guest
    {
        GuestId = 12,
        Name = "Sophia Martin",
        Phone = "9876500012",
        Email = "sophia@gmail.com",
        Country = "France"
    },

    new Guest
    {
        GuestId = 13,
        Name = "Nikhil Jain",
        Phone = "9876500013",
        Email = "nikhil@gmail.com",
        Country = "India"
    },

    new Guest
    {
        GuestId = 14,
        Name = "Meera Kapoor",
        Phone = "9876500014",
        Email = "meera@gmail.com",
        Country = "India"
    },

    new Guest
    {
        GuestId = 15,
        Name = "Chris Taylor",
        Phone = "9876500015",
        Email = "chris@gmail.com",
        Country = "Canada"
    },

    new Guest
    {
        GuestId = 16,
        Name = "Olivia Jones",
        Phone = "9876500016",
        Email = "olivia@gmail.com",
        Country = "Australia"
    },

    new Guest
    {
        GuestId = 17,
        Name = "Aditya Rao",
        Phone = "9876500017",
        Email = "aditya@gmail.com",
        Country = "India"
    },

    new Guest
    {
        GuestId = 18,
        Name = "Laura White",
        Phone = "9876500018",
        Email = "laura@gmail.com",
        Country = "Germany"
    },

    new Guest
    {
        GuestId = 19,
        Name = "Suresh Patel",
        Phone = "9876500019",
        Email = "suresh@gmail.com",
        Country = "India"
    },

    new Guest
    {
        GuestId = 20,
        Name = "Emily Clark",
        Phone = "9876500020",
        Email = "emily@gmail.com",
        Country = "USA"
    }
};


var bookings = new List<Booking>
{
    new Booking
    {
        BookingId = 1,
        GuestId = 1,
        HotelId = 1,
        RoomId = 1,
        CheckInDate = new DateTime(2026, 8, 25),
        CheckOutDate = new DateTime(2026, 8, 28),
        NumberOfGuests = 2,
        Status = BookingStatus.CheckedOut,
        TotalAmount = 7500
    },

    new Booking
    {
        BookingId = 2,
        GuestId = 2,
        HotelId = 1,
        RoomId = 4,
        CheckInDate = new DateTime(2026, 8, 28),
        CheckOutDate = new DateTime(2026, 9, 2),
        NumberOfGuests = 2,
        Status = BookingStatus.CheckedIn,
        TotalAmount = 27500
    },

    new Booking
    {
        BookingId = 3,
        GuestId = 3,
        HotelId = 1,
        RoomId = 7,
        CheckInDate = new DateTime(2026, 8, 29),
        CheckOutDate = new DateTime(2026, 9, 3),
        NumberOfGuests = 2,
        Status = BookingStatus.CheckedIn,
        TotalAmount = 17500
    },

    new Booking
    {
        BookingId = 4,
        GuestId = 4,
        HotelId = 1,
        RoomId = 5,
        CheckInDate = new DateTime(2026, 9, 5),
        CheckOutDate = new DateTime(2026, 9, 8),
        NumberOfGuests = 3,
        Status = BookingStatus.Confirmed,
        TotalAmount = 24000
    },

    new Booking
    {
        BookingId = 5,
        GuestId = 5,
        HotelId = 2,
        RoomId = 9,
        CheckInDate = new DateTime(2026, 8, 26),
        CheckOutDate = new DateTime(2026, 8, 29),
        NumberOfGuests = 1,
        Status = BookingStatus.CheckedOut,
        TotalAmount = 6600
    },

    new Booking
    {
        BookingId = 6,
        GuestId = 6,
        HotelId = 2,
        RoomId = 12,
        CheckInDate = new DateTime(2026, 8, 29),
        CheckOutDate = new DateTime(2026, 9, 2),
        NumberOfGuests = 2,
        Status = BookingStatus.CheckedIn,
        TotalAmount = 20800
    },

    new Booking
    {
        BookingId = 7,
        GuestId = 7,
        HotelId = 2,
        RoomId = 15,
        CheckInDate = new DateTime(2026, 8, 30),
        CheckOutDate = new DateTime(2026, 9, 3),
        NumberOfGuests = 2,
        Status = BookingStatus.CheckedIn,
        TotalAmount = 12800
    },

    new Booking
    {
        BookingId = 8,
        GuestId = 8,
        HotelId = 2,
        RoomId = 16,
        CheckInDate = new DateTime(2026, 9, 4),
        CheckOutDate = new DateTime(2026, 9, 7),
        NumberOfGuests = 4,
        Status = BookingStatus.Confirmed,
        TotalAmount = 22500
    },

    new Booking
    {
        BookingId = 9,
        GuestId = 9,
        HotelId = 3,
        RoomId = 18,
        CheckInDate = new DateTime(2026, 8, 28),
        CheckOutDate = new DateTime(2026, 9, 2),
        NumberOfGuests = 2,
        Status = BookingStatus.CheckedIn,
        TotalAmount = 22500
    },

    new Booking
    {
        BookingId = 10,
        GuestId = 10,
        HotelId = 3,
        RoomId = 21,
        CheckInDate = new DateTime(2026, 8, 29),
        CheckOutDate = new DateTime(2026, 9, 4),
        NumberOfGuests = 3,
        Status = BookingStatus.CheckedIn,
        TotalAmount = 60000
    },

    new Booking
    {
        BookingId = 11,
        GuestId = 11,
        HotelId = 3,
        RoomId = 24,
        CheckInDate = new DateTime(2026, 8, 30),
        CheckOutDate = new DateTime(2026, 9, 2),
        NumberOfGuests = 4,
        Status = BookingStatus.CheckedIn,
        TotalAmount = 54000
    },

    new Booking
    {
        BookingId = 12,
        GuestId = 12,
        HotelId = 1,
        RoomId = 2,
        CheckInDate = new DateTime(2026, 9, 10),
        CheckOutDate = new DateTime(2026, 9, 12),
        NumberOfGuests = 2,
        Status = BookingStatus.Confirmed,
        TotalAmount = 7000
    },

    new Booking
    {
        BookingId = 13,
        GuestId = 13,
        HotelId = 2,
        RoomId = 10,
        CheckInDate = new DateTime(2026, 9, 5),
        CheckOutDate = new DateTime(2026, 9, 8),
        NumberOfGuests = 2,
        Status = BookingStatus.Confirmed,
        TotalAmount = 9600
    },

    new Booking
    {
        BookingId = 14,
        GuestId = 14,
        HotelId = 3,
        RoomId = 23,
        CheckInDate = new DateTime(2026, 9, 6),
        CheckOutDate = new DateTime(2026, 9, 9),
        NumberOfGuests = 2,
        Status = BookingStatus.Confirmed,
        TotalAmount = 13500
    },

    new Booking
    {
        BookingId = 15,
        GuestId = 15,
        HotelId = 1,
        RoomId = 8,
        CheckInDate = new DateTime(2026, 9, 12),
        CheckOutDate = new DateTime(2026, 9, 15),
        NumberOfGuests = 4,
        Status = BookingStatus.Confirmed,
        TotalAmount = 45000
    },

    new Booking
    {
        BookingId = 16,
        GuestId = 16,
        HotelId = 3,
        RoomId = 20,
        CheckInDate = new DateTime(2026, 9, 3),
        CheckOutDate = new DateTime(2026, 9, 6),
        NumberOfGuests = 2,
        Status = BookingStatus.Confirmed,
        TotalAmount = 21000
    },

    new Booking
    {
        BookingId = 17,
        GuestId = 17,
        HotelId = 2,
        RoomId = 13,
        CheckInDate = new DateTime(2026, 9, 9),
        CheckOutDate = new DateTime(2026, 9, 11),
        NumberOfGuests = 2,
        Status = BookingStatus.Confirmed,
        TotalAmount = 15000
    },

    new Booking
    {
        BookingId = 18,
        GuestId = 18,
        HotelId = 3,
        RoomId = 17,
        CheckInDate = new DateTime(2026, 9, 11),
        CheckOutDate = new DateTime(2026, 9, 13),
        NumberOfGuests = 1,
        Status = BookingStatus.Confirmed,
        TotalAmount = 6000
    },

    new Booking
    {
        BookingId = 19,
        GuestId = 19,
        HotelId = 1,
        RoomId = 6,
        CheckInDate = new DateTime(2026, 9, 15),
        CheckOutDate = new DateTime(2026, 9, 17),
        NumberOfGuests = 1,
        Status = BookingStatus.Confirmed,
        TotalAmount = 5000
    },

    new Booking
    {
        BookingId = 20,
        GuestId = 20,
        HotelId = 2,
        RoomId = 11,
        CheckInDate = new DateTime(2026, 8, 31),
        CheckOutDate = new DateTime(2026, 9, 3),
        NumberOfGuests = 2,
        Status = BookingStatus.CheckedIn,
        TotalAmount = 14400
    }
};


var housekeepingTasks = new List<HousekeepingTask>
{
    new HousekeepingTask
    {
        TaskId = 1,
        RoomId = 3,
        AssignedToUserId = 3,
        AssignedDate = new DateTime(2026, 9, 1),
        Status = HousekeepingStatus.InProgress,
        Notes = "Checkout cleaning"
    },

    new HousekeepingTask
    {
        TaskId = 2,
        RoomId = 11,
        AssignedToUserId = 7,
        AssignedDate = new DateTime(2026, 9, 1),
        Status = HousekeepingStatus.InProgress,
        Notes = "Deep cleaning"
    },

    new HousekeepingTask
    {
        TaskId = 3,
        RoomId = 19,
        AssignedToUserId = 11,
        AssignedDate = new DateTime(2026, 9, 1),
        Status = HousekeepingStatus.Pending,
        Notes = "Guest checkout cleaning"
    },

    new HousekeepingTask
    {
        TaskId = 4,
        RoomId = 1,
        AssignedToUserId = 4,
        AssignedDate = new DateTime(2026, 8, 28),
        Status = HousekeepingStatus.Completed,
        Notes = "Regular cleaning"
    },

    new HousekeepingTask
    {
        TaskId = 5,
        RoomId = 4,
        AssignedToUserId = 3,
        AssignedDate = new DateTime(2026, 8, 28),
        Status = HousekeepingStatus.Completed,
        Notes = "Room cleaning"
    },

    new HousekeepingTask
    {
        TaskId = 6,
        RoomId = 14,
        AssignedToUserId = 8,
        AssignedDate = new DateTime(2026, 9, 1),
        Status = HousekeepingStatus.Completed,
        Notes = "Maintenance cleaning"
    },

    new HousekeepingTask
    {
        TaskId = 7,
        RoomId = 20,
        AssignedToUserId = 12,
        AssignedDate = new DateTime(2026, 8, 31),
        Status = HousekeepingStatus.Completed,
        Notes = "Room cleaning"
    },

    new HousekeepingTask
    {
        TaskId = 8,
        RoomId = 3,
        AssignedToUserId = 4,
        AssignedDate = new DateTime(2026, 9, 1),
        Status = HousekeepingStatus.Pending,
        Notes = "Bathroom inspection"
    }
};

var payments = new List<Payment>
{
    new Payment
    {
        PaymentId = 1,
        BookingId = 1,
        Amount = 7500,
        PaymentDate = new DateTime(2026, 8, 25),
        PaymentMethod = "Card",
        Status = PaymentStatus.Paid
    },

    new Payment
    {
        PaymentId = 2,
        BookingId = 2,
        Amount = 27500,
        PaymentDate = new DateTime(2026, 8, 28),
        PaymentMethod = "UPI",
        Status = PaymentStatus.Paid
    },

    new Payment
    {
        PaymentId = 3,
        BookingId = 3,
        Amount = 17500,
        PaymentDate = new DateTime(2026, 8, 29),
        PaymentMethod = "Cash",
        Status = PaymentStatus.Paid
    },

    new Payment
    {
        PaymentId = 4,
        BookingId = 4,
        Amount = 24000,
        PaymentDate = new DateTime(2026, 8, 30),
        PaymentMethod = "Card",
        Status = PaymentStatus.Paid
    },

    new Payment
    {
        PaymentId = 5,
        BookingId = 5,
        Amount = 6600,
        PaymentDate = new DateTime(2026, 8, 26),
        PaymentMethod = "UPI",
        Status = PaymentStatus.Paid
    },

    new Payment
    {
        PaymentId = 6,
        BookingId = 6,
        Amount = 20800,
        PaymentDate = new DateTime(2026, 8, 29),
        PaymentMethod = "Card",
        Status = PaymentStatus.Paid
    },

    new Payment
    {
        PaymentId = 7,
        BookingId = 7,
        Amount = 12800,
        PaymentDate = new DateTime(2026, 8, 30),
        PaymentMethod = "Cash",
        Status = PaymentStatus.Paid
    },

    new Payment
    {
        PaymentId = 8,
        BookingId = 8,
        Amount = 22500,
        PaymentDate = new DateTime(2026, 9, 1),
        PaymentMethod = "UPI",
        Status = PaymentStatus.Pending
    },

    new Payment
    {
        PaymentId = 9,
        BookingId = 9,
        Amount = 22500,
        PaymentDate = new DateTime(2026, 8, 28),
        PaymentMethod = "Card",
        Status = PaymentStatus.Paid
    },

    new Payment
    {
        PaymentId = 10,
        BookingId = 10,
        Amount = 60000,
        PaymentDate = new DateTime(2026, 8, 29),
        PaymentMethod = "Card",
        Status = PaymentStatus.Paid
    }
};
