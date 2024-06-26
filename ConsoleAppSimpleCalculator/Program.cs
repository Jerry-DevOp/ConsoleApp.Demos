Console.WriteLine("*********** HELLOOO!! WELCOME TO THE SIMPLE CALCULATER ***********");
Console.WriteLine();
Console.WriteLine("Enter  the first number :");
decimal num1 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Enter an operation");
Console.WriteLine("+: for addition");
Console.WriteLine("-: for subtraction");
Console.WriteLine("x: for multiplication");
Console.WriteLine("/: for division");
string operatoration = Convert.ToString(Console.ReadLine()).ToLower();

Console.WriteLine("We are almost there");
Console.WriteLine("Now Enter the second number: ");
decimal num2 = Convert.ToDecimal(Console.ReadLine());

switch(operatoration)
{
    case "+":
        Console.WriteLine($"The answer of {num1} + {num2} = {num1+num2}");
        break;
    case "-":
        Console.WriteLine($"The answer of {num1} - {num2} = {num1 - num2}");
        break;
    case "x":
        Console.WriteLine($"The answer of {num1} x {num2} = {num1 * num2}");
        break;
    case "/":
        Console.WriteLine($"The answer of {num1} / {num2} = {num1 / num2}");
        break;
    default:
        Console.WriteLine($"{operatoration} is an invalid operator.");
        Console.WriteLine($"Enter the right symbol associated with the operator .");
        break;
}

