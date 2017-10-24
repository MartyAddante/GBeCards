using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Web.Models
{
    public class CalendarModel
    {
        public string MonthName { get; set; }
        public int MonthDays { get; set; }
        public string Holiday { get; set; }
        public int HolidayDay { get; set; }
    }
}