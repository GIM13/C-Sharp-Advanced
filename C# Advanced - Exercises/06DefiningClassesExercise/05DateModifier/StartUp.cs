using System;

namespace _05DateModifier
{
    class StartUp
    {
        static void Main()
        {
            DateTime firstTime = DateTime.Parse(Console.ReadLine());
            DateTime secondTime = DateTime.Parse(Console.ReadLine());

            double daysDifference = DateModifier.ReturnsDaysBetweenTwoDates(firstTime, secondTime);

            Console.WriteLine(daysDifference);
        }
    }
}
