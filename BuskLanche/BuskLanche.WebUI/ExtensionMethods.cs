using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace BuskLanche.WebUI
{
    public static class ExtensionMethods
    {
        public static string OnlyChars(this string str, string charListToKeep)
        {
            var sb = new StringBuilder();
            str.ToCharArray().Where(c => charListToKeep.Any(cc => cc == c)).ToList().ForEach(c => sb.Append(c));
            return sb.ToString();
        }

        public static string OnlyNumbers(this string str)
        {
            return str.OnlyChars("0123456789");
        }

        public static string OnlyChars(this string str)
        {
            return str.OnlyChars("abcdefghijklmnopqrstuvxwyzABCDEFGHIJKLMNOPQRSTUVXWYZ");
        }

        public static string OnlyConsonants(this string str)
        {
            return str.OnlyChars("bcdfghjklmnpqrstvxwyzBCDFGHJKLMNPQRSTVXWYZ");
        }
    }
}