using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCodeDay2Console
{
   public class AddDataToLists
    {
        public Database database = new Database();

        //public List<int> MinimalNumberRequirement = new List<int>();
        //public List<int> MaximalNumberRequirement = new List<int>();
        //public List<char> RequiredLetterRequirement = new List<char>();
        //public List<string> PasswordByUserInput = new List<string>();

        public void DivideDataIntoLists(int MinimalNumber, int MaximalNumber, char RequiredLetter, string Password)
        {
            List<int> MinimalNumberRequirement = new List<int>();
            List<int> MaximalNumberRequirement = new List<int>();
            List<char> RequiredLetterRequirement = new List<char>();
            List<string> PasswordByUserInput = new List<string>();

            MinimalNumberRequirement.Add(MinimalNumber);
            MaximalNumberRequirement.Add(MaximalNumber);
            RequiredLetterRequirement.Add(RequiredLetter);
            PasswordByUserInput.Add(Password);
        }
        public void AddDataIntoListsAfterDeviding()
        {
            database.ReadTextFile();
        }
    }
}
