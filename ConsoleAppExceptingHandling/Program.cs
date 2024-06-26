/* Write a user program that takes age  
 * an input and prints it to the screen
 * Display an error message if an invalid
    inpput received
*/

try 
{
    Console.Write("How old are you? :");
    int age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Hi you are, {age} old");
}
catch(Exception)
{
    Console.WriteLine("You have entered an invalid value try again");
    //throw;
    // will show the error on the console
    //
}
finally// this block executes no matter what
{
    Console.WriteLine("Thank you for using the program");
}