
decimal num1, num2, result = 0;
string operatorHolder = string.Empty;
int choice = 0;
while(choice !=-1)
{
    Console.WriteLine("*********** HELLOOO!! WELCOME TO THE SIMPLE CALCULATER ***********");
    Console.WriteLine();

    Console.WriteLine("+: for addition");
    Console.WriteLine("-: for subtraction");
    Console.WriteLine("x: for multiplication");
    Console.WriteLine("/: for division");
    Console.WriteLine("1: Fibonnacci Sequence");

    try
    {
        Console.Write("Enter  the first number : ");
        num1 = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Enter an operation : ");

        operatorHolder = Convert.ToString(Console.ReadLine()).ToLower();
        Console.Write("Now Enter the second number: ");
        num2 = Convert.ToDecimal(Console.ReadLine());

        switch (operatorHolder)
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

                Console.WriteLine($"{operatorHolder} is an invalid operator.");
                Console.WriteLine($"Enter the right symbol associated with the operator .");
                /*
                 * alternative is 
                        throw new Exception($"{operatorHolder} is an invalid operator.");
                 */
                break;
        }
        Console.WriteLine("Press 0 to continue using the calculator or -1 to exit");
        choice = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Division by zero is not allowed");
    }
    catch (Exception)
    {
        Console.WriteLine("Invalid input");

    }
    finally
    {
        Console.WriteLine("Press any key to continue");
        Console.ReadLine();
        Console.Clear();
    }
    /*
     * Alternatively you would have
     * this takes in the exception you threw to ex
        catch(Exception ex)
    {
        Console.WriteLine("Invalid input");
        Console.WriteLine(ex.Message);//show the message
        Console.WriteLine("Press any key to continue");
        Console.ReadLine();
        Console.Clear();
    }
     */



    // to cleanup the console


}
Console.Clear();    
Console.WriteLine("*********** THANK YOU FOR USING THE SIMPLE CALCULATER ***********");





