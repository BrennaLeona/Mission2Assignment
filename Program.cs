using Mission2Assignment;

public class Program
{
    private static void Main(string[] args)
    {
        RollDie rd = new RollDie();

        int numrolls = 0;
        
        System.Console.WriteLine("Welcome to the dice throwing simulator!");
        System.Console.WriteLine("How many dice rolls would you like to simulate?");
        numrolls = int.Parse(System.Console.ReadLine());

        int[] results = rd.RollDice(numrolls);
        int[] atrkPer = new int[13];


        System.Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        System.Console.WriteLine("Each '*' represents 1% of the total number of rolls.");
        System.Console.WriteLine("Total number of rolls = " + numrolls);

        for (int iCount = 2; iCount < results.Length; iCount++)
        {
            atrkPer[iCount] = (results[iCount] *100 / numrolls);
            System.Console.Write((iCount) + ": ");

            for (int iCount2 = 2; iCount2 < atrkPer[iCount]; iCount2++)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine();
        }

        System.Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }
}