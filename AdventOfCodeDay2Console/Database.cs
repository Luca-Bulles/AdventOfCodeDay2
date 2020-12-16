using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AdventOfCodeDay2Console
{
    public class Database
    {
        //in this class will the .txt file be read. 

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
        //textfile list input
        public List<int> TextFileMinimalNumber = new List<int>();
        public List<int> TextFileMaximalNumber = new List<int>();
        public List<char> TextFileRequiredLetter = new List<char>();
        public List<string> TextFilePassword = new List<string>();
        public void ReadTextFile()
        {
            StreamReader sr = new StreamReader("../../../Database.txt");
            string data = sr.ReadLine();
            while (data != null)
            {
                Char[] myChars = { '-', ' ', ':' };
                string[] myText = data.Split(myChars);
                int MinimalNumber = Int32.Parse(myText[0]);
                int MaximalNumber = Int32.Parse(myText[1]);
                char RequiredLetter = char.Parse(myText[2]);
                string Password = myText[4];
                //Consol.Writeline is used to test the method
                //Console.WriteLine(Password);
                data = sr.ReadLine();
                AddItemsToLists(MinimalNumber, MaximalNumber, RequiredLetter, Password);
                //Used to test if MinimalNumber is added to list
                //TextFileMinimalNumber.ForEach(Console.WriteLine);
            }
        }
        public void AddItemsToLists(int MinimalNumber, int MaximalNumber, char RequiredLetter, string Password)
        {
            TextFileMinimalNumber.Add(MinimalNumber);
            TextFileMaximalNumber.Add(MaximalNumber);
            TextFileRequiredLetter.Add(RequiredLetter);
            TextFilePassword.Add(Password);
        }
    }
}
