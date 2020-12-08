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
        List<string> MaximalAmount = new List<string>() 
        {
            "4","6", "8", "10"
        };
        List<string> RequiredLetter = new List<string>() 
        {
            "a", "b", "c", "d"
        };
        List<string> Passwords = new List<string>() 
        {
            "aaaaa", "ccc", "abcd", "ddddde"
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
            Console.WriteLine("RequiredLetter");
            RequiredLetter.ForEach(Console.WriteLine);
            Console.WriteLine("Passwords");
            Passwords.ForEach(Console.WriteLine);
        }
    }
}
