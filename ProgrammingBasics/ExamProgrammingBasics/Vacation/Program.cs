using System;


namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int oldPeopleNumber = int.Parse(Console.ReadLine());
            int StudentsNumber = int.Parse(Console.ReadLine());
            int numberOfNights = int.Parse(Console.ReadLine());
            var transportType = Console.ReadLine();

            decimal transportPriceStudents = 0.0m;
            decimal transportPriceOldPeople = 0.0m;
            decimal priceForNight = 82.99m;

            if (transportType == "airplane")
            {
                transportPriceStudents = 50.0m;
                transportPriceOldPeople = 70.0m;
            }
            else if (transportType == "boat")
            {
                transportPriceStudents = 39.99m;
                transportPriceOldPeople = 42.99m;
            }
            else if (transportType == "bus")
            {
                transportPriceStudents = 28.5m;
                transportPriceOldPeople = 32.5m;
            }
            else if ((transportType == "train") && (oldPeopleNumber + StudentsNumber > 50))
            {
                transportPriceStudents = 14.99m * 0.5m;
                transportPriceOldPeople = 24.99m * 0.5m;
            }
            else if (transportType == "train")
            {
                transportPriceStudents = 14.99m;
                transportPriceOldPeople = 24.99m;
            }
            var studentPrice = 2 * transportPriceStudents * StudentsNumber;
            var oldPeoplePrice = 2 * oldPeopleNumber * transportPriceOldPeople;
            

            var totalPrice = 1.1m * ((numberOfNights * priceForNight) + studentPrice+oldPeoplePrice);
            Console.WriteLine("{0:f2}",totalPrice);

        }
    }
}
