using System;
using System.Collections.Generic;

namespace _08BalancedParenthesis
{
    class Program
    {
        static void Main()
        {
            char[] parentheses = Console.ReadLine().ToCharArray();

            string result = "YES";
            var parenthesesStack = new Stack<char>();

            if (parentheses.Length % 2 != 0)
            {
                result = "NO";
            }
            else
            {
                foreach (var clamp in parentheses)
                {
                    if (clamp == '(' || clamp == '[' || clamp == '{')
                    {
                        parenthesesStack.Push(clamp);
                    }
                    else if (parenthesesStack.Count > 0)
                    {
                        if ((clamp == ')' && parenthesesStack.Pop() != '(')
                         || (clamp == ']' && parenthesesStack.Pop() != '[')
                         || (clamp == '}' && parenthesesStack.Pop() != '{'))
                        {
                            result = "NO";
                        }
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
