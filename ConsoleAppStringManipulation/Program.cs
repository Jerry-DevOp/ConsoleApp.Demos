//literal string, initialized
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

string s1 = "This is a literal string";

//Declare without initialization
// cahnces of a null exception
 string s3;

//initialize to null
string? s4;//s4 = null;

// initialized with empty

string s5 = string.Empty;

//escape sequence of characters
// the \ helps to show the qoutation mark
// \r\n for next next line
string sentence = "She said \"I have your phone\"\r\n you should go check it";

// Verbating string
// takes every text as it is
string oldPath = "C\\program files\\program folder\\";//using escape sequence
string newPath = @"C\program files\program folder\";// using verbal literals

//Contant viariable can modify it
const string path = "C\\program files\\program folder\\";
//Illegal operation trying to change thee value of path

//raw strinng literals(Triple qoutations)
//this will show on a single line
string sentenceRaw = """She said "I have your phone",you should go check it""";

// for multiple lines

string sentenceRaw2 = """
She said "I have your phone"
,you should go check it
""";

Console.WriteLine(sentenceRaw);
Console.WriteLine(sentenceRaw2);
Console.WriteLine();

// string interpolation
string newString = $"{s1} {sentenceRaw2}";
string newString2 = String.Format("literal strings {0}  {1}",s1,sentence);

// the name of function prints thr name of the variable
Console.WriteLine($"{nameof(newString)} : {newString}");   
Console.WriteLine();

// String manipulation and properties

//Check if a string is null
// use ISNULL

string st2 = null ;
string st3 = " " ;
Console.WriteLine(string.IsNullOrEmpty(sentenceRaw2));
Console.WriteLine($"is st2 empyt?: {string.IsNullOrEmpty(st2)} ");
Console.WriteLine($"{string.IsNullOrEmpty(st3)} what is the length {st3.Length}");

//check the length of the string

Console.WriteLine($"Length of newstring :{newString.Length}");//propertie

//Substrings

string substring = newString.Substring(0,10);
Console.WriteLine($"substring :{substring}");

//split strings
//split by a space
var splitStrings = newString.Split(' ');

for (int i = 0; i < splitStrings.Length; i++)
{
    Console.WriteLine(splitStrings[i]);
}

// replace method

Console.WriteLine($"rplace every sapce in a sentence  *{newString.Replace(' ','*')}");

//convert to string
bool tip = true;

string tipOutcome = tip.ToString();

//changing the formating

int money = 20000000;
string cash = money.ToString("C");
Console.WriteLine(cash);