using System.Data;
using System.Data.SqlTypes;
namespace PlmLibs.Generic
{
    public static class Generic
    {
        public static string ListToString(List<int> list)
        {
            if (list == null) return "Null";
            String str = String.Empty;

            if (list.Count == 1)
                str = list[0].ToString();
            else
                foreach (int i in list)
                {
                    str += $"{i.ToString()}, ";
                }

            return str;
        }
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
