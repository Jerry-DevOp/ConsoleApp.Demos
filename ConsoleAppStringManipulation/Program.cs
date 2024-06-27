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

// string interpolation
string newString = $"{s1} {sentenceRaw2}";
string newString2 = String.Format("literal strings {0}  {1}",s1,sentence);
