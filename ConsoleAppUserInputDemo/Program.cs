//Declare variable
string name = string.Empty;
int age = 0;
int retirementAge = 65;
//prompt user for input
Console.WriteLine("Please enter your name");
name = Console.ReadLine();
Console.WriteLine("Please enter your Age");
age = Convert.ToInt32(Console.ReadLine());

//Process data
int workingYearsRemaining = retirementAge - age;
Console.WriteLine($"Full name: {name}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"working years remaining: {workingYearsRemaining}");





