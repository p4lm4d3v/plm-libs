namespace Plm.Tuple
{
    public static class Tuple
    {
        #region INTEGER CONVERSION
        /// <summary>
        /// Converts a string[] array into Tuple(int, int)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        /// <returns></returns>
        public static (int, int) ToInt2(string[] arr)
        {
            var list = arr.ToList().Select(int.Parse).ToList();
            return (list[0], list[1]);
        }
        /// <summary>
        /// Converts a string[] array into Tuple(int, int, int)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static (int, int, int) ToInt3(string[] arr)
        {
            var list = arr.ToList().Select(int.Parse).ToList();
            return (list[0], list[1], list[2]);
        }
        /// <summary>
        /// Converts a string[] array into Tuple(int, int, int, int)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static (int, int, int, int) ToInt4(string[] arr)
        {
            var list = arr.ToList().Select(int.Parse).ToList();
            return (list[0], list[1], list[2], list[3]);
        }
        /// <summary>
        /// Converts a string[] array into Tuple(int, int, int, int, int)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static (int, int, int, int, int) ToInt5(string[] arr)
        {
            var list = arr.ToList().Select(int.Parse).ToList();
            return (list[0], list[1], list[2], list[3], list[4]);
        }
        #endregion

        #region INTEGER SEPARATION
        /// <summary>
        /// Converts a int[] array into a Tuple(int, int)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static (int, int) Int2(int[] arr) => (arr[0], arr[1]);
        /// <summary>
        /// Converts a int[] array into a Tuple(int, int, int)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static (int, int, int) Int3(int[] arr) => (arr[0], arr[1], arr[2]);
        /// <summary>
        /// Converts a int[] array into a Tuple(int, int, int, int)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static (int, int, int, int) Int4(int[] arr) => (arr[0], arr[1], arr[2], arr[3]);
        /// <summary>
        /// Converts a int[] array into a Tuple(int, int, int, int, int)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static (int, int, int, int, int) Int5(int[] arr) => (arr[0], arr[1], arr[2], arr[3], arr[4]);
        #endregion

        #region DOUBLE CONVERSION
        /// <summary>
        /// Converts a string[] into Tuple(double, double)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static (double, double) ToDouble2(string[] arr)
        {
            var list = arr.ToList().Select(double.Parse).ToList();
            return (list[0], list[1]);
        }
        /// <summary>
        /// Converts a string[] into Tuple(double, double, double)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static (double, double, double) ToDouble3(string[] arr)
        {
            var list = arr.ToList().Select(double.Parse).ToList();
            return (list[0], list[1], list[2]);
        }
        /// <summary>
        /// Converts a string[] into Tuple(double, double, double, double)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static (double, double, double, double) ToDouble4(string[] arr)
        {
            var list = arr.ToList().Select(double.Parse).ToList();
            return (list[0], list[1], list[2], list[3]);
        }
        /// <summary>
        /// Converts a string[] into Tuple(double, double, double, double, double)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static (double, double, double, double, double) ToDouble5(string[] arr)
        {
            var list = arr.ToList().Select(double.Parse).ToList();
            return (list[0], list[1], list[2], list[3], list[4]);
        }
        #endregion

        #region DOUBLE SEPARATION
        /// <summary>
        /// Converts a double[] into Tuple(double, double)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static (double, double) Double2(double[] arr) => (arr[0], arr[1]);
        /// <summary>
        /// Converts a double[] into Tuple(double, double, double)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static (double, double, double) Double3(double[] arr) => (arr[0], arr[1], arr[2]);
        /// <summary>
        /// Converts a double[] into Tuple(double, double, double, double)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static (double, double, double, double) Double4(double[] arr) => (arr[0], arr[1], arr[2], arr[3]);
        /// <summary>
        /// Converts a double[] into Tuple(double, double, double, double, double)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static (double, double, double, double, double) Double5(double[] arr) => (arr[0], arr[1], arr[2], arr[3], arr[4]);
        #endregion

        #region FLOAT CONVERSION
        /// <summary>
        /// Converts a string[] into Tuple(float, float)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static (float, float) ToFloat2(string[] arr)
        {
            var list = arr.ToList().Select(float.Parse).ToList();
            return (list[0], list[1]);
        }
        /// <summary>
        /// Converts a string[] into Tuple(float, float, float)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static (float, float, float) ToFloat3(string[] arr)
        {
            var list = arr.ToList().Select(float.Parse).ToList();
            return (list[0], list[1], list[2]);
        }
        /// <summary>
        /// Converts a string[] into Tuple(float, float, float, float)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static (float, float, float, float) ToFloat4(string[] arr)
        {
            var list = arr.ToList().Select(float.Parse).ToList();
            return (list[0], list[1], list[2], list[3]);
        }
        /// <summary>
        /// Converts a string[] into Tuple(float, float, float, float, float)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static (float, float, float, float, float) ToFloat5(string[] arr)
        {
            var list = arr.ToList().Select(float.Parse).ToList();
            return (list[0], list[1], list[2], list[3], list[4]);
        }
        #endregion

        #region FLOAT SEPARATION
        /// <summary>
        /// Converts a float[] into Tuple(float, float)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static (float, float) Float2(float[] arr) => (arr[0], arr[1]);
        /// <summary>
        /// Converts a float[] into Tuple(float, float, float)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static (float, float, float) Float3(float[] arr) => (arr[0], arr[1], arr[2]);
        /// <summary>
        /// Converts a float[] into Tuple(float, float, float, float)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static (float, float, float, float) Float4(float[] arr) => (arr[0], arr[1], arr[2], arr[3]);
        /// <summary>
        /// Converts a float[] into Tuple(float, float, float, float, float)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static (float, float, float, float, float) Float5(float[] arr) => (arr[0], arr[1], arr[2], arr[3], arr[4]);
        #endregion

        #region STRING SEPARATION   
        /// <summary>
        /// Converts a string[] into a Tuple(string, string)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static (string, string) String2(string[] arr) => (arr[0], arr[1]);
        /// <summary>
        /// Converts a string[] into a Tuple(string, string, string)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static (string, string, string) String3(string[] arr) => (arr[0], arr[1], arr[2]);
        /// <summary>
        /// Converts a string[] into a Tuple(string, string, string, string)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static (string, string, string, string) String4(string[] arr) => (arr[0], arr[1], arr[2], arr[3]);
        /// <summary>
        /// Converts a string[] into a Tuple(string, string, string, string, string)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static (string, string, string, string, string) String5(string[] arr) => (arr[0], arr[1], arr[2], arr[3], arr[4]);
        #endregion
    }
}
