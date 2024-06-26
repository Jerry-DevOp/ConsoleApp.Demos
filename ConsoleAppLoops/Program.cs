//Print a program that prints
//Hello world ten times

Console.WriteLine("How many time should we print 'Helllo ,World'");
int counter = Convert.ToInt32(Console.ReadLine());  
for(int i = 0; i < counter; i++)
{
    Console.WriteLine($"Hello world ?");
}