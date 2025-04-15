using System;

/*Source cited: ChatGPT.04.13.2025. "Show me how to fix this class error"*/
namespace RockPaperScissorsGame
{
    class HumanPlayer
    {
        private int points;

        public HumanPlayer(int initial)
        {
            points = initial;
        }

        public int GetPoints()
        {
            return points;
        }

        public void WinRound()
        {
            points += 5;
        }

        public void LoseRound()
        {
            points -= 5;
        }

        public string HumanDecision()
        {
            Console.Write("Choose Rock, Paper, or Scissors: ");
            return Console.ReadLine();
        }
    }

    class ComputerPlayer
    {
        private static readonly string[] choices = { "Rock", "Paper", "Scissors" };
        private static readonly Random rand = new Random();

        public string ComputerDecision()
        {
            int index = rand.Next(choices.Length);
            return choices[index];
        }
    }

    class RockPaperScissors
    {
        static void Main(string[] args)
        {
            HumanPlayer human = new HumanPlayer(5);
            ComputerPlayer computer = new ComputerPlayer();

            Console.WriteLine("Welcome to Rock-Paper-Scissors!");
            Console.WriteLine("You start with 5 points. Win to gain points, lose to lose points.");

            while (human.GetPoints() > 0)
            {
                Console.WriteLine($"\nYour current points: {human.GetPoints()}");

                string humanChoice = human.HumanDecision();
                string computerChoice = computer.ComputerDecision();

                Console.WriteLine($"Computer chose: {computerChoice}");

                string result = GetRoundResult(humanChoice, computerChoice);

                switch (result)
                {
                    case "win":
                        human.WinRound();
                        Console.WriteLine("You win this round! +5 points");
                        break;
                    case "lose":
                        human.LoseRound();
                        Console.WriteLine("You lost this round! -5 points");
                        break;
                    case "tie":
                        Console.WriteLine("It's a tie! 0 points");
                        break;
                    default:
                        Console.WriteLine("Invalid input. Try again.");
                        continue;
                }

                if (human.GetPoints() <= 0)
                {
                    Console.WriteLine("\nYou have 0 points. Game over!");
                    break;
                }

                Console.Write("Do you want to play another round? (yes/no): ");
                string answer = Console.ReadLine().Trim().ToLower();
                if (answer != "yes")
                {
                    Console.WriteLine("Thanks for playing!");
                    break;
                }
            }
        }

        static string GetRoundResult(string human, string computer)
        {
            human = human.ToLower();
            computer = computer.ToLower();

            if (human == computer) return "tie";

            if ((human == "rock" && computer == "scissors") ||
                (human == "paper" && computer == "rock") ||
                (human == "scissors" && computer == "paper"))
            {
                return "win";
            }
            else if ((human == "rock" || human == "paper" || human == "scissors"))
            {
                return "lose";
            }
            else
            {
                return "invalid";
            }
        }
    }
}

