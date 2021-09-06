using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> weekDays = new List<string>();
            GetWeekDays(ref weekDays);
            GetWeekDays2(ref weekDays);

        }

        static void GetWeekDays(ref List<string> weekDays)
        {
            weekDays.Add("Monday");
        }

        static void GetWeekDays2(ref List<string> weekDays)
        {
            weekDays.Add("Tuesday");
        }
    }
}
