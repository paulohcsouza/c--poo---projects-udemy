using System;
using System.Globalization;

namespace exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Testes com modificadores

            string original = "abcde FGHIJ ABC abc DEFG ";
            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();
            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");
            string s4 = original.Substring(3);
            string s5 = original.Substring(3, 5);
            string s6 = original.Replace('a', 'x');
            string s7 = original.Replace("abc", "xy");
            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = String.IsNullOrWhiteSpace(original);

            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine("LastIndexOf('bc'): " + n2);
            Console.WriteLine("Substring(3): -" + s4 + "-");
            Console.WriteLine("Substring(3, 5): -" + s5 + "-");
            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
            Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);

            //Testes com modificadores de DateTime e TimeSpan

            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);

            DateTime d11 = new DateTime(2000, 8, 15);
            DateTime d22 = new DateTime(2000, 8, 15, 13, 5, 58);
            DateTime d33 = new DateTime(2000, 8, 15, 13, 5, 58, 275);
            Console.WriteLine(d11);
            Console.WriteLine(d22);
            Console.WriteLine(d33);

            DateTime d111 = DateTime.Now;
            DateTime d222 = DateTime.UtcNow;
            DateTime d333 = DateTime.Today;
            Console.WriteLine(d111);
            Console.WriteLine(d222);
            Console.WriteLine(d333);

            DateTime d1111 = DateTime.Parse("2000-08-15");
            DateTime d2222 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d3333 = DateTime.Parse("15/08/2000");
            DateTime d4444 = DateTime.Parse("15/08/2000 13:05:58");
            Console.WriteLine(d1111);
            Console.WriteLine(d2222);
            Console.WriteLine(d3333);
            Console.WriteLine(d4444);

            DateTime d11111 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd",
CultureInfo.InvariantCulture);
            DateTime d22222 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss",
            CultureInfo.InvariantCulture);
            Console.WriteLine(d11111);
            Console.WriteLine(d22222);

            TimeSpan t1 = new TimeSpan(0, 1, 30);
            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);

            TimeSpan t11 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = new TimeSpan(2, 11, 21);
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);
            Console.WriteLine(t11);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);

            TimeSpan t111 = TimeSpan.FromDays(1.5);
            TimeSpan t222 = TimeSpan.FromHours(1.5);
            TimeSpan t333 = TimeSpan.FromMinutes(1.5);
            TimeSpan t444 = TimeSpan.FromSeconds(1.5);
            TimeSpan t555 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan t666 = TimeSpan.FromTicks(900000000L);
            Console.WriteLine(t111);
            Console.WriteLine(t222);
            Console.WriteLine(t333);
            Console.WriteLine(t444);
            Console.WriteLine(t555);
            Console.WriteLine(t666);

            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);

            DateTime d111111 = new DateTime(2001, 8, 15, 13, 45, 58);
            string s11 = d111111.ToLongDateString();
            string s22 = d111111.ToLongTimeString();
            string s33 = d111111.ToShortDateString();
            string s44 = d111111.ToShortTimeString();
            string s55 = d111111.ToString();
            string s66 = d111111.ToString("yyyy-MM-dd HH:mm:ss");
            string s77 = d111111.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Console.WriteLine(s11);
            Console.WriteLine(s22);
            Console.WriteLine(s33);
            Console.WriteLine(s44);
            Console.WriteLine(s55);
            Console.WriteLine(s66);
            Console.WriteLine(s77);

            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
            Console.WriteLine(t);
            Console.WriteLine("Days: " + t.Days);
            Console.WriteLine("Hours: " + t.Hours);
            Console.WriteLine("Minutes: " + t.Minutes);
            Console.WriteLine("Milliseconds: " + t.Milliseconds);
            Console.WriteLine("Seconds: " + t.Seconds);
            Console.WriteLine("Ticks: " + t.Ticks);
            Console.WriteLine("TotalDays: " + t.TotalDays);
            Console.WriteLine("TotalHours: " + t.TotalHours);
            Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
            Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);

            TimeSpan t1111 = new TimeSpan(1, 30, 10);
            TimeSpan t2222 = new TimeSpan(0, 10, 5);
            TimeSpan sum = t1111.Add(t2222);
            TimeSpan dif = t1111.Subtract(t2222);
            TimeSpan mult = t2222.Multiply(2.0);
            TimeSpan div = t2222.Divide(2.0);
            Console.WriteLine(t1111);
            Console.WriteLine(t2222);
            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);

            DateTime d1111111 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime d2222222 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime d3333333 = new DateTime(2000, 8, 15, 13, 5, 58);
            Console.WriteLine("d1: " + d1111111);
            Console.WriteLine("d1 Kind: " + d1111111.Kind);
            Console.WriteLine("d1 to Local: " + d1111111.ToLocalTime());
            Console.WriteLine("d1 to Utc: " + d1111111.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d2: " + d2222222);
            Console.WriteLine("d2 Kind: " + d2222222.Kind);
            Console.WriteLine("d2 to Local: " + d2222222.ToLocalTime());
            Console.WriteLine("d2 to Utc: " + d2222222.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d3: " + d3333333);
            Console.WriteLine("d3 Kind: " + d3333333.Kind);
            Console.WriteLine("d3 to Local: " + d3333333.ToLocalTime());
            Console.WriteLine("d3 to Utc: " + d3333333.ToUniversalTime());
        }
    }
}
