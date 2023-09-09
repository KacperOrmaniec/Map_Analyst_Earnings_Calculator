
/*
This application is asking user about daily/monthly task count in Telus, then calculates the earnings
with possibility to change earnings currency to locale currency (Available currencies: usd)
ideas:

make menu to modify tasks rates etc.

ask about date - return daily earnings in file/udpdate file


change earnings usd to local currency
*/


using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;

internal class Program
{
    public static void Main(string[] args)
    {
        double totalEarnings = 0.00;



        // Creating a basic application menu
        string? menuSelection = "";

        do
        {
            Console.WriteLine("\nWelcome to Telus Earnings Calculator!\n\nHere are available options:");
            Console.WriteLine("1. Earnings Calculator\n2. Task Rates\n3. Exit\n4. ! Work in Progress !");

            Console.WriteLine("\nPlease select an option number: ");
            menuSelection = Console.ReadLine();

            switch (menuSelection)
            {
                case "1":

                    string? typeSelection = "";
                    do
                    {
                        string? subMenuSelection = "";

                        Console.WriteLine("\nPlease choose task type:\n1. Search2.0\n2. Name Evaluation");
                        typeSelection = Console.ReadLine();

                        switch (typeSelection)
                        {
                            case "1":
                                totalEarnings += search2EarningsCount();

                                Console.WriteLine("\nWould you like to add another task type?\n1. Yes\n2. No");
                                subMenuSelection = Console.ReadLine();

                                if (subMenuSelection == "2")
                                {
                                    typeSelection = "exit";
                                }

                                break;
                            case "2":
                                totalEarnings += NameEvaluationEarningsCount();
                                
                                Console.WriteLine("\nWould you like to add another task type?\n1. Yes\n2. No");
                                subMenuSelection = Console.ReadLine();

                                if (subMenuSelection == "2")
                                {
                                    typeSelection = "exit";
                                }

                                break;
                        }
                    } while (typeSelection != "exit");
                    Console.Clear();
                    Console.WriteLine($"Total earnings {totalEarnings} usd\nPress Enter to continue");
                    Console.Read();
                    Console.Clear();
                    break;
                case "2":
                    break;
                case "3":
                    menuSelection = "exit";
                    break;
            }
        } while (menuSelection != "exit");

    static double search2EarningsCount()
    {

        // Variables for counting earnings
        double earnings = 0;
        double product = 0.00;

        // Defining search2.0 task rates in usd (The example rates are for polish locale
        double search2_90_rate = 0.206;
        double search2_100_rate = 0.228;
        double search2_115_rate = 0.263;
        double search2_130_rate = 0.297;
        double search2_145_rate = 0.331;
        double search2_190_rate = 0.434;
        double search2_205_rate = 0.468;
        double search2_220_rate = 0.502;
        double search2_235_rate = 0.537;
        double search2_280_rate = 0.639;
        double search2_295_rate = 0.674;
        double search2_310_rate = 0.708;
        double search2_325_rate = 0.742;
        double search2_370_rate = 0.845;
        double search2_385_rate = 0.879;
        double search2_400_rate = 0.913;
        double search2_460_rate = 1.050;
        double search2_475_rate = 1.085;
        double search2_550_rate = 1.256;
        
        double[] search2TasksRates =
        {
        search2_90_rate, search2_100_rate, search2_115_rate, search2_130_rate, search2_145_rate,
        search2_190_rate, search2_205_rate, search2_220_rate, search2_235_rate, search2_280_rate,
        search2_295_rate, search2_310_rate, search2_325_rate, search2_370_rate, search2_385_rate,
        search2_400_rate, search2_460_rate, search2_475_rate, search2_550_rate,
        };

        string? userInput = "";
        int[] taskCount = new int[19];
        int val = 0;
        Console.WriteLine("Insert search2.0 90 seconds task count:");

        userInput = Console.ReadLine();


        if (userInput != "")
        {
            taskCount[val] = Convert.ToInt32(userInput);
        }

        else
        {
            taskCount[val] = 0;
        }
        val++;


        Console.WriteLine("Insert search2.0 100 seconds task count:");

        userInput = Console.ReadLine();

        if (userInput != "")
        {
            taskCount[val] = Convert.ToInt32(userInput);
        }

        else
        {
            taskCount[val] = 0;
        }
        val++;


        Console.WriteLine("Insert search2.0 115 seconds task count:");

        userInput = Console.ReadLine();

        if (userInput != "")
        {
            taskCount[val] = Convert.ToInt32(userInput);
        }

        else
        {
            taskCount[val] = 0;
        }
        val++;


        Console.WriteLine("Insert search2.0 130 seconds task count:");

        userInput = Console.ReadLine();

        if (userInput != "")
        {
            taskCount[val] = Convert.ToInt32(userInput);
        }

        else
        {
            taskCount[val] = 0;
        }
        val++;


        Console.WriteLine("Insert search2.0 145 seconds task count:");

        userInput = Console.ReadLine();

        if (userInput != "")
        {
            taskCount[val] = Convert.ToInt32(userInput);
        }

        else
        {
            taskCount[val] = 0;
        }
        val++;


        Console.WriteLine("Insert search2.0 190 seconds task count:");

        userInput = Console.ReadLine();

        if (userInput != "")
        {
            taskCount[val] = Convert.ToInt32(userInput);
        }

        else
        {
            taskCount[val] = 0;
        }
        val++;


        Console.WriteLine("Insert search2.0 205 seconds task count:");

        userInput = Console.ReadLine();

        if (userInput != "")
        {
            taskCount[val] = Convert.ToInt32(userInput);
        }

        else
        {
            taskCount[val] = 0;
        }
        val++;


        Console.WriteLine("Insert search2.0 220 seconds task count:");

        userInput = Console.ReadLine();

        if (userInput != "")
        {
            taskCount[val] = Convert.ToInt32(userInput);
        }

        else
        {
            taskCount[val] = 0;
        }
        val++;


        Console.WriteLine("Insert search2.0 235 seconds task count:");

        userInput = Console.ReadLine();

        if (userInput != "")
        {
            taskCount[val] = Convert.ToInt32(userInput);
        }

        else
        {
            taskCount[val] = 0;
        }
        val++;


        Console.WriteLine("Insert search2.0 280 seconds task count:");

        userInput = Console.ReadLine();

        if (userInput != "")
        {
            taskCount[val] = Convert.ToInt32(userInput);
        }

        else
        {
            taskCount[val] = 0;
        }
        val++;


        Console.WriteLine("Insert search2.0 295 seconds task count:");

        userInput = Console.ReadLine();

        if (userInput != "")
        {
            taskCount[val] = Convert.ToInt32(userInput);
        }

        else
        {
            taskCount[val] = 0;
        }
        val++;


        Console.WriteLine("Insert search2.0 310 seconds task count:");

        userInput = Console.ReadLine();

        if (userInput != "")
        {
            taskCount[val] = Convert.ToInt32(userInput);
        }

        else
        {
            taskCount[val] = 0;
        }
        val++;


        Console.WriteLine("Insert search2.0 325 seconds task count:");

        userInput = Console.ReadLine();

        if (userInput != "")
        {
            taskCount[val] = Convert.ToInt32(userInput);
        }

        else
        {
            taskCount[val] = 0;
        }
        val++;


        Console.WriteLine("Insert search2.0 370 seconds task count:");

        userInput = Console.ReadLine();

        if (userInput != "")
        {
            taskCount[val] = Convert.ToInt32(userInput);
        }

        else
        {
            taskCount[val] = 0;
        }
        val++;


        Console.WriteLine("Insert search2.0 385 seconds task count:");

        userInput = Console.ReadLine();

        if (userInput != "")
        {
            taskCount[val] = Convert.ToInt32(userInput);
        }

        else
        {
            taskCount[val] = 0;
        }
        val++;


        Console.WriteLine("Insert search2.0 400 seconds task count:");

        userInput = Console.ReadLine();

        if (userInput != "")
        {
            taskCount[val] = Convert.ToInt32(userInput);
        }

        else
        {
            taskCount[val] = 0;
        }
        val++;


        Console.WriteLine("Insert search2.0 460 seconds task count:");

        userInput = Console.ReadLine();

        if (userInput != "")
        {
            taskCount[val] = Convert.ToInt32(userInput);
        }

        else
        {
            taskCount[val] = 0;
        }
        val++;


        Console.WriteLine("Insert search2.0 475 seconds task count:");

        userInput = Console.ReadLine();

        if (userInput != "")
        {
            taskCount[val] = Convert.ToInt32(userInput);
        }

        else
        {
            taskCount[val] = 0;
        }
        val++;


        Console.WriteLine("Insert search2.0 550 seconds task count:");

        userInput = Console.ReadLine();

        if (userInput != "")
        {
            taskCount[val] = Convert.ToInt32(userInput);
        }

        else
        {
            taskCount[val] = 0;
        }
        val++;

        // Search2.0 earnings count

        for (int i = 0; i < 19; i++)
        {
            product = taskCount[i] * search2TasksRates[i];
            earnings += product;
        }

        return earnings;
    }
    static double NameEvaluationEarningsCount()
    {
        // Variables for counting earnings
        double earnings = 0;
        double product = 0.00;

        double NameEvaluationTaskRate = 0.274;
        string? userInput = "";
        int[] taskCount = new int[1];
        int val = 0;

        Console.WriteLine("Insert Name Rvaluation task count:");
        userInput = Console.ReadLine();


        if (userInput != "")
        {
            taskCount[val] = Convert.ToInt32(userInput);
        }

        else
        {
            taskCount[val] = 0;
        }
        val++;

        // Name Evaluation earnings count

        for (int i = 0; i < 1; i++)
        {
            product = taskCount[i] * NameEvaluationTaskRate;
            earnings += product;
        }
        return earnings;
    }



    }
}