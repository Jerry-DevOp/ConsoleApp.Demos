//Declare variable
string firstName = string.Empty;
string lastName = string.Empty;
int age = 0;
int retirementAge = 65;
decimal salary = 0;
char gender = char.MinValue;
// bool automatically takes the value of false
bool working = true;

//prompt user for input
Console.WriteLine("Please enter your Firstname");
firstName = Console.ReadLine();

Console.WriteLine("Please enter your Lastname");
lastName = Console.ReadLine();

Console.WriteLine("Please enter your Age");
age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter your salary");
salary = Convert.ToDecimal(Console.ReadLine());


Console.WriteLine("Please enter your gender(M or F)");
gender = Convert.ToChar(Console.ReadLine());

Console.WriteLine("are you currently working?(true or false)");
working = Convert.ToBoolean(Console.ReadLine());


//Process data
int workingYearsRemaining = retirementAge - age;
Console.WriteLine($"Full name: {firstName} {lastName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"You are currently learning: {salary}");
Console.WriteLine($"Your gender is : {gender}");
Console.WriteLine($"Your employment status is : {working}");
Console.WriteLine($"Number of working years remaining: {workingYearsRemaining}");
