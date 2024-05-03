namespace PlmLibs
{
    public static class ArrayListLib
    {
        public static void PrintEnumerable<T>(IEnumerable<T> enumerable, bool enumerate = false, bool len = false)
        {
            int i = 0;
            foreach (T item in enumerable)
            {
                String t = item.GetType() == typeof(T) && len ? $"{$"{item}".Length}\t " : "";
                String en = enumerate ? $"{i + 1}. " : item.GetType() == typeof(T) && len ? "" : "";
                Console.Write($"{t}{en}{item} ");
                Console.WriteLine();
                i++;
            }
        }
        public static void ShiftListRight<T>(List<T> list)
        {
            if (list.Count > 0)
            {
                T lastItem = list.Last();
                list.RemoveAt(list.Count - 1);
                list.Insert(0, lastItem);
            }
        }
        public static void ShiftListLeft<T>(List<T> list)
        {
            if (list.Count > 0)
            {
                T firstItem = list.First();
                list.RemoveAt(0);
                list.Add(firstItem);
            }
        }
        public static T[] ShiftArrayRight<T>(T[] array)
        {
            if (array.Length > 0)
            {
                T lastElement = array[array.Length - 1];

                for (int i = array.Length - 1; i > 0; i--)
                    array[i] = array[i - 1];

                array[0] = lastElement;
            }
            return array;
        }
        public static T[] ShiftArrayLeft<T>(T[] array)
        {
            if (array.Length > 0)
            {
                T firstElement = array[0];

                for (int i = 0; i < array.Length - 1; i++)
                    array[i] = array[i + 1];

                array[array.Length - 1] = firstElement;

            }
            return array;
        }
        public static T[,] ArrayToSquareMatrix<T>(T[] array)
        {
            double len = (double)array.Length;
            double sqrt = System.Math.Sqrt(len);
            if ((sqrt * sqrt) / len != 1)
                throw new Exception($"Array length must be n*n! Which {len} isn't!");

            T[,] matrix = new T[(int)sqrt, (int)sqrt];

            int index = 0;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    matrix[i, j] = array[index];
                    index++;
                }

            return matrix;
        }

    }
}
