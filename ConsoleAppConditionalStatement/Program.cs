//prompt a user to enter value
Console.WriteLine("********************************************Start of If statement**************************");

Console.WriteLine("Enter your Score: ");
int grade = Convert.ToInt32(Console.ReadLine());

//Make a decision based on the grade

if (grade > 50)
{
    Console.WriteLine("You have passed");
}
else
{
    Console.WriteLine("You have failed");
    Console.WriteLine("Contact student affairs");
};
Console.WriteLine("********************************************End if**************************");
Console.WriteLine();
Console.WriteLine("********************************************Start Else IF**************************");

//else if statement

if (grade >= 75)
{
    Console.WriteLine("You have passed with a distinction");
}
else if (grade > 50)
{
    Console.WriteLine("well done");
    
}
else 
{
    Console.WriteLine("You have failed");
    Console.WriteLine("Contact student affairs");

};
Console.WriteLine("********************************************End if Else**************************");
Console.WriteLine();
Console.WriteLine("********************************************Start of if Statements with && and ||**************************");
/*
 * A: 85-100
 * B: 75-84
 * C: 65-74
 * D: 50-64
 * F: <50
 
 
 */
if (grade >= 85 && grade <= 100)
{
    Console.WriteLine("You have passed with a distinction");
    if (grade == 99 || grade == 100)
    {
        Console.WriteLine("Well done, you are a star");
    }
}
else if (grade >= 75 && grade <= 84)
{
    Console.WriteLine("well done");
}

else if (grade >= 65 && grade <= 74)
{
Console.WriteLine("well done");
}
else if (grade >= 50 && grade <=64)
{
    Console.WriteLine("well done");
}
else if (grade >= 0 && grade <= 49)
{
    Console.WriteLine("You have failed");
    Console.WriteLine("Contact student affairs");
}
else
{
    Console.WriteLine("You have entered an invalid number");    
};
Console.WriteLine("********************************************End of if Statements with && and || **************************");
Console.WriteLine();
Console.WriteLine("********************************************Start of Ternary operator **************************");
string gradeStatus = grade > 50 ? "Passed" : "Failed";
 Console.WriteLine($"the student: {gradeStatus}");
    
Console.WriteLine("********************************************End of Ternary operator **************************");
Console.WriteLine();
Console.WriteLine("********************************************Start of Switch statement **************************");
/*
  Write a code that prompts user
  for an integer between 1 and 7
  and return the day of the week.

    1 - monday
    2 - tuesday
    3 - wensday
    4 - thursday
    5 - friday
    6 - saturday
    7 - sunday

 */
Console.WriteLine("Enter a number between 1 and 7 representing a day");
int dayOfTheWeek = Convert.ToInt32(Console.ReadLine()); 

switch(dayOfTheWeek)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wensday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default: 
        Console.WriteLine("Invalid number entered");
        break;
}


Console.WriteLine("********************************************End of Switch statement **************************");
