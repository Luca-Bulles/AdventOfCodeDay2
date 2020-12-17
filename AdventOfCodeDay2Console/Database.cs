using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AdventOfCodeDay2Console
{
    public class Database
    {
        //in this class will the .txt file be read. 

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
                data = sr.ReadLine();
                AddItemsToLists(MinimalNumber, MaximalNumber, RequiredLetter, Password);
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
