﻿using System;
using LeagueInformer.Resources;

namespace LeagueInformer.Utils
{
    public class DateHandler
    {
        public string ParseTimeToDate(string time)
        {
            bool timeParse = double.TryParse(time, out double parsedTime);
            if (!timeParse)
            {
                Console.WriteLine(AppResources.Error_Undefined);
                return string.Empty;
            }
            var basicTime = DateTime.SpecifyKind(new DateTime(1970, 1, 1), DateTimeKind.Utc);
            var date = basicTime.AddMilliseconds(parsedTime);
            return date.ToString("dd MMMM yyyy");
        }
    }
}