using System;

namespace _07Tuple
{
    public class StartUp
    {
        public static void Main()
        {
            string[] input1 = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries);
            string[] input2 = Console.ReadLine()
                .Split();
            string[] input3 = Console.ReadLine()
                .Split();

            string names = input1[0] + " " + input1[1];
            string address = input1[2];
            var nameAddress = new Tuple<string,string>(names,address);

            string name = input2[0];
            int litersBeer = int.Parse(input2[1]);
            var nameLitersBeer = new Tuple<string, int>(name, litersBeer);

            int integer = int.Parse(input3[0]);
            double doub = double.Parse(input3[1]);
            var integerDouble = new Tuple<int, double>(integer, doub);

            Console.WriteLine(nameAddress);
            Console.WriteLine(nameLitersBeer);
            Console.WriteLine(integerDouble);
        }
    }
}
