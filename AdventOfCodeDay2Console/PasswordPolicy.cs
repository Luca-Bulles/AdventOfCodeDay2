using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCodeDay2Console
{

    public class PasswordPolicy
    {
        public Database database = new Database();

        public void PasswordControl()
        {
            int AmountCorrectPasswords = 0;

            database.ReadTextFile();
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
                        //Check if lettercountInPassword is changed
                        Console.WriteLine("LetterCountInPassword: " + LetterCountInPassword);
                    }
                    if (LetterCountInPassword >= database.TextFileMinimalNumber[i])
                    {
                        Console.WriteLine("Value is bigger or equal to MinimalNumber");
                        if (LetterCountInPassword <= database.TextFileMaximalNumber[i])
                        {
                            Console.WriteLine("Value is smaller or equal to MaximalNumber");
                            Console.WriteLine("Password is correct");
                            AmountCorrectPasswords++;
                            //Test to check if IndexNumber and AmountCorrectPasswords is higher
                            Console.WriteLine("IndexNumber: " + i);
                            Console.WriteLine("AmountCorrectPasswords: " + AmountCorrectPasswords);
                            continue;
                        }
                        if (LetterCountInPassword > database.TextFileMaximalNumber[i])
                        {
                            Console.WriteLine("Value is bigger than MaximalNumber");
                            Console.WriteLine("Password is incorrect");
                            continue;

                        }
                    }
                    if (LetterCountInPassword < database.TextFileMinimalNumber[i])
                    {
                        Console.WriteLine("Value is lower than MinimalNumber");
                        Console.WriteLine("Password is incorrect");

                    }
                }
                else
                {
                    Console.WriteLine("Password is incorrect because the letter requirement isn't reached");
                }

            }
            Console.WriteLine("AmountCorrectPasswords: " + AmountCorrectPasswords);
        }

        public void PasswordControlPartTwo()
        {
            //TextFileMinimalNumber = required index place 
            //TextFileMaximalNumber = required index place
            //if both places are used by the required letter it's false
            //if bot places aren't used by the required letter it's false
            database.ReadTextFile();
            Console.WriteLine(database.TextFilePassword[0][2]);
        }
    }
}
