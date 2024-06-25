Console.WriteLine("Lets play a game");
Console.WriteLine("Enter the first number");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number");
int num2 = Convert.ToInt32(Console.ReadLine());

// Math operators

// add number
// exclusive cast
//int sum = (int)(num1 + num2);

int sum = num1 + num2;

//multiply
int product = num1 * num2;

//Division
int qoutient = num1 / num2;

//Subtraction
int difference = num1 - num2;

// Modulus
int mod = num1 % num2;
Console.WriteLine("*******************************************Math results*************************************");
Console.WriteLine($"Sum :{sum}");
Console.WriteLine($"Difference :{difference}");
Console.WriteLine($"Product :{product}");
Console.WriteLine($"Modulus :{mod}");
Console.WriteLine("********************************************End maths results******************************");

// Logic operators

bool isGreaterThan = num1 > num2;
bool isLessThan = num1 < num2;
bool isEqual = num1 > num2;
bool isGreaterThanOrEqualTo = num1 >= num2;
bool isLessThanOrEqualTo = num1 <= num2;
bool isNotEqualTO = num1 != num2;
Console.WriteLine("********************************************Start Logic Operators**************************");

Console.WriteLine($"Is {num1} Greater than {num2} {isGreaterThan}");
Console.WriteLine($"Is {num1} Less than {num2} {isLessThan}");
Console.WriteLine($"Is {num1} Equal to {num2} {isEqual}");
Console.WriteLine($"Is {num1} Greater than or Equal {num2} {isGreaterThanOrEqualTo}");
Console.WriteLine($"Is {num1} Less than or Equal {num2} {isLessThanOrEqualTo}");

Console.WriteLine("********************************************End Logic operators****************************");
Console.WriteLine("********************************************Start Compound operators****************************");

//assignment operators
int num3 = num1;
num3 += num2;
Console.WriteLine($"Increasing num3 by num2: {num2} is equal to: {num3}");
//multiply
num3 *= num2;
Console.WriteLine($"Multiplying num3 by num2: {num2} is equal to: {num3}");

//Division
num3 /= num2;
Console.WriteLine($"Dividing num3 by num2: {num2} is equal to: {num3}");

//Subtraction
num3 -= num2;
Console.WriteLine($"Reducing num3 by num2: {num2} is equal to: {num3}");


