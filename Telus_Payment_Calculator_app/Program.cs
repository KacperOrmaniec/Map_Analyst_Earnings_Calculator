
/*
This application is asking user about daily/monthly task count in Telus, then calculates the earnings
with possibility to change earnings currency to locale currency (Available currencies: usd)
ideas:

make menu to modify tasks rates etc.

change earnings usd to local currency
*/


using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

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

                        Console.WriteLine("\nPlease choose task type:\n1. Search2.0\n2. Name Evaluation\n3. POI Evaluation\n4. Autocomplete");
                        Console.WriteLine("5. Search SBS\n6. Address Verification\n7. Search Ads Close Variants\n8. POI with Corrections (2 Pins)");
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
                            case "3":
                                totalEarnings += POIEvaluationEarningsCount();
                                
                                Console.WriteLine("\nWould you like to add another task type?\n1. Yes\n2. No");
                                subMenuSelection = Console.ReadLine();

                                if (subMenuSelection == "2")
                                {
                                    typeSelection = "exit";
                                }

                                break;
                            case "4":
                                totalEarnings += autocompleteEarningsCount();
                                
                                Console.WriteLine("\nWould you like to add another task type?\n1. Yes\n2. No");
                                subMenuSelection = Console.ReadLine();

                                if (subMenuSelection == "2")
                                {
                                    typeSelection = "exit";
                                }

                                break;    
                            case "5":
                                totalEarnings += SearchSbsEarningsCount();
                                
                                Console.WriteLine("\nWould you like to add another task type?\n1. Yes\n2. No");
                                subMenuSelection = Console.ReadLine();

                                if (subMenuSelection == "2")
                                {
                                    typeSelection = "exit";
                                }

                                break;
                            case "6":
                                totalEarnings += addressVerificationEarningsCount();
                                
                                Console.WriteLine("\nWould you like to add another task type?\n1. Yes\n2. No");
                                subMenuSelection = Console.ReadLine();

                                if (subMenuSelection == "2")
                                {
                                    typeSelection = "exit";
                                }

                                break;
                            case "7":
                                totalEarnings += SearchAdsCVEarningsCount();
                                
                                Console.WriteLine("\nWould you like to add another task type?\n1. Yes\n2. No");
                                subMenuSelection = Console.ReadLine();

                                if (subMenuSelection == "2")
                                {
                                    typeSelection = "exit";
                                }

                                break;
                            case "8":
                                totalEarnings += POIwCorrectionsEarningsCount();
                                
                                Console.WriteLine("\nWould you like to add another task type?\n1. Yes\n2. No");
                                subMenuSelection = Console.ReadLine();

                                if (subMenuSelection == "2")
                                {
                                    typeSelection = "exit";
                                }

                                break;   
                        }
                    } while (typeSelection != "exit");
                    string decimalTotalEarnings = String.Format("{0:0.00}", totalEarnings);
                    Console.Clear();
                    Console.WriteLine($"Total earnings {decimalTotalEarnings} usd\nPress Enter to continue");
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


    static double POIEvaluationEarningsCount()
    {

        // Variables for counting earnings
        double earnings = 0;
        double product = 0.00;    

        // Defining POI Evaluation task rates in usd (The example rates are for polish locale)
        double POIEvaluation_120_rate =0.274;
        double POIEvaluation_330_rate =0.754;
        double POIEvaluation_345_rate =0.788;
        double POIEvaluation_375_rate =0.856;
        double POIEvaluation_420_rate =0.959;

        double[] POIEvaluationTasksRates =
        {
            POIEvaluation_120_rate, POIEvaluation_330_rate, POIEvaluation_345_rate, 
            POIEvaluation_375_rate, POIEvaluation_420_rate
        };

        string? userInput = "";
        int[] taskCount = new int[5];
        int val = 0;

        Console.WriteLine("Insert POI Evaluation 120 seconds task count:");

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


        Console.WriteLine("Insert POI Evaluation 330 seconds task count:");

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

        
        Console.WriteLine("Insert POI Evaluation 345 seconds task count:");

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

        
        Console.WriteLine("Insert POI Evaluation 375 seconds task count:");

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

        
        Console.WriteLine("Insert POI Evaluation 420 seconds task count:");

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

        
        // POI Evaluation earnings count

        for (int i = 0; i < 1; i++)
        {
            product = taskCount[i] * POIEvaluationTasksRates[i];
            earnings += product;
        }
        return earnings;
    }

    static double search2EarningsCount()
    {

        // Variables for counting earnings
        double earnings = 0;
        double product = 0.00;

        // Defining search2.0 task rates in usd (The example rates are for polish locale)
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


    static double addressVerificationEarningsCount()
    {
        // Variables for counting earnings
        double earnings = 0;
        double product = 0.00;

        double addressVerification_135_rate = 0.378;
        double addressVerification_210_rate = 0.588;

        double[] addressVerificationTaskRate =
        {
            addressVerification_135_rate, addressVerification_210_rate
        };
        string? userInput = "";
        int[] taskCount = new int[2];
        int val = 0;

        Console.WriteLine("Insert Address Verification 135 seconds task count:");
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

        Console.WriteLine("Insert Address Verification 210 seconds task count:");
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

        for (int i = 0; i < 2; i++)
        {
            product = taskCount[i] * addressVerificationTaskRate[i];
            earnings += product;
        }
        return earnings;
    }




    static double autocompleteEarningsCount()
    {
        // Variables for counting earnings
        double earnings = 0;
        double product = 0.00;

        double autocomplete_90_rate = 0.203;
        double autocomplete_100_rate = 0.225;
        double autocomplete_115_rate = 0.259;
        double autocomplete_190_rate = 0.427;
        double autocomplete_295_rate = 0.664;
        double autocomplete_370_rate = 0.832;
        double autocomplete_550_rate = 1.237;
        double autocomplete_835_rate = 1.879;
        double autocomplete_910_rate = 2.047;
        

        double[] autocompleteTaskRate =
        {
            autocomplete_90_rate, autocomplete_100_rate, autocomplete_115_rate, autocomplete_190_rate,
            autocomplete_295_rate, autocomplete_370_rate, autocomplete_550_rate, autocomplete_835_rate,
            autocomplete_910_rate
        };
        string? userInput = "";
        int[] taskCount = new int[9];
        int val = 0;

        Console.WriteLine("Insert Autocomplete 90 seconds task count:");
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



        Console.WriteLine("Insert Autocomplete 100 seconds task count:");
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


        Console.WriteLine("Insert Autocomplete 115 seconds task count:");
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


        Console.WriteLine("Insert Autocomplete 190 seconds task count:");
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


        Console.WriteLine("Insert Autocomplete 295 seconds task count:");
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


        Console.WriteLine("Insert Autocomplete 370 seconds task count:");
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


        Console.WriteLine("Insert Autocomplete 550 seconds task count:");
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


        Console.WriteLine("Insert Autocomplete 835 seconds task count:");
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
        


        Console.WriteLine("Insert Autocomplete 910 seconds task count:");
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



        // Autocomplete earnings count

        for (int i = 0; i < 9; i++)
        {
            product = taskCount[i] * autocompleteTaskRate[i];
            earnings += product;
        }
        return earnings;
    }




    static double POIwCorrectionsEarningsCount()
    {
        // Variables for counting earnings
        double earnings = 0;
        double product = 0.00;

        double POIwCorrections_180_rate = 0.411;
        double POIwCorrections_300_rate = 0.685;

        double[] POIwCorrectionsTaskRate =
        {
            POIwCorrections_180_rate, POIwCorrections_300_rate
        };
        string? userInput = "";
        int[] taskCount = new int[2];
        int val = 0;

        Console.WriteLine("Insert POI with Corrections 180 seconds task count:");
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

        Console.WriteLine("Insert POI with Corrections 300 seconds task count:");
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

        // POI with Corrections earnings count

        for (int i = 0; i < 2; i++)
        {
            product = taskCount[i] * POIwCorrectionsTaskRate[i];
            earnings += product;
        }
        return earnings;
    }    


    static double SearchAdsCVEarningsCount()
    {
        // Variables for counting earnings
        double earnings = 0;
        double product = 0.00;

        double SearchAdsCV_45_rate = 0.103;
        double SearchAdsCV_135_rate = 0.308;
        double SearchAdsCV_315_rate = 0.719;
        double SearchAdsCV_405_rate = 0.925;
        double SearchAdsCV_450_rate = 1.028;
        

        double[] SearchAdsCVTaskRate =
        {
            SearchAdsCV_45_rate, SearchAdsCV_135_rate, SearchAdsCV_315_rate,
            SearchAdsCV_405_rate, SearchAdsCV_450_rate
        };
        string? userInput = "";
        int[] taskCount = new int[5];
        int val = 0;

        Console.WriteLine("Insert Search Ads Close Variants 45 seconds task count:");
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


        Console.WriteLine("Insert Search Ads Close Variants 135 seconds task count:");
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


        Console.WriteLine("Insert Search Ads Close Variants 315 seconds task count:");
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


        Console.WriteLine("Insert Search Ads Close Variants 405 seconds task count:");
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


        Console.WriteLine("Insert Search Ads Close Variants 450 seconds task count:");
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


        
        // Search Ads Close Variants earnings count

        for (int i = 0; i < 5; i++)
        {
            product = taskCount[i] * SearchAdsCVTaskRate[i];
            earnings += product;
        }
        return earnings;
    } 


    static double SearchSbsEarningsCount()
    {
        // Variables for counting earnings
        double earnings = 0;
        double product = 0.00;

        double SearchSbs_60_rate = 0.137;
        double SearchSbs_80_rate = 0.183;
        double SearchSbs_90_rate = 0.206;
        double SearchSbs_120_rate = 0.274;
        double SearchSbs_160_rate = 0.365;
        double SearchSbs_180_rate = 0.411;
        double SearchSbs_240_rate = 0.548;
        double SearchSbs_300_rate = 0.685;
        double SearchSbs_320_rate = 0.731;
        double SearchSbs_360_rate = 0.822;
        double SearchSbs_420_rate = 0.959;
        double SearchSbs_480_rate = 1.096;
        double SearchSbs_540_rate = 1.233;
        double SearchSbs_600_rate = 1.370;

        double[] SearchSbsTaskRate =
        {
            SearchSbs_60_rate, SearchSbs_80_rate, SearchSbs_90_rate, SearchSbs_120_rate,
            SearchSbs_160_rate, SearchSbs_180_rate, SearchSbs_240_rate, SearchSbs_300_rate,
            SearchSbs_320_rate, SearchSbs_360_rate, SearchSbs_420_rate, SearchSbs_480_rate,
            SearchSbs_540_rate, SearchSbs_600_rate
        };


        string? userInput = "";
        int[] taskCount = new int[14];
        int val = 0;

        Console.WriteLine("Insert Searcb SBS 60 seconds task count:");
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


        Console.WriteLine("Insert Searcb SBS 80 seconds task count:");
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


        Console.WriteLine("Insert Searcb SBS 90 seconds task count:");
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


        Console.WriteLine("Insert Searcb SBS 120 seconds task count:");
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


        Console.WriteLine("Insert Searcb SBS 160 seconds task count:");
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


        Console.WriteLine("Insert Searcb SBS 180 seconds task count:");
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


        Console.WriteLine("Insert Searcb SBS 240 seconds task count:");
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


        Console.WriteLine("Insert Searcb SBS 300 seconds task count:");
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


        Console.WriteLine("Insert Searcb SBS 320 seconds task count:");
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


        Console.WriteLine("Insert Searcb SBS 360 seconds task count:");
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


        Console.WriteLine("Insert Searcb SBS 420 seconds task count:");
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


        Console.WriteLine("Insert Searcb SBS 480 seconds task count:");
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


        Console.WriteLine("Insert Searcb SBS 540 seconds task count:");
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


        Console.WriteLine("Insert Searcb SBS 600 seconds task count:");
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


        
        // Search SBS earnings count

        for (int i = 0; i < 14; i++)
        {
            product = taskCount[i] * SearchSbsTaskRate[i];
            earnings += product;
        }
        return earnings;
    }    
    }
}
