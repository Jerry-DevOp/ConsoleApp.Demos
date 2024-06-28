//Empty DateTime

// Date time is a struct

DateTime dateTime = new DateTime();

//create a dateTime from data 
// and time
var dateOfBirth = new DateTime(1993,05,24);
Console.WriteLine($"{dateOfBirth}");

var exactDateAndTimeOfBirth = new DateTime(1997, 08, 29,13,34,23);
Console.WriteLine($"Day of the week {exactDateAndTimeOfBirth.DayOfWeek}");
Console.WriteLine($"Day of the year {exactDateAndTimeOfBirth.DayOfYear}");
Console.WriteLine($"Time of the Day {exactDateAndTimeOfBirth.TimeOfDay}");
Console.WriteLine($"Tick {exactDateAndTimeOfBirth.Ticks}");
Console.WriteLine($"Kind {exactDateAndTimeOfBirth.Kind}");

// Get a currest timesatamp
DateTime now = DateTime.Now;
Console.WriteLine("The Time Is :"+ now);

//Create a DateTime from a String
Console.WriteLine("What is ayour BOD (dd/MM/yyyy) ");
string dob = Console.ReadLine();
var userDob = DateTime.Parse(dob);
Console.WriteLine($"Day of the week {userDob.DayOfWeek}");
Console.WriteLine($"Day of the year {userDob.DayOfYear}");
Console.WriteLine($"Time of the Day {userDob.TimeOfDay}");
Console.WriteLine($"Tick {userDob.Ticks}");
Console.WriteLine($"Kind {userDob.Kind}");

//Change date format

Console.WriteLine($" Formatted date: {userDob.ToString("dd/MM/yyyy")} ");
Console.WriteLine($" Formatted date: {userDob.ToString("MMM, dd-yyyy")} ");
Console.WriteLine($" Formatted date: {userDob.ToString("dd-MMM-yyyy")} ");
Console.WriteLine($" Formatted date: {userDob:dddd, MMMM, yyyy}");


//Add Additional Time

Console.WriteLine("One hour from now is: "+now.AddHours(1));
Console.WriteLine("One day from now is: " + now.AddDays(1));
Console.WriteLine("One day ago from now is: " + now.AddDays(-1));

Console.WriteLine("**************** - DateTime Offset manipulation - ****************");

//UTC
// cordinated universal time.
var utcNow = DateTime.UtcNow;

Console.WriteLine($"The Date and time right now {now}");
Console.WriteLine($"UTC format {utcNow}");


//DateTimeOffSet and TimeZone info

var timeZone = TimeZoneInfo.Local.GetUtcOffset(utcNow);
Console.WriteLine($"User Time Zone: {timeZone}");

var dto = new DateTimeOffset(now, timeZone);
Console.WriteLine($"User's TimeZone with UTC offset: {dto}");
Console.WriteLine($"UTC Time of action: {dto.UtcDateTime}");

var indiaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");

var indiaDateTime = TimeZoneInfo.ConvertTimeFromUtc(dto.UtcDateTime, indiaTimeZone);
Console.WriteLine($"Sction was completed in india at : {indiaDateTime}");

Console.WriteLine("**************** - DateTime only and Time only manipulation - ****************");