using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCodeDay2Console
{
    public class Database
    {
        //in this class will the .txt file be read. tba

        public List<string> MinimalAmount = new List<string>()
         {
             "2","3","4","5"
         };
        public List<string> MaximalAmount = new List<string>() 
        {
            "4","6", "8", "10"
        };
        public List<string> Passwords = new List<string>() 
        {
            "aaaa", "ccc", "abcd", "ddddde"
        };
        //array
        public char[] CharRequiredLetter = { 'a', 'b', 'c', 'd' };

        //int
        public List<int> IntMinimalAmount = new List<int>()
         {
             2,3,4,5
         };
        public List<int> IntMaximalAmount = new List<int>()
        {
            4,6, 8, 10
        };
        public void ShowItemsInMinimalAmountList()
        {
            MinimalAmount.ForEach(Console.WriteLine);
        }
        public void ShowItemsInEveryList()
        {
            Console.WriteLine("MinimalAmount:");
            MinimalAmount.ForEach(Console.WriteLine);
            Console.WriteLine("MaximalAmount:");
            MaximalAmount.ForEach(Console.WriteLine);
            Console.WriteLine("Passwords");
            Passwords.ForEach(Console.WriteLine);
        }
    }
}
