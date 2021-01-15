using System;

namespace AdventOfCodeDay2Console
{
    public class Program
    {
        public static PasswordPolicyChecker passwordPolicy = new PasswordPolicyChecker();
        static void Main(string[] args)
        {
            Console.WriteLine("Amount of correct passwords (part one): " + passwordPolicy.PasswordControl());
            Console.WriteLine("Amount of correct passwords (part two): " + passwordPolicy.PasswordControlPartTwo() / 2);
        }
    }
}
