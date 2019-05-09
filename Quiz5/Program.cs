using System;

namespace Quiz5
{
    class Program
    {
        static void Main(string[] args)
        {
        //DECLARATIONS
        string primer;
        string EXIT = "EXIT";
        BaseballGame [] scores = new BaseballGame[1];
        

        primer = HouseKeeping();
        while(primer != EXIT){
            for(var i = 0; i < scores.Length; i++){

                scores[i] = new BaseballGame();

                //Define team 1
                System.Console.WriteLine("Please enter a name for team 1");
                scores[i].teamOne = Console.ReadLine();

                //Define team 2
                System.Console.WriteLine("Please enter a name for team 2");
                scores[i].teamTwo = Console.ReadLine();

                //Define score 1 for team 1
                System.Console.WriteLine($"Enter the score for Team: {scores[i].teamOne}");
                scores[i].scoreOne = Convert.ToInt32(Console.ReadLine());

                //Define score 2 for team 2
                System.Console.WriteLine($"Enter score for Team: {scores[i].teamTwo}");
                scores[i].scoreTwo = Convert.ToInt32(Console.ReadLine());

                System.Console.WriteLine($"{scores[i].teamOne}: {scores[i].scoreOne} vs. {scores[i].teamTwo}: {scores[i].scoreTwo}");

            
               System.Console.WriteLine(Decision(scores[i]));

                primer = Rerun();
                }
            }
        }//end main

        static string HouseKeeping()
        {
            string primer;
            System.Console.WriteLine("Welcome to the baseball game program. To enter type 'ENTER'");
            primer = Console.ReadLine();

            return primer;
        }//end Housekeeping

        static string Decision(BaseballGame game)
        {
            string winner;

            if(game.scoreOne > game.scoreTwo){
                winner = String.Format($"{game.teamOne} Wins!!");
            }else if(game.scoreTwo > game.scoreOne){
                winner = String.Format($"{game.teamTwo} Wins!!");
            }else{
                winner = String.Format($"{game.teamOne} tied {game.teamTwo}");
            }
            return winner;
            }//end Decision
        
        static string Rerun()
        {
            string primer;

            System.Console.WriteLine("Thanks for running the program. If you would like to re-enter type 'ENTER'. To exit type 'EXIT'.");
            primer = Console.ReadLine();

            return primer;
        }

        

    }//end class program
    class BaseballGame
    {
        public string teamOne{get; set;}
        public string teamTwo{get; set;}
        public int scoreOne{get; set;}
        public int scoreTwo{get; set;}
    }// end class BaseballGame
}
