using System;
using System.Collections.Generic;

namespace godisautomaten
{
    class Program
    {
            public static int jappNumber = 3;
            public static int diamNumber = 5;
            public static int marabouNumber = 5;
            public static int pigallNumber = 4;
        
        static void Main(string[] args)
        {
            

            bool exitMeny = false;
            
            while(exitMeny == false){

                Console.Clear();

                //Godisautomaten
                Console.Write("\n***GODISAUTOMATEN***\n\nLUCKA NR 1: Japp antal " +  jappNumber + "st\nLUCKA NR 2: Daim antal " + diamNumber + "st\nLUCKA NR 3: Marabou antal " + marabouNumber + "st\nLUCKA NR 4: Pigall antal " + pigallNumber + "st\nNR 5: EXIT");
                Console.WriteLine("\nSkriv in numret på luckan för att välja godis");
                int val = Int32.Parse(Console.ReadLine());

                switch(val){
                case 1:
                    CandyChoice.CandyJapp();
                    if(jappNumber > 0){
                        jappNumber--;;
                    }
                else{
                    jappNumber = 0;
                }
                break;
                case 2:
                    CandyChoice.CandyDiam();
                    if(diamNumber > 0){
                        diamNumber--;
                    }else{
                        diamNumber = 0;
                    }
                break;
                case 3:
                    CandyChoice.CandyMarabou();
                    if(marabouNumber > 0){
                        marabouNumber--;
                    }else{
                        marabouNumber = 0;
                    }
                break;
                case 4:
                    CandyChoice.CandyPigall();
                    if(pigallNumber > 0){
                        pigallNumber--;
                    }else{
                        marabouNumber = 0;
                    }
                break;
                case 5:
                exitMeny = true;
                break;
                

            }
            }
            

        }
    }
}
