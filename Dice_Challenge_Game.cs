namespace MyApp;

public class Dice_Challenge_Game
{
    public static int TargetNumber()
    {
        Random r = new Random();
        return r.Next(1, 6);
    }

    public static int RollNum()
    {
        Random r = new Random();
        return r.Next(1, 7);
    }

    public static void DiceGamePlay()
    {
        Console.WriteLine("================================");
        Console.WriteLine("       🎲 DICE CHALLENGE 🎲");
        Console.WriteLine("================================");
        Console.WriteLine();

        do
        {
            int rollnum = RollNum();
            int target = TargetNumber();

            Console.WriteLine("🎯 Target number: " + target);

            Console.WriteLine("🎲 Rolling the dice...");
            Thread.Sleep(700);

            Console.WriteLine("🎲 You rolled: " + rollnum);
            Console.WriteLine();

            if (rollnum > target)
            {
                Console.WriteLine("🎉🎉 YOU WIN! 🎉🎉");
            }
            else
            {
                Console.WriteLine("😢 YOU LOSE!");
            }

            Console.WriteLine("--------------------------------");

        } while (ShouldPlay());

        Console.WriteLine();
        Console.WriteLine("================================");
        Console.WriteLine("   👋 GAME ENDED - THANK YOU!");
        Console.WriteLine("================================");
    }

    public static bool ShouldPlay()
    {
        Console.WriteLine("Do you want to play again? (yes/no)");
        string answer = Console.ReadLine();

        return answer.ToLower() == "yes";
    }
}