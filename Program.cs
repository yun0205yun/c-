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

//decimal.TryParse()  將 string 變數 value 轉換為 decimal
//string[] values = { "12.3", "45", "AB", "11", "CDE" };
//decimal total = 0m;
//string message = "";
//foreach(var value in values)
//{
//    decimal number;
//    if(decimal.TryParse(value, out number))
//    {
//        total += number;
//    }
//    else
//    {
//        message += value;
//    }
//}
//Console.WriteLine(message);
//Console.WriteLine(total);



////Array.Sort()由小到大
////Array.Reverse()反轉矩陣
//string[] packs = { "B14", "A11", "B12", "A13" };
//Array.Sort(packs); 
//foreach (var pack in packs)
//{
//    Console.WriteLine(pack);
//}
//Console.WriteLine();
//Array.Reverse(packs);
//foreach (var pack in packs)
//{
//    Console.WriteLine(pack);
//}
//Console.WriteLine();
////由大到小Array.Clear(清除的陣列,清除之項目範圍的起始索引,要清除的項目數目);
//Array.Clear(packs,2,1);
//Console.WriteLine(packs.Length);
//foreach (var pack in packs)
//{
//    Console.WriteLine(pack);
//}

//Array.Resize(ref packs,6);
//packs[4] = "C01";
//packs[5] = "C02";
//foreach (var pack in packs)
//{
//    Console.WriteLine(pack);
//}



//string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
//string[]items=orderStream.Split(',');
//Array.Sort(items);
//foreach(string item in items)
//{
//    if (item.Length != 4)
//    {
//        Console.WriteLine(item+"\t -Error");
//    }
//    else
//    {
//        Console.WriteLine(item);
//    }
//}

////:C 貨幣格式規範是用來將 price 與 discount 變數呈現為貨幣
//decimal price = 123.45m;
//int discount = 50;
//Console.WriteLine($"Price: {price:C}(save {discount:C})");


////.PadRight()加右邊
//string paymentId = "769C";
//string payeeName = "Mr. Stephen Ortega";
//string paymentAmount = "$5,000.00";

//var formattedLine = paymentId.PadRight(6);
//formattedLine += payeeName.PadRight(24);
//formattedLine += paymentAmount.PadLeft(10);

//Console.WriteLine("1234567890123456789012345678901234567890");
//Console.WriteLine(formattedLine);
////輸出1234567890123456789012345678901234567890
////    769C  Mr. Stephen Ortega       $5,000.00



//const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

//string quantity = "";
//string output = "";

//int qstart = input.IndexOf("<span>");
//int qend = input.IndexOf("</span>");
//qstart += "<span>".Length;
//int qlength=qend - qstart;
//quantity=input.Substring(qstart, qlength);
//quantity = $"Quantity:{quantity}";


//output = input.Replace("&trade;", "&reg;");
//int divstart = input.IndexOf("<div>");
//int divlength = "<div>".Length;
//output=output.Remove(divstart, divlength); ;

//int divend = output.IndexOf("</div>");
//int divendlength = "</div>".Length;
//output=output.Remove(divend, divendlength); ;


//Console.WriteLine(quantity);
//Console.WriteLine(output);


//using System;

//int[] times = { 800, 1200, 1600, 2000 };
//int diff = 0;

//Console.WriteLine("Enter current GMT");
//int currentGMT = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Current Medicine Schedule:");
//DisplayTimes();
//Console.WriteLine("Enter new GMT");
//int newGMT = Convert.ToInt32(Console.ReadLine());
///* Format and display medicine times */
//if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
//{
//    Console.WriteLine("Invalid GMT");
//}
//else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
//{
//    diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
//    AdjustTimes();
//}
//else
//{
//    diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
//    AdjustTimes();
//}
//Console.WriteLine("New Medicine Schedule:");
//DisplayTimes();
//void DisplayTimes()
//{
//    foreach (int val in times)
//    {
//        string time = val.ToString();
//        int len = time.Length;

//        if (len >= 3)
//        {
//            time = time.Insert(len - 2, ":");
//        }
//        else if (len == 2)
//        {
//            time = time.Insert(0, "0:");
//        }
//        else
//        {
//            time = time.Insert(0, "0:0");
//        }

//        Console.Write($"{time} ");
//    }

//    Console.WriteLine();
//}



//void AdjustTimes()
//{
//    for (int i = 0; i < times.Length; i++)
//    {
//        times[i] = ((times[i] + diff)) % 2400;
//    }
//}


//Random random = new Random();
//int luck = random.Next(100);

//string[] text = { "You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to" };
//string[] good = { "look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!" };
//string[] bad = { "fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life." };
//string[] neutral = { "appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature." };
//Console.WriteLine("output:");
//Tellfortune();
//luck = random.Next(100);
//Console.WriteLine("");
//Console.WriteLine("output:");
//Tellfortune();
//void Tellfortune()
//{
//    Console.WriteLine("A fortune teller whispers the following words:");
//    string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
//    for (int i = 0; i < 4; i++)
//    {
//        Console.Write($"{text[i]} {fortune[i]} ");
//    }

//}


//countTo(5);
//void countTo(int max)
//{
//    for (int i = 0; i < max; i++)
//    {
//        Console.Write($"${i}, ");
//    }
//}//$0, $1, $2, $3, $4,


//string[] students = {"jenny","anny","victor","howard"};

//Displaystudent(students);
//Displaystudent(new string[] {"ribert" ,"birdy"});

//void Displaystudent(string[] students)
//{
//    foreach (var student in students)
//    {
//        Console.Write($"{student}, ");
//    }
//    Console.WriteLine();
//}

//printcirclearea(2);
//cirf(7); 
//void printcirclearea(int r)
//{
//    double pi = 3.14159;
//    double area = pi * (r * r);
//    double cirf = 2 * pi * r;
//    Console.WriteLine($"Area={area},ference={cirf}");
//}
//void cirf(int r)
//{
//    double cirf = 2 * 3.14159 * r;
//    Console.WriteLine($"ference={cirf}");

//}


//int a = 3, b = 4, c = 0;
//m(a,b,c);
//Console.WriteLine($"global:{a}x {b} = {c}");//3*4=0
//void m(int a, int b, int c)
//{
//    c = a * b;
//    Console.WriteLine($"inside :{a}x {b} = {c}");//3*4=12
//}


//int[] array = {1,2,3,4,5};

//printarray(array);// 1 2 3 4 5
//clear(array);
//printarray(array);//00000

//void printarray(int[] array)
//{
//    foreach (int i in array)
//    {
//        Console.Write($"{i}");
//    }
//    Console.WriteLine();
//}

//void clear(int[] array)
//{
//    for(int i = 0; i < array.Length; i++)
//    {
//        array[i] = 0;
//    }
//}


////使用字串測試
//string status = "healthy";
//Console.WriteLine($"start:{status}");
//sethealth(false);
//Console.WriteLine($"end:{status}");
//void sethealth(bool ishealth)
//{
//    status = (ishealth ? "Healthy" : "Unhealthy");
//    Console.WriteLine(status);
//}


//string[] list = { "Rebecca", "Nadia", "Noor", "Jonte" };
//string[] rsvps = new string[10];
//int count = 0;

//RSVP("Rebecca", 1, "none", true);
//RSVP("Nadia", 2, "Nuts", true);
//RSVP("Linh", 2, "none", false);
//RSVP("Tony", 1, "Jackfruit", true);
//RSVP("Noor", 4, "none", false);
//RSVP("Jonte", 2, "Stone fruit", false);
//showRSVPS();

//void RSVP(string name,int size,string allergies,bool inviteOnly)
//{
//    if(inviteOnly)
//    {
//        bool found=false; 
//        foreach(string s in list)
//        {
//            if (s.Equals(name))
//            {
//                found = true;
//                break;
//            }
//        }
//        if(!found)
//        {
//            Console.WriteLine($"sorry,{name} 沒有在名單裡");
//            return;
//        }
//    }
//    rsvps[count] = $"name:{name}, \t size:{size}, \t llergies: {allergies}";
//    count++;
//}
//void showRSVPS()
//{
//    Console.WriteLine("\ntotal RSVPs:");
//    for(int i = 0; i < count; i++)
//    {
//        Console.WriteLine(rsvps[i]);
//    }
//}



////顯示電子郵件地址
//string[,] corporate =
//{
//    {"Robert", "Bavin"}, {"Simon", "Bright"},
//    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
//    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
//};

//string[,] external =
//{
//    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
//    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
//};


//string externalDomain = "hayworth.com";

//for (int i = 0; i < corporate.GetLength(0); i++)
//{
//    displayemail(first: corporate[i,0],last: corporate[i,1],domain: externalDomain);
//}

//for (int i = 0; i < external.GetLength(0); i++)
//{
//    displayemail(first: external[i,0],last: external[i,1]);
//}

//void displayemail(string first,string last,string domain = "contoso.com")
//{
//    string email = first.Substring(0, 2) + last;
//    email = email.ToLower();
//    Console.WriteLine($"{email}@{domain}");
//}



//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        //計算購買總價
//        double total = 0;
//        double minimumSpend = 30.00;

//        double[] items = { 15.97, 3.50, 12.25, 22.99, 10.98 };
//        double[] discounts = { 0.30, 0.00, 0.10, 0.20, 0.50 };
//        for (int i = 0; i < items.Length; i++)

//        {
//            total += GetDiscountedPrice(i);
//        }
//        total -= TotalMeetsMinimum() ? 5.00 : 0.00;
//        Console.WriteLine($"Total: ${FormatDecimal(total)}");

//        double GetDiscountedPrice(int itemIndex)
//        {
//            return items[itemIndex] * (1 - discounts[itemIndex]);
//        }

//        bool TotalMeetsMinimum()
//        {
//            return total >= minimumSpend;
//        }

//        string FormatDecimal(double input)
//        {
//            return input.ToString().Substring(0, 5);
//        }
//    }
//}


////建立傳回整數的方法
//double usd = 23.73;
//int vnd = UsdToVnd(usd);

//Console.WriteLine($"${usd} USD=$ {vnd} VND");
//Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");
//int UsdToVnd(double usd)
//{
//    int result = (int)(usd * 23500);
//    return result;
//}

//double VndToUsd(int vnd)
//{
//    double rate=23500;
//    return vnd/rate;
//}



////從方法傳回字串
//string input = "snake";
//string input1 = "I want to sleep";
//Console.WriteLine(input);
//Console.WriteLine(input1);
//Console.WriteLine(ReverseWord(input));
//Console.WriteLine(reverseSentense(input1));
//string ReverseWord(string word)
//{
//    string result = "";
//    for(int i = word.Length - 1; i >= 0; i--)
//    {
//        result += word[i];
//    }
//    return result;
//}
//string reverseSentense(string input)
//{
//    string result = "";
//    string[] words=input.Split(" ");
//    foreach(string word in words)
//    {
//        result += ReverseWord(word)+" ";
//    }
//    return result.Trim();
//}



////從方法傳回布林值
//string[] words = { "racecar", "talented", "deified", "tent", "tenet" };

//Console.WriteLine("Is it a 回文?");
//foreach (string word in words)
//{
//    Console.WriteLine($"{word}: {IsPalindrome(word)}");
//}
//bool IsPalindrome(string word)
//{
//    int start = 0;
//    int end = word.Length-1;
//    while(start < end)
//    {
//        if (word[start] != word[end])
//        {
//            return false;
//        }
//        start++;
//        end--;
//    }
//    return true;
//}


////從方法傳回陣列 尋找硬幣以換零錢
//int target = 60;
//int[] coins = new int[] {5,5,50,25,25,10,5 };
//int[,]result=twocoins(coins, target);

//if (result.Length == 0)
//{
//    Console.WriteLine("沒硬幣可換");
//}
//else
//{
//    Console.WriteLine("change found at positions:");
//    for(int i=0; i<result.GetLength(0); i++)
//    {
//        if (result[i, 0] == -1)
//        {
//            break;
//        }
//        Console.WriteLine($"{result[i, 0]},{result[i,1]}");
//    }
//}

//int[,] twocoins(int[]coins,int target)
//{
//    int[,] result = { { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 } };
//    int count = 0;
//    for (int cur = 0; cur < coins.Length; cur++)
//    {
//        for (int next = cur + 1; next < coins.Length; next++)
//        {
//            if (coins[cur] + coins[next] == target)
//            {
//                result[count, 0] = cur;
//                result[count, 1] = next;
//                count++;
//            }
//            if (count == result.GetLength(0))
//            {
//                return result;
//            }
//        }
//    }

//    return (count == 0) ? new int[0, 0] : result;
//}







//骰子迷你遊戲
//Random random = new Random();

//Console.WriteLine("Would you like to play? (Y/N)");
//if (ShouldPlay())
//{
//    PlayGame();
//}
//bool ShouldPlay()
//{
//    string response=Console.ReadLine();
//    return response.ToLower().Equals("y");
//}
//void PlayGame()
//{
//    var play = true;

//    while (play)
//    {
//        var target=GetTarget();
//        var roll=RollDice();

//        Console.WriteLine($"Roll a number greater than {target} to win!");
//        Console.WriteLine($"You rolled a {roll}");
//        Console.WriteLine(WinOrLose(roll,target));
//        Console.WriteLine("\nPlay again? (Y/N)");

//        play = ShouldPlay();
//    }
//}

//int GetTarget()
//{
//    return random.Next(1,6);
//}
//int RollDice()
//{
//    return random.Next(1, 7);
//}

//string WinOrLose(int roll,int target)
//{
//    if (roll > target)
//    {
//        return "你贏";
//    }
//    return "你輸";
//}



using System;

string[] pettingZoo =
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

PlanSchoolVisit("School A");
PlanSchoolVisit("School B", 3);
PlanSchoolVisit("School C", 2);

void PlanSchoolVisit(string schoolName, int group= 6)
{
    RandomizeAnimals();
    string[,] group1 = AssignGroup(group);
    Console.WriteLine(schoolName);
    PrintGroup(group1);
}

void RandomizeAnimals()
{
    Random random = new Random();

    for (int i = 0; i < pettingZoo.Length; i++)
    {
        int r = random.Next(i, pettingZoo.Length);

        string temp = pettingZoo[r];
        pettingZoo[r] = pettingZoo[i];
        pettingZoo[i] = temp;
    }
}

string[,] AssignGroup(int group = 6)
{
    string[,] result = new string[group, pettingZoo.Length / group];
    int start = 0;

    for (int i = 0; i < group; i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = pettingZoo[start++];
        }
    }

    return result;
}

void PrintGroup(string[,] group)
{
    for (int i = 0; i < group.GetLength(0); i++)
    {
        Console.Write($"Group {i + 1}: ");
        for (int j = 0; j < group.GetLength(1); j++)
        {
            Console.Write($"{group[i, j]}  ");
        }
        Console.WriteLine();
    }
}