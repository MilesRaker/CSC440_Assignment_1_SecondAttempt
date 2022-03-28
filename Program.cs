Console.WriteLine("Welcome to CSC440 Assignment about Git!");
Console.WriteLine("This is my second attempt at the Git homework, as I learned a valuable lesson with my first attempt...");
Console.WriteLine("(press any key to move past the elipses...)");
Console.ReadKey();
Console.WriteLine("Remember to commit your changes!");
Console.WriteLine("So, here we are again. Cheers!\n\n\n");

Console.WriteLine("What is your birthday?\n(enter using MM/DD/YYYY format)");
string birthdateInput = Console.ReadLine();
DateTime birthdate = DateTime.Parse(birthdateInput);
DateTime today = DateTime.Now;
int age = today.Subtract(birthdate).Days/365;

if(age < 0 || age > 135)
{
    Console.WriteLine($"Looks like your age is {age}... really? I don't think so.");
}
Console.WriteLine($"You are {age} years old. Good for you!");
if(birthdate.Month - DateTime.Now.Month == 0 && birthdate.Day - DateTime.Now.Day == 0)
{
    Console.WriteLine("Happy birthday, ya lucky bastard!");
}

Console.WriteLine("Now, to compute your all important, God divined signs. Turns out, I am a scorpion riding a Tiger! Take that Tiger King!");

string[] ZodiacSigns = { "Capricorn", "Aquarius", "Pisces", "Aries", "Taurus", "Gemini", "Cancer", "Leo", "Virgo", "Libra", "Scorpio", "Sagittarius" };
bool firstHalfOfMonth = false; //true means birthdate.Day < 20
if (birthdate.Day < 20) firstHalfOfMonth = true;
string zodiacSign = "";

if (firstHalfOfMonth)
{
    zodiacSign = ZodiacSigns[birthdate.Month - 1];
}
else
{
    zodiacSign = ZodiacSigns[birthdate.Month];
}

Console.WriteLine($"Your Zodiac sign is: {zodiacSign}");
// creating mathmatical formula to calculate sign...
// (birthyear - 1900)%12 == 0 => Rat
// now implementing in brute force way... wish I had functions in this program...

string animalSign = "";

if((birthdate.Year-1900)%12 == 0)
{
    animalSign = "rat";
}
if ((birthdate.Year - 1900) % 13 == 0)
{
    animalSign = "ox";
}
if ((birthdate.Year - 1900) % 14 == 0)
{
    animalSign = "tiger";
}
if ((birthdate.Year - 1900) % 15 == 0)
{
    animalSign = "rabbit";
}
if ((birthdate.Year - 1900) % 16 == 0)
{
    animalSign = "dragon";
}
if ((birthdate.Year - 1900) % 17 == 0)
{
    animalSign = "snake";
}
if ((birthdate.Year - 1900) % 18 == 0)
{
    animalSign = "horse";
}
if ((birthdate.Year - 1900) % 19 == 0)
{
    animalSign = "sheep";
}
if ((birthdate.Year - 1900) % 20 == 0)
{
    animalSign = "monkey";
}
if ((birthdate.Year - 1900) % 21 == 0)
{
    animalSign = "rooster";
}
if ((birthdate.Year - 1900) % 22 == 0)
{
    animalSign = "dog";
}
if ((birthdate.Year - 1900) % 23 == 0)
{
    animalSign = "pig";
}

Console.WriteLine($"Your animal sign is: {animalSign}");

