using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCodeDay2Console
{
    //Getal 1 geeft de minimale waarde aan
    //Getal 2 geeft de maximale waarde aan
    //De eerste lettter geeft aan welke letter gebruikt moet worden
    //Achter : is de input en moet gecontroleerd worden

    //regex seperator an to list + streamreader
    public class PasswordPolicy
    {
        public static Database database = new Database();
        static int count = 0; //This value will be used as index for the lists
        int amountTimesUsed = 0;
        //methode die controleert of er voldaan wordt aan de minimale waarde
        //methode die controleert of er voldaan wordt aan de maximale waarde
        //methode die controleert of de letter wordt gebruikt.

        public void GetMinimalAmount()
        {
            List<string> minimalValue = database.MinimalAmount;

            foreach (string item in database.MinimalAmount)
            {
                Console.WriteLine(item);
            }
        }
        public void PrintFirstIndexOfMinimalAmount()
        {
            List<string> minimalValue = database.MinimalAmount;
            Console.WriteLine(database.MinimalAmount[0][0]);
        }
        public void PasswordControlTestVersion()
        {
            Database db = new Database();
            //als usedLetterPasswordValue te vinden is naar de volgende of anders return password is incorrect
            Console.WriteLine("aaaa -> " + db.Passwords[count]);
            if (db.Passwords[count].Contains(db.CharRequiredLetter[count]))
            {
                //als usedLetterPasswordValue niet minder voorkomt dan de waarde van minimalPasswordValue gaat die naar de volgende if anders return false
                foreach (char item in db.Passwords[count].ToCharArray())
                {
                    if (item == db.CharRequiredLetter[count])
                    {
                        amountTimesUsed++;
                    }
                    Console.WriteLine(amountTimesUsed);
                }
                if (amountTimesUsed >= database.IntMinimalAmount[count])
                {
                    Console.WriteLine("Value is bigger or equal to MinimalAmount");
                    if (amountTimesUsed <= database.IntMaximalAmount[count])
                    {
                        Console.WriteLine("Value is smaller or equal to MaximalAmount");
                        Console.WriteLine("Password is correct");
                    }
                    if (amountTimesUsed > database.IntMaximalAmount[count])
                    {
                        Console.WriteLine("Value is bigger than MaximalAmount");
                        Console.WriteLine("Password is incorrect");
                    }
                }
                if (amountTimesUsed < database.IntMinimalAmount[count])
                {
                    Console.WriteLine("Value is lower than MinimalAmount");
                    Console.WriteLine("Password is incorrect");
                }

            }
            else
            {
                Console.WriteLine("Password is incorrect because the letter requirement isn't reached");
            }

            //als usedLetterPasswordValue niet vaker voorkomt dan de waarde van maximalPasswordValue return true in de methode anders return false
        }
    }
}
