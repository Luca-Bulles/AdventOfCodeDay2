using System;

namespace AdventOfCodeDay2Console
{
    public class Program
    {
        public static Database database = new Database();
        public static PasswordPolicy passwordPolicy = new PasswordPolicy();
        static void Main(string[] args)
        {
            Console.WriteLine("Amount of correct passwords (part one): " + passwordPolicy.PasswordControl());
            Console.WriteLine("Amount of correct passwords (part two): " + passwordPolicy.PasswordControlPartTwo() / 2);
        }
    }
}
