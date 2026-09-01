
namespace IBM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var allHotels = HostelData.Hotels;

            foreach(var hotel in allHotels)
            {
                Console.WriteLine($"Hotel:- {hotel.Name} Location:- {hotel.Address} Rating:- {hotel.StarRating}");
            }
        }
    }
}
