string x = Console.ReadLine();
int val = Convert.ToInt32(x);
var condition = val >= 10000 && val <= 99999; 
if (condition)
{

    int firstVal = val / 10000;
    int secondVal = val / 1000 - (firstVal * 10);
    int thirdVal = val / 100 - (firstVal * 100 + secondVal * 10);
    int forthVal = val / 10 - (firstVal * 1000 + secondVal * 100 + thirdVal * 10);
    int fivesVal = val - (firstVal * 10000 + secondVal * 1000 + thirdVal * 100 + forthVal * 10);
    Console.WriteLine($"{firstVal} {secondVal} {thirdVal} {forthVal} {fivesVal}");
    Console.ReadLine();
}
else
{
    Console.WriteLine($"Error.The number {val} not in a range [10000-99999]");
    Console.ReadLine();
}


