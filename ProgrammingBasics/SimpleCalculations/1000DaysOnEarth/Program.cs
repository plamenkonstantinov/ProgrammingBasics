using System;


namespace _1000DaysOnEarth
{
    class Program
    {
        static void Main(string[] args)
        {
            string birthDay = (Console.ReadLine());
            DateTime convertBirthDay = DateTime.ParseExact(birthDay, "dd-MM-yyyy", null);

            DateTime after1000 = convertBirthDay.AddDays(999);
            string dateFormat = "dd-MM-yyyy";
            string strDate = after1000.ToString(dateFormat);

            Console.WriteLine(strDate);
        }
    }
}
