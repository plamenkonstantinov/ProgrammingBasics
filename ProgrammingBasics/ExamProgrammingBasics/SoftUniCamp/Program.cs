using System;


namespace SoftUniCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfGroups = int.Parse(Console.ReadLine());

            var peopleByCar = 0.0;
            var peopleByMicrobus = 0.0;
            var peopleBySmallBus = 0.0;
            var peopleByBigBus = 0.0;
            var peopleByTrain = 0.0;

            for (int i = 0; i < numberOfGroups; i++)
            {
                int currentGroup = int.Parse(Console.ReadLine());
                if (currentGroup<=5)
                {
                    peopleByCar += currentGroup;
                }
                else if (currentGroup<=12)
                {
                    peopleByMicrobus += currentGroup;
                }
                else if (currentGroup <= 25)
                {
                    peopleBySmallBus += currentGroup;
                }
                else if (currentGroup <= 40)
                {
                    peopleByBigBus += currentGroup;
                }
                else
                {
                    peopleByTrain += currentGroup;
                }
            }
            var totalPeople = peopleByCar + peopleByMicrobus + peopleBySmallBus + peopleByBigBus + peopleByTrain;

            var peopleByCarPerc = peopleByCar / totalPeople * 100;
            var peopleByMicrobusPerc = peopleByMicrobus / totalPeople * 100;
            var peopleBySmallBusPerc = peopleBySmallBus / totalPeople * 100;
            var peopleByBigBusPerc = peopleByBigBus / totalPeople * 100;
            var peopleByTrainPerc = peopleByTrain / totalPeople * 100;

            Console.WriteLine("{0:f2}%", peopleByCarPerc);
            Console.WriteLine("{0:f2}%", peopleByMicrobusPerc);
            Console.WriteLine("{0:f2}%", peopleBySmallBusPerc);
            Console.WriteLine("{0:f2}%", peopleByBigBusPerc);
            Console.WriteLine("{0:f2}%", peopleByTrainPerc);
        }


    }
}
