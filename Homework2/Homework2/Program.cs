﻿string x = Console.ReadLine();
int val = Convert.ToInt32(x);


int firstVal = val / 10000; // 7 
int secondVal = val / 1000 - (firstVal * 10); // 5
int thirdVal = val / 100 - (firstVal * 100 + secondVal * 10); // 3  
int forthVal = val / 10 - (firstVal * 1000 + secondVal * 100 + thirdVal * 10);
int fivesVal = val - (firstVal * 10000 + secondVal * 1000 + thirdVal * 100 + forthVal * 10);


Console.WriteLine(firstVal);
Console.WriteLine(secondVal);
Console.WriteLine(thirdVal);
Console.WriteLine(forthVal);
Console.WriteLine(fivesVal);
Console.ReadLine();

