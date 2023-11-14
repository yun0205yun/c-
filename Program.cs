//string originalMessage = "The quick brown fox jumps over the lazy dog.";

//char[]  message = originalMessage.ToCharArray();

//Array.Reverse( message);
//int letterCount = 0;

//foreach (char letter in message)
//{
//    if (letter == 'o')
//    {
//        letterCount++;
//    }
//}

//string newMessage = new String(message);

//Console.WriteLine(newMessage);
//Console.WriteLine($"'o' appears {letterCount} times.");


//int [] numbers  = { 4, 8, 9, 15, 16, 23, 42 };
//int total = 0;
//bool found = false;
//foreach(int number in numbers )
//{
//    total += number;
//    if(number==23) found = true;
//}
//if (found)
//    Console.WriteLine("set contains 23");
//Console.WriteLine($"Total: {total}");

//int emLevel = 250;
//string emName = "pony";
//string title = "";
//switch(emLevel)
//{
//    case 100:
//        title = "junier";
//        break;
//    case 200:
//        title = "high";
//        break;
//    default:
//        title = "senior";
//        break;
//}
//Console.WriteLine($"{emName}\t{title}");

//for (int i = 1; i < 101; i++)
//{
//    if ((i % 3 == 0) && (i % 5 == 0))
//        Console.WriteLine($"{i} - FizzBuzz");
//    else if (i % 3 == 0)
//        Console.WriteLine($"{i} - Fizz");
//    else if (i % 5 == 0)
//        Console.WriteLine($"{i} - Buzz");
//    else
//        Console.WriteLine($"{i}");
//}

//int hero = 10;
//int monster = 10;

//Random dice = new Random();

//do
//{
//    int roll = dice.Next(1, 11);
//    monster -= roll;
//    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

//    if (monster <= 0) continue;

//    roll = dice.Next(1, 11);
//    hero -= roll;
//    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

//} while (hero > 0 && monster > 0);

//Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");

//Console.WriteLine($"sbyte :{byte.MinValue} to {byte.MaxValue}");
//Console.WriteLine($"ushort :{ushort.MinValue} to {ushort.MaxValue}");
//Console.WriteLine($"uint   :{uint.MinValue} to {uint.MaxValue}");
//Console.WriteLine($"ulong  :{ulong.MinValue} to {ulong.MaxValue}");

//int.TryParse()  將 string 變數 value 轉換為 int
//string value = "bad";
//int result = 0;
//if (int.TryParse(value, out result))
//{
//    Console.WriteLine($"Measurement: {result}");
//}
//else
//{
//    Console.WriteLine("Unable to report the measurement.");
//}
//if(result>0)
//Console.WriteLine($"{50+result}");


string[] values = { "12.3", "45", "AB", "11", "CDE" };
decimal total = 0m;
string message = "";
foreach(var value in values)
{
    decimal number;
    if(decimal.TryParse(value, out number))
    {
        total += number;
    }
    else
    {
        message += value;
    }
}
Console.WriteLine(message);
Console.WriteLine(total);