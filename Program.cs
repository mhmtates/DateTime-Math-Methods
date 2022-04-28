using System;

namespace Hazır_Metotlar_DateTime_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DateTime.Now");
            Console.WriteLine("DateTime.Now.Date");
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);
            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);
            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());//saat,dakika,saniye cinsinden tarihi getirir.
            Console.WriteLine(DateTime.Now.ToShortTimeString());//Tarihi saat,dakika cinsinden getirir.
            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));
            //DateTime Format

            Console.WriteLine(DateTime.Now.ToString("dd"));//24 Gün olarak
            Console.WriteLine(DateTime.Now.ToString("ddd"));//Saturday yerine Sat getirir.
            Console.WriteLine(DateTime.Now.ToString("dddd"));//Saturday getirir.
            Console.WriteLine(DateTime.Now.ToString("MM")); //04(Kaçıncı aydayız)
            Console.WriteLine(DateTime.Now.ToString("MMM")); //Nisan=>Apr(Şu anki ayın kısaltması)
            Console.WriteLine(DateTime.Now.ToString("MMMM"));//April (Şu Anki ay)
            Console.WriteLine(DateTime.Now.ToString("yy"));//21(Şu anki yılın son iki hanesini getirir.)
            Console.WriteLine(DateTime.Now.ToString("yyyy"));//2021(Şu anki yılı getirir.)

            Console.WriteLine("****Math Kütüphanesi****");
            //Math Kütüphanesi
            Console.WriteLine(Math.Abs(-25));//Absolute value(Mutlak değer) =>25
            Console.WriteLine(Math.Sin(10));//
            Console.WriteLine(Math.Cos(10));
            Console.WriteLine(Math.Tan(10));
            Console.WriteLine(Math.Ceiling(22.3));//23
            Console.WriteLine(Math.Round(22.3));//22
            Console.WriteLine(Math.Round(22.7));//23
            Console.WriteLine(Math.Floor(22.7));//22

            Console.WriteLine(Math.Max(2, 6));//6
            Console.WriteLine(Math.Min(2, 6)); //2

            Console.WriteLine(Math.Pow(3, 4));//3^4=81
            Console.WriteLine(Math.Sqrt(9)); //9'un karekökü 3'dür.
            Console.WriteLine(Math.Log(9));//9'un e tabanındaki logaritmik karşılığıdır.
            Console.WriteLine(Math.Exp(3));
            //e^3
            Console.WriteLine(Math.Log10(10));//10 sayısının logaritma 10 tabanındaki karşılığı



        }
    }
}
