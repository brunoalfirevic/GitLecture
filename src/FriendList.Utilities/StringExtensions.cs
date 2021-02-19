using System;

namespace FriendList.Utilities
{
    public static class StringExtensions
    {
        public static string ReplaceAt(this string str, string replacement, int startIndex, int count)
        {
            return str.Remove(startIndex, count).Insert(startIndex, replacement);
        }

        public static string Reverse(this string str)
        {
            var charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
