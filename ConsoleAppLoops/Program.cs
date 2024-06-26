//Print a program that prints
//Hello world ten times
Console.WriteLine("********************************************Unsing for loops**************************");

Console.WriteLine("How many time should we print 'Helllo, World' ?");
int counter = Convert.ToInt32(Console.ReadLine());  
for(int i = 0; i < counter; i++)
{
    Console.WriteLine($"Hello world");
}

Console.WriteLine("********************************************End for loop**************************");
Console.WriteLine("");
Console.WriteLine("********************************************Start of while loop**************************");
 // ask user for a number and find the total for each number that is entered

Console.WriteLine("Hello there!!, lets play a game of sums.");
Console.WriteLine("This is how you play it.");
Console.WriteLine("Enter a number after each turn,");
Console.WriteLine("Once you are done enter -1.");
Console.WriteLine("Then I will give you the sum");
Console.WriteLine("Are you read let's go!!");
int whileCount =0;
int sum = 0;
Console.WriteLine("Enter a number");
while(whileCount != -1)
{
    sum += whileCount;
    whileCount = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter another number or -1 to exit :");

}
Console.WriteLine($"Greate the total sum is : {sum}");

Console.WriteLine("********************************************End of while loop**************************");

