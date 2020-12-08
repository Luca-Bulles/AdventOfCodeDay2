using System;

namespace AdventOfCodeDay2Console
{
    public class Program
    {
        public static Database db = new Database();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            db.ShowItemsInEveryList();
        }
    }
}
