using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extension
{
    public static class Extension
    {
        public static bool IsPositive(this int number)
        {
            return number > 0;
        }

        public static bool IsEven(this int number)
        {
            return number % 2 == 0 ;
        }

        public static bool IsBigger(this int number, int number2)
        {
            return number > number2;
        }

        public static bool HasGap(this string number)
        {
            return number.Contains(' ');
        }

        public static string HasParam(this string fullname, int yearOfBirth, string domain)
        {
            return fullname + yearOfBirth.ToString() + "@" + domain;
        }

        public static T FindAndReturnIfEqual<T>(this List<T>list, T itemToFind)
        {
            foreach(var item in list)
            {
                if (item.Equals(itemToFind))
                {
                    return item;
                }

            }
            return default;
        }

        public static List<T> EveryOtherWord<T>(this List<T> list)
        {
            var result = new List<T>();

            for (int i = 0; i < list.Count; i++)
            {
                if (i % 2 == 0)
                {
                    result.Add(list[i]);
                }
            }
            return result;
        }


    }
}
