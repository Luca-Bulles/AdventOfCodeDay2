using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCodeDay2Console
{

    public class PasswordPolicyChecker
    {
        public Database database = new Database();

        public int PasswordControl()
        {
            int AmountCorrectPasswords = 0;

            database.ReadTextFileAndDivideDataOverLists();
            for(int i = 0; i < database.TextFileRequiredLetter.Count; i++)
            {
                if (database.TextFilePassword[i].Contains(database.TextFileRequiredLetter[i]))
                {
                    int LetterCountInPassword = 0;
                    foreach (char item in database.TextFilePassword[i])
                    {
                        if (item == database.TextFileRequiredLetter[i])
                        {
                            LetterCountInPassword++;
                        }
                    }
                    if (LetterCountInPassword >= database.TextFileMinimalNumber[i])
                    {
                        if (LetterCountInPassword <= database.TextFileMaximalNumber[i])
                        {
                            AmountCorrectPasswords++;
                            continue;
                        }
                        if (LetterCountInPassword > database.TextFileMaximalNumber[i])
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
            database.ReadTextFileAndDivideDataOverLists();
            for (int i = 0; i < database.TextFileRequiredLetter.Count; i++) 
            {
                int Index1 = database.TextFileMinimalNumber[i] - 1;
                int Index2 = database.TextFileMaximalNumber[i] - 1;
                if (database.TextFileRequiredLetter[i] == database.TextFilePassword[i][Index1])
                {
                    if(database.TextFileRequiredLetter[i] == database.TextFilePassword[i][Index2]) 
                    {
                        continue;
                    }
                    if (database.TextFileRequiredLetter[i] != database.TextFilePassword[i][Index2]) 
                    {
                        AmountCorrectPasswords++;
                        continue;
                    }
                }
                else if (database.TextFileRequiredLetter[i] == database.TextFilePassword[i][Index2]) 
                {
                    if (database.TextFileRequiredLetter[i] == database.TextFilePassword[i][Index1])
                    {
                        continue;
                    }
                    if (database.TextFileRequiredLetter[i] != database.TextFilePassword[i][Index1]) 
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
