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
            //als usedLetterPasswordValue te vinden is naar de volgende if anders return password is incorrect
            Console.WriteLine("aaaaa -> " + db.Passwords[count]);
            if (db.Passwords[count].Contains(db.CharRequiredLetter[count]))
            {
                Console.WriteLine("Password is correct");
                //als usedLetterPasswordValue niet minder voorkomt dan de waarde van minimalPasswordValue gaat die naar de volgende if anders return false
                foreach (char item in db.Passwords[count].ToCharArray())
                {
                    if(item == db.CharRequiredLetter[count])
                    {
                        amountTimesUsed++;
                        if (amountTimesUsed > database.IntMaximalAmount[count])
                        {
                            Console.WriteLine("Value is bigger than MaximalAmount");
                        }
                        if (amountTimesUsed < database.IntMaximalAmount[count])
                        {
                            Console.WriteLine("Value is smaller than MaximalAmount");
                        }
                        if (amountTimesUsed == database.IntMaximalAmount[count])
                        {
                            Console.WriteLine("Value is equal to MaximalAmount");
                        }
                    }
                    Console.WriteLine(amountTimesUsed);

                }
            }
            else
            {
                Console.WriteLine("Password is incorrect");
            }

            //als usedLetterPasswordValue niet vaker voorkomt dan de waarde van maximalPasswordValue return true in de methode anders return false
        }
    }
}
