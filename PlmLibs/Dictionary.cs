﻿using System.Data.SqlTypes;

namespace PlmLibs.Dictionary
{
    public static class Dictionary
    {
        public static Dictionary<T, int> ListToDict<T>(List<T> list)
            where T : INullable
        {
            Dictionary<T, int> dict = new();
            foreach (T key in list)
            {
                if (!dict.ContainsKey(key))
                    dict.Add(key, 1);
                else
                    dict[key] = 1;
            }
            return dict;
        }
        public static bool AllKeyEq<T, U>(Dictionary<T, U> dict, T key)
            where T : INullable
        {
            foreach (T k in dict.Keys)
                if (!k!.Equals(key))
                    return false;
            return true;
        }
        public static bool AllValsEq<T, U>(Dictionary<T, U> dict, U val)
            where T : INullable
        {
            foreach (U v in dict.Values)
                if (!v!.Equals(val))
                    return false;
            return true;
        }
        public static bool AnyKeyEq<T, U>(Dictionary<T, U> dict, T key)
            where T : INullable
        {
            foreach (T k in dict.Keys)
                if (k!.Equals(key))
                    return true;
            return false;
        }
        public static bool AnyValsEq<T, U>(Dictionary<T, U> dict, U val)
            where T : INullable
        {
            foreach (U v in dict.Values)
                if (v!.Equals(val))
                    return true;
            return false;
        }
    }
}
