//Declare variable
string firstName = string.Empty;
string lastName = string.Empty;
int age = 0;
int retirementAge = 65;
//prompt user for input
Console.WriteLine("Please enter your Firstname");
firstName = Console.ReadLine();
Console.WriteLine("Please enter your Lastname");
lastName = Console.ReadLine();
Console.WriteLine("Please enter your Age");
age = Convert.ToInt32(Console.ReadLine());

//Process data
int workingYearsRemaining = retirementAge - age;
Console.WriteLine($"Full name: {firstName} {lastName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"working years remaining: {workingYearsRemaining}");
