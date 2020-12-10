using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCodeDay2Console
{
    //Getal 1 geeft de minimale waarde aan
    //Getal 2 geeft de maximale waarde aan
    //De eerste lettter geeft aan welke letter gebruikt moet worden
    //Achter : is de input en moet gecontroleerd worden
    public class PasswordPolicy
    {
        public static Database database = new Database();
        //methode die controleert of er voldaan wordt aan de minimale waarde
        //methode die controleert of er voldaan wordt aan de maximale waarde
        //methode die controleert of de letter wordt gebruikt.
        
        public void GetMinimalAmount()
        {
            int firstValue = 0;
            List <string> minimalValue = database.MinimalAmount;

            foreach (string item in database.MinimalAmount)
            {
                Console.WriteLine(item);
            }
        }
        public void PrintFirstIndexOfMinimalAmount()
        {
            List<string> minimalValue = database.MinimalAmount;
            Console.WriteLine(database.MinimalAmount[0]);
        }
    }
}
