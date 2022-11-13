using System;
using static System.Net.Mime.MediaTypeNames;

namespace timezoneconverter
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime time = new DateTime();

            Console.WriteLine("est, utc, pst, cst are supported");

            Console.WriteLine("what timezone do you want to convert from: ");
            string timezone1 = Console.ReadLine();
            timezone1 = timezone1.ToLower();

            Console.WriteLine("what timezone do you want to convert to: ");
            string timezone2 = Console.ReadLine();
            timezone2 = timezone2.ToLower();

            Console.WriteLine("what hour is it");
            var hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("what minute is it");
            var minutes = Convert.ToInt32(Console.ReadLine());

            time = time.AddHours(hours);
            time = time.AddMinutes(minutes);

            if (timezone1 == "est")
            {
                if (timezone2 == "utc")
                {
                    var dt = time.AddHours(5);
                    string time1 = time.ToString("HH:mm");
                    string dt1 = dt.ToString("HH:mm");
                    Console.WriteLine($"{timezone1}: {time1}");
                    Console.WriteLine($"{timezone2}: {dt1}");
                }

                else if (timezone2 == "pst")
                {
                    var dt = time.AddHours(-3);
                    string time1 = time.ToString("HH:mm");
                    string dt1 = dt.ToString("HH:mm");
                    Console.WriteLine($"{timezone1}: {time1}");
                    Console.WriteLine($"{timezone2}: {dt1}");

                }

                else if (timezone2 == "cst")
                {
                    var dt = time.AddHours(-1);
                    string time1 = time.ToString("HH:mm");
                    string dt1 = dt.ToString("HH:mm");
                    Console.WriteLine($"{timezone1}: {time1}");
                    Console.WriteLine($"{timezone2}: {dt1}");
                }
            }

            if (timezone1 == "edt")
            {
                if (timezone2 == "utc")
                {
                    var dt = time.AddHours(5);
                    string time1 = time.ToString("HH:mm");
                    string dt1 = dt.ToString("HH:mm");
                    Console.WriteLine($"{timezone1}: {time1}");
                    Console.WriteLine($"{timezone2}: {dt1}");
                }

                else if (timezone2 == "pst")
                {
                    var dt = time.AddHours(-3);
                    string time1 = time.ToString("HH:mm");
                    string dt1 = dt.ToString("HH:mm");
                    Console.WriteLine($"{timezone1}: {time1}");
                    Console.WriteLine($"{timezone2}: {dt1}");

                }

                else if (timezone2 == "cst")
                {
                    var dt = time.AddHours(-1);
                    string time1 = time.ToString("HH:mm");
                    string dt1 = dt.ToString("HH:mm");
                    Console.WriteLine($"{timezone1}: {time1}");
                    Console.WriteLine($"{timezone2}: {dt1}");
                }
            }

            if (timezone1 == "utc")
            {
                if (timezone2 == "est")
                {
                    var dt = time.AddHours(-5);
                    string time1 = time.ToString("HH:mm");
                    string dt1 = dt.ToString("HH:mm");
                    Console.WriteLine($"{timezone1}: {time1}");
                    Console.WriteLine($"{timezone2}: {dt1}");
                }

                else if (timezone2 == "edt")
                {
                    var dt = time.AddHours(-5);
                    string time1 = time.ToString("HH:mm");
                    string dt1 = dt.ToString("HH:mm");
                    Console.WriteLine($"{timezone1}: {time1}");
                    Console.WriteLine($"{timezone2}: {dt1}");

                }

                else if (timezone2 == "pst")
                {
                    var dt = time.AddHours(-8);
                    string time1 = time.ToString("HH:mm");
                    string dt1 = dt.ToString("HH:mm");
                    Console.WriteLine($"{timezone1}: {time1}");
                    Console.WriteLine($"{timezone2}: {dt1}");

                }

                else if (timezone2 == "cst")
                {
                    var dt = time.AddHours(-6);
                    string time1 = time.ToString("HH:mm");
                    string dt1 = dt.ToString("HH:mm");
                    Console.WriteLine($"{timezone1}: {time1}");
                    Console.WriteLine($"{timezone2}: {dt1}");
                }
            }

            if (timezone1 == "pst")
            {
                if (timezone2 == "est")
                {
                    var dt = time.AddHours(3);
                    string time1 = time.ToString("HH:mm");
                    string dt1 = dt.ToString("HH:mm");
                    Console.WriteLine($"{timezone1}: {time1}");
                    Console.WriteLine($"{timezone2}: {dt1}");
                }

                else if (timezone2 == "edt")
                {
                    var dt = time.AddHours(3);
                    string time1 = time.ToString("HH:mm");
                    string dt1 = dt.ToString("HH:mm");
                    Console.WriteLine($"{timezone1}: {time1}");
                    Console.WriteLine($"{timezone2}: {dt1}");

                }

                else if (timezone2 == "utc")
                {
                    var dt = time.AddHours(8);
                    string time1 = time.ToString("HH:mm");
                    string dt1 = dt.ToString("HH:mm");
                    Console.WriteLine($"{timezone1}: {time1}");
                    Console.WriteLine($"{timezone2}: {dt1}");

                }

                else if (timezone2 == "cst")
                {
                    var dt = time.AddHours(2);
                    string time1 = time.ToString("HH:mm");
                    string dt1 = dt.ToString("HH:mm");
                    Console.WriteLine($"{timezone1}: {time1}");
                    Console.WriteLine($"{timezone2}: {dt1}");
                }
            }

            if (timezone1 == "cst")
            {
                if (timezone2 == "est")
                {
                    var dt = time.AddHours(1);
                    string time1 = time.ToString("HH:mm");
                    string dt1 = dt.ToString("HH:mm");
                    Console.WriteLine($"{timezone1}: {time1}");
                    Console.WriteLine($"{timezone2}: {dt1}");
                }

                else if (timezone2 == "edt")
                {
                    var dt = time.AddHours(1);
                    string time1 = time.ToString("HH:mm");
                    string dt1 = dt.ToString("HH:mm");
                    Console.WriteLine($"{timezone1}: {time1}");
                    Console.WriteLine($"{timezone2}: {dt1}");

                }

                else if (timezone2 == "pst")
                {
                    var dt = time.AddHours(-2);
                    string time1 = time.ToString("HH:mm");
                    string dt1 = dt.ToString("HH:mm");
                    Console.WriteLine($"{timezone1}: {time1}");
                    Console.WriteLine($"{timezone2}: {dt1}");

                }

                else if (timezone2 == "utc")
                {
                    var dt = time.AddHours(6);
                    string time1 = time.ToString("HH:mm");
                    string dt1 = dt.ToString("HH:mm");
                    Console.WriteLine($"{timezone1}: {time1}");
                    Console.WriteLine($"{timezone2}: {dt1}");
                }
            }
        }
    }
}