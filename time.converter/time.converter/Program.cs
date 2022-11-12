using System;
using static System.Net.Mime.MediaTypeNames;

namespace timezoneconverter
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime time = new DateTime();

            Console.WriteLine("what timezone do you want to convert to: ");
            string timezone1 = Console.ReadLine();
            timezone1 = timezone1.ToLower();

            Console.WriteLine("what hour is it");
            var hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("what minute is it");
            var minutes = Convert.ToInt32(Console.ReadLine());

            time = time.AddHours(hours);
            time = time.AddMinutes(minutes);

            // converts from est/edt to utc
            if (timezone1 == "utc")
            {
                var dt = time.AddHours(5);
                string time1 = time.ToString("HH:mm");
                string dt1 = dt.ToString("HH:mm");
                Console.WriteLine($"original time: {time1}");
                Console.WriteLine($"{timezone1}: {dt1}");
            }

            // converts from est/edt to pst
            else if (timezone1 == "pst")
            {
                var dt = time.AddHours(-3);
                string time1 = time.ToString("HH:mm");
                string dt1 = dt.ToString("HH:mm");
                Console.WriteLine($"original time: {time1}");
                Console.WriteLine($"{timezone1}: {dt1}");
            
            }

            // breaks
            else
            {
                Console.WriteLine("Your timezone is either unsupported or invalid, please try again");
            }
        }
    }
}