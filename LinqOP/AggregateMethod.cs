namespace IBM.LinqOP
{
    internal class AggregateMethod
    {
        static void Main(string[] args)
        {
            string[] fruits = { "apple", "mango", "orange", "passion", "grapes" };

            string longestFruit = fruits.Aggregate("banana",
                                                    (longest, next) =>
                                                     next.Length > longest.Length ? next : longest,
                                                    fruit => fruit.ToUpper());

            Console.WriteLine(longestFruit);
        }
    }
}
