





using System.Security.Cryptography.X509Certificates;

class Program(){

    
    public static void Main(string[] args){
Console.WriteLine("Demon: Hello there earthling welcome to HELLS EPIC RACE *Evil laugh*  Now please select a kart and a road");
        Console.WriteLine(".........................................................................................................");       
       
        Kart mykart = new( 1, "Jack the stripper", "Hot pink", 250);
        Kart mykart2 = new( 2, "Mothman", "Black", 247);
       

        mykart.PrintInfo();
        mykart2.PrintInfo();
       

        string word = "Jack the stripper";
        string word2 = "Mothman";
   




        Console.WriteLine("......................................................................");
        Console.WriteLine("Demon: Soooooo which one is it???   (Write the EXACT name of the kart)");
        string input = Console.ReadLine();




        
        if(input == word)
        {
            Console.WriteLine(input = word);


        } else
        {
            Console.WriteLine(input = word2);
            input = word2;

        }
            Console.WriteLine("Demon: Good I guess, well lets look at some roads okay?");
        

        /*
        bool isDone = false;

        while(isDone = true)
        {
            if (input == word)
            {

            } else if(input == word2)

            {

            } else
            {
                Console.WriteLine("Try again");
                Console.ReadLine();
            }
        }
        */
        

        Console.WriteLine("........................................................................................................................");


       
        


        Roads myroad = new("Graveyard", "Hard", "Show off your drifting skills because this road has a lot of curves, watch out for the tombstones or else   >:(");
        Roads myroad2 = new("The gateway to hell", "Easy", "Hope you like to do tricks this road jumps you from heaven to hell");

        myroad.PrintInfo();
        myroad2.PrintInfo();

        string word6 = "Graveyard";
        string word7 = "The gateway to hell";


        Console.WriteLine("........................................................................................................................");
        Console.WriteLine("Demon: which one?");
        string input2 = Console.ReadLine();

        Console.WriteLine("Demon: Just so you know you are going to race against the kart you didnt choose    hahaha");
        Console.WriteLine("........................................................................................................................");


        if(input2 == word6)
        {
            Console.WriteLine(input2 = word6);
            input2 = word6;
            Console.WriteLine("Demon: Mhmmm, good, well lets start :)");
        } else
        {
            Console.WriteLine(input = word7);
            input2 = word7;
            Console.WriteLine("Demon: Mhmmm, good, well lets start ;)");
        }

      

     




        Console.WriteLine("............................................................");
        Console.WriteLine("Demon: lest see your result, earthling");
        Console.WriteLine("............................................................");

        if (word == word6 || word2 == word7 ) 
        {
            Console.WriteLine("Demon: Congrats you win, here is your price (100 coins)");
        }
        else
        {
            Console.WriteLine("Demon: HA loser, I guess you can try again");
        }


          
    }

    
}






