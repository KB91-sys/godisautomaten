using System;
using System.Collections.Generic;
using System.Linq;

namespace godisautomaten
{

    class CandyChoice
    {
        public static int jappNumber = 3;
        public static int diamNumber = 5;
        public static int marabouNumber = 5;
        public static int pigallNumber = 4;
        public static void CandyJapp(){
            Console.Clear();

            jappNumber--;
    
            if(jappNumber >= 0){
                Console.Write("Du tar ut en Japp från luckan.");
            }
            else{
                Console.Write("Ser ut som det är tomt i denna luckan.");
            }
            Console.ReadKey();
        }

        public static void CandyDiam(){
            Console.Clear();

            diamNumber--;

            if(diamNumber >= 0){
                Console.Write("Du tar en diam från luckan.");

            }
            else{
                Console.Write("Ser ut som det är tomt i denna luckan.");   
            }
            Console.ReadKey();
        }

        public static void CandyMarabou(){
            
            Console.Clear();

            marabouNumber--;

            if(marabouNumber >= 0){
                Console.Write("Du tar en Marabou från luckan.");

            }
            else{
                Console.Write("Ser ut som det är tomt i denna luckan.");
            }
            Console.ReadKey();
        }

        public static void CandyPigall(){

            Console.Clear();

            if(pigallNumber >= 0){
                pigallNumber--;
                Console.Write("Du tar Pigall från luckan.");
            }
            else{
                Console.Write("Ser ut som det är tomt i denna luckan.");
            }
            Console.ReadKey();
        }


    }
}
