namespace PlmLibs
{
    public static class GenericLib
    {
        /// <summary>
        /// Turns a Enumerable<T> to a list of it's values 
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static string EnumerableToString<T>(IEnumerable<T> enumerable)
        {
            List<T> list = enumerable.ToList();
            if (list == null)
                return "[Null]";
            if (list.Count == 0)
                return "[Empty]";
            if (list.Count == 1)
                return $"{list[0]}";
            else
                return string.Join(",", list);
        }
        /// <summary>
        /// A pretty way of printing the elapsed time from [start] time to [end] time
        /// </summary>
        /// <param name="start">Starting time</param>
        /// <param name="end">Starting end</param>
        public static void ElapsedTime(DateTime start, DateTime end)
        {
            TimeSpan elapsedTime = end - start;
            Console.WriteLine("Time elapsed:");

            if (elapsedTime.Days > 0)
                Console.WriteLine($"{elapsedTime.Days} days");

            if (elapsedTime.Hours > 0)
                Console.WriteLine($"{elapsedTime.Hours} hours");

            if (elapsedTime.Minutes > 0)
                Console.WriteLine($"{elapsedTime.Minutes} minutes");

            if (elapsedTime.Seconds > 0)
                Console.WriteLine($"{elapsedTime.Seconds} seconds");

            if (elapsedTime.Milliseconds > 0)
                Console.WriteLine($"{elapsedTime.Milliseconds} milliseconds");
        }
    }
}
