namespace PlmLibs
{
    public static class TupleLib
    {
        #region INTEGER CONVERSION
        /// <summary>
        /// Converts a string[] arrayay into Tuple(int, int)
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        /// <returns></returns>
        public static (int, int) ToInt2(string[] array)
        {
            var list = array.ToList().Select(int.Parse).ToList();
            return (list[0], list[1]);
        }
        /// <summary>
        /// Converts a string[] arrayay into Tuple(int, int, int)
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static (int, int, int) ToInt3(string[] array)
        {
            var list = array.ToList().Select(int.Parse).ToList();
            return (list[0], list[1], list[2]);
        }
        /// <summary>
        /// Converts a string[] arrayay into Tuple(int, int, int, int)
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static (int, int, int, int) ToInt4(string[] array)
        {
            var list = array.ToList().Select(int.Parse).ToList();
            return (list[0], list[1], list[2], list[3]);
        }
        /// <summary>
        /// Converts a string[] arrayay into Tuple(int, int, int, int, int)
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static (int, int, int, int, int) ToInt5(string[] array)
        {
            var list = array.ToList().Select(int.Parse).ToList();
            return (list[0], list[1], list[2], list[3], list[4]);
        }
        #endregion

        #region INTEGER SEPARATION
        /// <summary>
        /// Converts a int[] arrayay into a Tuple(int, int)
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static (int, int) Int2(int[] array) => (array[0], array[1]);
        /// <summary>
        /// Converts a int[] arrayay into a Tuple(int, int, int)
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static (int, int, int) Int3(int[] array) => (array[0], array[1], array[2]);
        /// <summary>
        /// Converts a int[] arrayay into a Tuple(int, int, int, int)
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static (int, int, int, int) Int4(int[] array) => (array[0], array[1], array[2], array[3]);
        /// <summary>
        /// Converts a int[] arrayay into a Tuple(int, int, int, int, int)
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static (int, int, int, int, int) Int5(int[] array) => (array[0], array[1], array[2], array[3], array[4]);
        #endregion

        #region FLOAT CONVERSION
        /// <summary>
        /// Converts a string[] into Tuple(float, float)
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static (float, float) ToFloat2(string[] array)
        {
            var list = array.ToList().Select(float.Parse).ToList();
            return (list[0], list[1]);
        }
        /// <summary>
        /// Converts a string[] into Tuple(float, float, float)
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static (float, float, float) ToFloat3(string[] array)
        {
            var list = array.ToList().Select(float.Parse).ToList();
            return (list[0], list[1], list[2]);
        }
        /// <summary>
        /// Converts a string[] into Tuple(float, float, float, float)
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static (float, float, float, float) ToFloat4(string[] array)
        {
            var list = array.ToList().Select(float.Parse).ToList();
            return (list[0], list[1], list[2], list[3]);
        }
        /// <summary>
        /// Converts a string[] into Tuple(float, float, float, float, float)
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static (float, float, float, float, float) ToFloat5(string[] array)
        {
            var list = array.ToList().Select(float.Parse).ToList();
            return (list[0], list[1], list[2], list[3], list[4]);
        }
        #endregion

        #region FLOAT SEPARATION
        /// <summary>
        /// Converts a float[] into Tuple(float, float)
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static (float, float) Float2(float[] array) => (array[0], array[1]);
        /// <summary>
        /// Converts a float[] into Tuple(float, float, float)
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static (float, float, float) Float3(float[] array) => (array[0], array[1], array[2]);
        /// <summary>
        /// Converts a float[] into Tuple(float, float, float, float)
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static (float, float, float, float) Float4(float[] array) => (array[0], array[1], array[2], array[3]);
        /// <summary>
        /// Converts a float[] into Tuple(float, float, float, float, float)
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static (float, float, float, float, float) Float5(float[] array) => (array[0], array[1], array[2], array[3], array[4]);
        #endregion

        #region DOUBLE CONVERSION
        /// <summary>
        /// Converts a string[] into Tuple(double, double)
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static (double, double) ToDouble2(string[] array)
        {
            var list = array.ToList().Select(double.Parse).ToList();
            return (list[0], list[1]);
        }
        /// <summary>
        /// Converts a string[] into Tuple(double, double, double)
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static (double, double, double) ToDouble3(string[] array)
        {
            var list = array.ToList().Select(double.Parse).ToList();
            return (list[0], list[1], list[2]);
        }
        /// <summary>
        /// Converts a string[] into Tuple(double, double, double, double)
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static (double, double, double, double) ToDouble4(string[] array)
        {
            var list = array.ToList().Select(double.Parse).ToList();
            return (list[0], list[1], list[2], list[3]);
        }
        /// <summary>
        /// Converts a string[] into Tuple(double, double, double, double, double)
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static (double, double, double, double, double) ToDouble5(string[] array)
        {
            var list = array.ToList().Select(double.Parse).ToList();
            return (list[0], list[1], list[2], list[3], list[4]);
        }
        #endregion

        #region DOUBLE SEPARATION
        /// <summary>
        /// Converts a double[] into Tuple(double, double)
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static (double, double) Double2(double[] array) => (array[0], array[1]);
        /// <summary>
        /// Converts a double[] into Tuple(double, double, double)
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static (double, double, double) Double3(double[] array) => (array[0], array[1], array[2]);
        /// <summary>
        /// Converts a double[] into Tuple(double, double, double, double)
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static (double, double, double, double) Double4(double[] array) => (array[0], array[1], array[2], array[3]);
        /// <summary>
        /// Converts a double[] into Tuple(double, double, double, double, double)
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static (double, double, double, double, double) Double5(double[] array) => (array[0], array[1], array[2], array[3], array[4]);
        #endregion

        #region DECIMAL CONVERSION
        /// <summary>
        /// Converts a string[] into Tuple(decimal, decimal)
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static (decimal, decimal) ToDecimal2(string[] array)
        {
            var list = array.ToList().Select(decimal.Parse).ToList();
            return (list[0], list[1]);
        }
        /// <summary>
        /// Converts a string[] into Tuple(decimal, decimal, decimal)
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static (decimal, decimal, decimal) ToDecimal3(string[] array)
        {
            var list = array.ToList().Select(decimal.Parse).ToList();
            return (list[0], list[1], list[2]);
        }
        /// <summary>
        /// Converts a string[] into Tuple(decimal, decimal, decimal, decimal)
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static (decimal, decimal, decimal, decimal) ToDecimal41(string[] array)
        {
            var list = array.ToList().Select(decimal.Parse).ToList();
            return (list[0], list[1], list[2], list[3]);
        }
        /// <summary>
        /// Converts a string[] into Tuple(decimal, decimal, decimal, decimal, decimal)
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static (decimal, decimal, decimal, decimal, decimal) ToDecimal5(string[] array)
        {
            var list = array.ToList().Select(decimal.Parse).ToList();
            return (list[0], list[1], list[2], list[3], list[4]);
        }
        #endregion

        #region DECIMAL SEPARATION
        /// <summary>
        /// Converts a decimal[] into Tuple(decimal, decimal) 
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static (decimal, decimal) Decimal2(decimal[] array) => (array[0], array[1]);
        /// <summary>
        /// Converts a decimal[] into Tuple(decimal, decimal, decimal) 
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static (decimal, decimal, decimal) Decimal3(decimal[] array) => (array[0], array[1], array[2]);
        /// <summary>
        /// Converts a decimal[] into Tuple(decimal, decimal, decimal, decimal) 
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static (decimal, decimal, decimal, decimal) Decimal4(decimal[] array) => (array[0], array[1], array[2], array[3]);
        /// <summary>
        /// Converts a decimal[] into Tuple(decimal, decimal, decimal, decimal, decimal) 
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static (decimal, decimal, decimal, decimal, decimal) Decimal5(decimal[] array) => (array[0], array[1], array[2], array[3], array[4]);
        #endregion

        #region STRING CONVERSION
        /// <summary>
        /// Converts a object[] into Tuple(string, string)
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static (string, string) ToString2(object[] array) => ($"{array[0]}", $"{array[1]}");
        /// <summary>
        /// Converts a object[] into Tuple(string, string, string)
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static (string, string, string) ToString3(object[] array) => ($"{array[0]}", $"{array[1]}", $"{array[2]}");
        /// <summary>
        /// Converts a object[] into Tuple(string, string, string, string)
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static (string, string, string, string) ToString4(object[] array) => ($"{array[0]}", $"{array[1]}", $"{array[2]}", $"{array[3]}");
        /// <summary>
        /// Converts a object[] into Tuple(string, string, string, string, string)
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static (string, string, string, string, string) ToString5(object[] array) => ($"{array[0]}", $"{array[1]}", $"{array[2]}", $"{array[3]}", $"{array[4]}");
        #endregion

        #region STRING SEPARATION   
        /// <summary>
        /// Converts a string[] into Tuple(string, string)
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static (string, string) String2(string[] array) => (array[0], array[1]);
        /// <summary>
        /// Converts a string[] into Tuple(string, string, string)
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static (string, string, string) String3(string[] array) => (array[0], array[1], array[2]);
        /// <summary>
        /// Converts a string[] into Tuple(string, string, string, string)
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static (string, string, string, string) String4(string[] array) => (array[0], array[1], array[2], array[3]);
        /// <summary>
        /// Converts a string[] into Tuple(string, string, string, string, string)
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static (string, string, string, string, string) String5(string[] array) => (array[0], array[1], array[2], array[3], array[4]);
        #endregion
    }
}
