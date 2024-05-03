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
        /// <summary>
        /// A weird mathemathical function defined in 3Blue1Brown's "Pi hiding in prime regularities" video
        /// </summary>
        /// <param name="n">Any positive integer</param>
        /// <returns> -1 if n is by 3 greater then a multiple of 4
        /// <br></br>  1 if n is by 1 greater then a multiple of 4
        /// <br></br>  0 if the number is even</returns>
        public static int Kai(int n)
        {
            if (n == 0) return 1;
            n = Math.Abs(n);

            double x = (n - 3) / 4d;
            if (Math.Floor(x) == x) return -1;

            double y = (n - 1) / 4d;
            if (Math.Floor(y) == y) return 1;

            return 0;
        }
        /// <summary>
        /// In a grid of points where (x,y) of a point x,y ∈ Z we imagine <br></br>
        /// a circle with radius equal to the square root of n <br></br>
        /// this function returns how many of those points are inside this circle
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int LatticePoints(int n)
        {
            return MathLib.GetAllDivisors(n).Select(Kai).Sum() * 4;
        }
    }
}
