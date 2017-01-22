using System;


namespace FishLand
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal priceSkumPerKg = decimal.Parse(Console.ReadLine());
            decimal priceCacaPerKg = decimal.Parse(Console.ReadLine());
            decimal PalamudKg = decimal.Parse(Console.ReadLine());
            decimal kgSafrid = decimal.Parse(Console.ReadLine());
            decimal kgMidi = decimal.Parse(Console.ReadLine());

            decimal pricePalamudPerKg = priceSkumPerKg * 1.6m;
            decimal priceSafridPerKg = priceCacaPerKg*1.8m;
            decimal priceMidiPerKg = 7.5m;

            var total = ((pricePalamudPerKg * PalamudKg) + (priceSafridPerKg * kgSafrid) + (priceMidiPerKg * kgMidi));
            Console.WriteLine("{0:f2}",total);

        }
    }
}
