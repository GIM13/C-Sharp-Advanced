using System;
using System.Linq;

namespace _08Threeuple
{
    public class StartUp
    {
        public static void Main()
        {
            string[] input1 = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries);
            string[] input2 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] input3 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string names = input1[0] + " " + input1[1];
            string address = input1[2];
            string town = string.Join(" ", input1.Skip(3));
            var nameAddress = new Threeuple<string, string, string>(names, address, town);

            string name = input2[0];
            double litersBeer = double.Parse(input2[1]);
            bool drunk = !input2[2].Contains("not");
            var nameLitersBeer = new Threeuple<string, double, bool>(name, litersBeer, drunk);

            string man = input3[0];
            double balance = double.Parse(input3[1]);
            string bank = input3[2];
            var integerDouble = new Threeuple<string, double, string>(man, balance, bank);

            Console.WriteLine(nameAddress);
            Console.WriteLine(nameLitersBeer);
            Console.WriteLine(integerDouble);
        }
    }
}
