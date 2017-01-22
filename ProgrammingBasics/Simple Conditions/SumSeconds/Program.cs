using System;


namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var sec1 = int.Parse(Console.ReadLine());
            var sec2 = int.Parse(Console.ReadLine());
            var sec3 = int.Parse(Console.ReadLine());
            var sum = sec1 + sec2 + sec3;
            var minutes = sum / 60;
            var seconds = sum % 60;
            if (seconds > 9)
            {
                Console.WriteLine(minutes + ":" + seconds);
            }
            else
            {
                Console.WriteLine(minutes + ":0"+ seconds);
            }
        }
    }
}
