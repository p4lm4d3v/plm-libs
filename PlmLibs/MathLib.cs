namespace PlmLibs.Mathematics
{
    public static class Mathematics
    {
        public static T MapValue<T>(T value, T from1, T to1, T from2, T to2)
        {
            bool isInt = typeof(T) == typeof(int);
            bool isFloat = typeof(T) == typeof(float);
            bool isDouble = typeof(T) == typeof(double);
            bool isDecimal = typeof(T) == typeof(decimal);
            if (isInt || isFloat || isDouble || isDecimal)
            {
                dynamic dynValue = value!;
                dynamic dynFrom1 = from1!;
                dynamic dynTo1 = to1!;
                dynamic dynFrom2 = from2!;
                dynamic dynTo2 = to2!;
                return (T)(dynFrom2 + (dynValue - dynFrom1) * (dynTo2 - dynFrom2) / (dynTo1 - dynFrom1));
            }
            else
                throw new ArgumentException("Unsupported type. Only int, float, double or decimal are supported.");
        }
        public static uint PowerMod(uint a, uint n, uint mod)
        {
            if (n == 0)
                return 1;
            else if (n % 2 == 0)
            {
                ulong aul = a;
                return PowerMod((uint)((aul * aul) % mod), n / 2, mod);
            }
            else
            {
                ulong aul = a;
                return (uint)((aul * PowerMod(a, n - 1, mod)) % mod);
            }
        }
        public static List<int> GetPrimeDivisord(int n)
        {
            List<int> result = new List<int>();
            for (int b = 2; n > 1; b++)
                if (n % b == 0)
                {
                    while (n % b == 0)
                    {
                        result.Add(b);
                        n /= b;
                    }
                }
            return result;
        }
        public static int PlusMod(int a, int b, int m)
        {
            return ((a % m) + (b % m)) % m;
        }
        public static int MulMod(int a, int b, int m)
        {
            return ((a % m) * (b % m)) % m;
        }
        public static List<int> GetAllDivisors(int n)
        {
            List<int> result = new List<int>();
            for (int i = 1; i <= n / 2; i++)
                if (n % i == 0)
                    result.Add(i);
            return result;
        }
        public static int SumOfAllDivisors(int n)
        {
            return GetAllDivisors(n).Sum();
        }
        public static int ListProduct(List<int> list)
        {
            int product = 1;
            list.ForEach((i) => product *= i);
            return product;
        }
        public static int Nzd(int a, int b)
        {
            while (b > 0)
            {
                int temp = a;
                a = b;
                b = temp % b;
            }
            return a;
        }
        public static bool IsPerfect(int x)
        {
            List<int> delioci = GetAllDivisors(x);
            int zbirDelilaca = delioci.Sum();
            if (x == zbirDelilaca)
                return true;
            return false;
        }
        public static int Nzs(int a, int b)
        {
            return (a / Nzd(a, b)) * b;
        }
        public static bool IsPrime<T>(T num)
        {
            if (num == null)
            {
                Console.WriteLine("Unsupported type!");
                return false;
            }
            if (num!.GetType() == typeof(int))
            {
                int n = int.Parse(num.ToString()!);
                if (n == 1) return false;
                for (int i = 2; i <= System.Math.Sqrt(n); i++)
                    if (n % i == 0)
                        return false;
                return true;
            }
            else if (num.GetType() == typeof(ulong))
            {
                ulong n = ulong.Parse(num.ToString()!);
                if (n == 1) return false;
                for (ulong i = 2; i <= System.Math.Sqrt(n); i++)
                    if (n % i == 0)
                        return false;
                return true;
            }
            else
            {
                Console.WriteLine("Unsupported type!");
                return false;
            }
        }
        public static String AddTwoStrings(String x, String y)
        {
            if (!x.All(char.IsDigit)) throw new Exception("x must contain only digits!");
            if (!y.All(char.IsDigit)) throw new Exception("y must contain only digits!");

            char[] chars1 = x.ToCharArray();
            char[] chars2 = y.ToCharArray();

            int len1 = chars1.Length;
            int len2 = chars2.Length;
            int max_len = System.Math.Max(x.Length, y.Length);
            int diff_len = System.Math.Abs(len1 - len2);

            if (len1 < len2)
            {
                List<char> temp = chars1.ToList();
                for (int i = 0; i < diff_len; i++)
                    temp.Insert(0, '0');
                chars1 = temp.ToArray();
            }
            else if (len1 > len2)
            {
                List<char> temp = chars2.ToList();
                for (int i = 0; i < diff_len; i++)
                    temp.Insert(0, '0');
                chars2 = temp.ToArray();
            }

            char[] chars = new char[max_len];
            int carry = 0;
            for (int i = max_len - 1, j = 0; i >= 0; i--, j++)
            {
                int? first = null;
                int? second = null;

                try
                {
                    first = int.Parse(chars1[i].ToString());
                }
                catch (Exception e) { Console.WriteLine(e.Message); }

                try
                {
                    second = int.Parse(chars2[i].ToString());
                }
                catch (Exception e) { Console.WriteLine(e.Message); }

                if (first != null && second != null)
                {
                    int sum = (int)first + (int)second + carry;
                    carry = 0;
                    if (sum >= 10)
                    {
                        int tens = (int)System.Math.Floor(sum / 10.0);
                        sum -= tens * 10;
                        carry = tens;
                    }
                    char[] c = sum.ToString().ToCharArray();
                    if (c.Length > 1) Console.WriteLine("c = {0}", string.Join("", c)); ;
                    chars[i] = c.First();
                }
            }
            return string.Join("", chars);
        }
    }
}