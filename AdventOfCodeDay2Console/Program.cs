using System;

namespace AdventOfCodeDay2Console
{
    public class Program
    {
        public static Database database = new Database();
        public static PasswordPolicy passwordPolicy = new PasswordPolicy();
        static void Main(string[] args)
        {
            //passwordPolicy.PasswordControlTestVersion();
            database.ReadTextFile();
        }
    }
}
