Console.WriteLine("*********** HELLOOO!! WELCOME TO THE SIMPLE CALCULATER ***********");
Console.WriteLine();

Console.WriteLine("+: for addition");
Console.WriteLine("-: for subtraction");
Console.WriteLine("x: for multiplication");
Console.WriteLine("/: for division");
Console.WriteLine("1: Fibonnacci Sequence");
int choice = 0;
while(choice !=-1)
{
    Console.Write("Enter  the first number : ");
    decimal num1 = Convert.ToDecimal(Console.ReadLine());
    Console.Write("Enter an operation : ");
    string operatoration = Convert.ToString(Console.ReadLine()).ToLower();
    Console.WriteLine("We are almost there");
    Console.Write("Now Enter the second number: ");

    decimal num2 = Convert.ToDecimal(Console.ReadLine());
    decimal result = 0;

    switch (operatoration)
    {
        case "+":
            Console.WriteLine($"The answer of {num1} + {num2} = {num1 + num2}");
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
        case "1":
            Console.WriteLine();
            for (decimal i = num1; i <= num2; i++)
            {
                result += i;
                if (i == num2)
                {
                    Console.WriteLine($"The result is : {result}");
                }
            }
            break;
        default:
            Console.WriteLine($"{operatoration} is an invalid operator.");
            Console.WriteLine($"Enter the right symbol associated with the operator .");
            break;
    }

    Console.WriteLine("Press 0 to continue using the calculator or -1 to exit");
    choice = Convert.ToInt32(Console.ReadLine());
    // to cleanup the console
    Console.Clear();
    Console.WriteLine("+: for addition");
    Console.WriteLine("-: for subtraction");
    Console.WriteLine("x: for multiplication");
    Console.WriteLine("/: for division");
    Console.WriteLine("1: Fibonnacci Sequence");
    Console.WriteLine();
}
Console.Clear();    
Console.WriteLine("*********** THANK YOU FOR USING THE SIMPLE CALCULATER ***********");





