using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using Microsoft.VisualBasic.CompilerServices;
using System.Text.RegularExpressions;

namespace Tutorials
{
    class Ramsoft
    {
        CultureInfo provider = CultureInfo.InvariantCulture;
        public static List<string> ChangeDateFormat(List<string> dates)
        {
            List<string> temp = new List<string>();

            List<DateTime> myDates = new List<DateTime>();
            // Convert Strings to Date
            for (int i = 0; i < dates.Count; i++)
            {
                if (Regex.IsMatch(dates[i], @"([12]\d{3}/(0[1-9]|1[0-2])/(0[1-9]|[12]\d|3[01]))"))
                {
                    myDates.Add(DateTime.ParseExact(dates[i], "yyyy/MM/dd", null));
                }
                else if(Regex.IsMatch(dates[i], @"((0[1-9]|[12]\d|3[01])/(0[1-9]|1[0-2])/[12]\d{4})"))
                {
                    myDates.Add(DateTime.ParseExact(dates[i], "dd/MM/yyy", null));
                }
                else if (Regex.IsMatch(dates[i], @"((0[1-9]|1[0-2])-(0[1-9]|[12]\d|3[01])-[12]\d{4})"))
                {
                    myDates.Add(DateTime.ParseExact(dates[i], "MM-dd-yyyy", null));
                }
                else if (Regex.IsMatch(dates[i], @"([12]\d{4}(0[1-9]|1[0-2])(0[1-9]|[12]\d|3[01]))"))
                {
                    myDates.Add(DateTime.ParseExact(dates[i], "yyyyyMMdd", null));
                }

            }



            return temp;
        }

        public static void Main11(string[] args)
        {
            var input = new List<string> { "2010 /03/30", "15/12/2016", "11-15-2012", "20130720" };
            Ramsoft.ChangeDateFormat(input).ForEach(Console.WriteLine);

        }

    }
}
