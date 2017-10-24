using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Web.Models
{
    public class HomeModel
    {
        public DateTime RightNow { get; set; }


        public string Today()
        {
            DateTime now = DateTime.Now;

            DayOfWeek weekday = now.DayOfWeek;
            string month = now.ToString("MMMM");
            int day = now.Day;
            string dayString = "";
            
            if(day == 1 || day == 21 || day == 31)
            {
                dayString = $"{day}ST";
            }
            else if(day == 2 || day == 22)
            {
                dayString = $"{day}ND";

            }
            else if(day == 3 || day == 23)
            {
                dayString = $"{day}RD";

            }
            else
            {
                dayString = $"{day}TH";
            }

            string full = $"Today is {weekday} {month}, {dayString}";

            return full;
        }
    }
}