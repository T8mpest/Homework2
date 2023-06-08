string x = Console.ReadLine();
int val = Convert.ToInt32(x);

int firstVal = val / 10000; 
int secondVal = val / 1000 - (firstVal * 10); 
int thirdVal = val / 100 - (firstVal * 100 + secondVal * 10);  
int forthVal = val / 10 - (firstVal * 1000 + secondVal * 100 + thirdVal * 10);
int fivesVal = val - (firstVal * 10000 + secondVal * 1000 + thirdVal * 100 + forthVal * 10);
Console.WriteLine();
Console.WriteLine(firstVal);
Console.WriteLine();
Console.WriteLine(secondVal);
Console.WriteLine();
Console.WriteLine(thirdVal);
Console.WriteLine();
Console.WriteLine(forthVal);
Console.WriteLine();
Console.WriteLine(fivesVal);
Console.WriteLine();
Console.ReadLine();
// i dont understand about spaces in home work , what does it mean, and am i doing right ? i hope yeah, if not pls say me what`s wrong , thank u
