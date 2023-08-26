/*
This application will take information about daily task count as user input, multiply it by task rate, then
calculate and return daily earnings. 
ideas:
ask about date
return daily earnings in file/udpdate file
make menu to modify tasks rates etc.
change earnings usd to local currency
*/

// search 2.0 task rates in Polish locale

using System.ComponentModel.DataAnnotations;

double[] tasksRates = 
{
    0.206, 0.228, 0.263, 0.297, 0.331, 0.434, 0.468, 0.502, 0.537, 0.639,
    0.674, 0.708, 0.742, 0.845, 0.879, 0.913, 1.050, 1.085, 1.256
};
/*
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
*/








// defining search2.0 count variables
string userInput = "";
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
//int search2_90_count = Convert.ToInt32(Console.ReadLine());


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

//int search2_100_count = Convert.ToInt32(Console.ReadLine());

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
//int search2_115_count = Convert.ToInt32(Console.ReadLine());
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
//int search2_130_count = Convert.ToInt32(Console.ReadLine());

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
//int search2_145_count = Convert.ToInt32(Console.ReadLine());

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
//int search2_190_count = Convert.ToInt32(Console.ReadLine());

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
//int search2_205_count = Convert.ToInt32(Console.ReadLine());

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
//int search2_220_count = Convert.ToInt32(Console.ReadLine());

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
//int search2_235_count = Convert.ToInt32(Console.ReadLine());

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
//int search2_280_count = Convert.ToInt32(Console.ReadLine());

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
//int search2_295_count = Convert.ToInt32(Console.ReadLine());

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
//int search2_310_count = Convert.ToInt32(Console.ReadLine());

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
//int search2_325_count = Convert.ToInt32(Console.ReadLine());

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
//int search2_370_count = Convert.ToInt32(Console.ReadLine());

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
//int search2_385_count = Convert.ToInt32(Console.ReadLine());

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
//int search2_400_count = Convert.ToInt32(Console.ReadLine());

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
//int search2_460_count = Convert.ToInt32(Console.ReadLine());

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
//int search2_475_count = Convert.ToInt32(Console.ReadLine());

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
//int search2_550_count = Convert.ToInt32(Console.ReadLine());


// Final daily earnings
double earnings = 0;
double product = 0.000;

for (int i = 0; i< 19; i++)
{
    product = taskCount[i] * tasksRates[i]; 
    earnings += product;
}

Console.WriteLine($"Today earnings {earnings} usd");