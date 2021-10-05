using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NijntjeStrand
{

    //regelt het laden van volgende windows
    class MenuManager
    {


        public string namePlayer1 = "Voer naam speler 1 in";            //Naam van speler 1
        public string namePlayer2 = "Voer naam speler 2 in";            //Naam van speler 2

        public static string namePlayer_1 = "";                         //publieke naam speler 1
        public static string namePlayer_2 = "";                         //publieke naam speler 2

        //functie voor het veranderen van een naam
        public static string SetSpelerNaam(string input)
        {

            return input;
        }
        //functie voor het veranderen van een speler naam
        public static string SetSpelerNaam(int Speler, string Naam)
        {
            //als er 1 word ingevoerd
            if(Speler == 1)
            {
                namePlayer_1 = Naam;                                    //zet speler naam
                return "naam gezet";
            }
            if(Speler == 2)
            {
                namePlayer_2 = Naam;                                    //zet speler naam
                return "naam gezet";
            }
            return "geen geldige speler";                               //Geen geldige speler geselecteerd
        }

    }
}
