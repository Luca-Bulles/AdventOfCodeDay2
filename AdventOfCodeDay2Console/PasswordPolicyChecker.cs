using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCodeDay2Console
{

    public class PasswordPolicyChecker
    {
        public Database database = new Database();
        public AddDataToLists data = new AddDataToLists();

        public int PasswordControl()
        {
            int AmountCorrectPasswords = 0;

            database.ReadTextFile();
            for(int i = 0; i <data.MinimalNumberRequirement.Count; i++)
            {
                if (data.PasswordByUserInput[i].Contains(data.RequiredLetterRequirement[i]))
                {
                    int LetterCountInPassword = 0;
                    foreach (char item in data.PasswordByUserInput[i])
                    {
                        if (item == data.RequiredLetterRequirement[i])
                        {
                            LetterCountInPassword++;
                        }
                    }
                    if (LetterCountInPassword >= data.MinimalNumberRequirement[i])
                    {
                        if (LetterCountInPassword <= data.MaximalNumberRequirement[i])
                        {
                            AmountCorrectPasswords++;
                            continue;
                        }
                        if (LetterCountInPassword > data.MaximalNumberRequirement[i])
                        {
                            continue;
                        }
                    }
                }
            }
            return AmountCorrectPasswords;
        }

        public int PasswordControlPartTwo()
        {
            int AmountCorrectPasswords = 0;
            database.ReadTextFile();
            for (int i = 0; i < data.RequiredLetterRequirement.Count; i++) 
            {
                int Index1 = data.MinimalNumberRequirement[i] - 1;
                int Index2 = data.MaximalNumberRequirement[i] - 1;
                if (data.RequiredLetterRequirement[i] == data.PasswordByUserInput[i][Index1])
                {
                    if(data.RequiredLetterRequirement[i] == data.PasswordByUserInput[i][Index2]) 
                    {
                        continue;
                    }
                    if (data.RequiredLetterRequirement[i] != data.PasswordByUserInput[i][Index2]) 
                    {
                        AmountCorrectPasswords++;
                        continue;
                    }
                }
                else if (data.RequiredLetterRequirement[i] == data.PasswordByUserInput[i][Index2]) 
                {
                    if (data.RequiredLetterRequirement[i] == data.PasswordByUserInput[i][Index1])
                    {
                        continue;
                    }
                    if (data.RequiredLetterRequirement[i] != data.PasswordByUserInput[i][Index1]) 
                    {
                        AmountCorrectPasswords++;
                        continue;
                    }
                }
            }
            return AmountCorrectPasswords;
        }
    }
}
