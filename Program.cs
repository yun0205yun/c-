namespace c_
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Console.WriteLine("Test1");
            Test test1 = new Test(4, 5);
            Console.WriteLine("\n 1.乘法");
            test1.Mix();
            //用int 回傳值
            Console.WriteLine($"用int 回傳:");
            test1.mix(9, 9);
            // 農場拜訪 隨機
            Console.WriteLine("\n 2.農場拜訪 隨機");
            test1.PlanSchoolVisit("School A");
            test1.PlanSchoolVisit("School B", 3);
            //找數字加總 foreach
            Console.WriteLine("\n 3.找數字加總 foreach");
            test1.Number();
            //翻轉 找出o用了幾次 Array.Reverse
            Console.WriteLine("\n 4.句子翻轉 找出o用了幾次 Array.Reverse");
            test1.ReverseO();
            //switch case 名字等級
            Console.WriteLine("\n 5.switch case 名字等級");
            test1.switchLevel("波波",200);
            //int.TryParse()  將 string 變數 value 轉換為 int
            Console.WriteLine("\n 6.將 string 變數 value 轉換為 int");
            test1.intTryParse("256");//這裡字串如果是數字112 他會轉成int 但如果是英文中文就不行
            //decimal.TryParse()  將 string 變數 value 轉換為 decimal
            Console.WriteLine("\n 7.將 string 變數 value 轉換為 decimal");
            test1.decimalTryParse();
            //Array.Sort()由小到大Array.Reverse()反轉矩陣
            Console.WriteLine("\n 8.Array.Sort()Array.Reverse()Array.Clear()Array.Resize()");
            test1.ASARC();
            //.split()
            Console.WriteLine("\n 9..split()去逗點 找出字串的錯誤");
            test1.SPLIT();
            Console.WriteLine("\n 用string 去回傳");
            string split=test1.Split();
            Console.WriteLine(split);
            //:C 貨幣格式規範是用來將 price 與 discount 變數呈現為貨幣
            Console.WriteLine("\n 10.:C 貨幣格式規範");
            test1.MONEY(123.45m, 50);
            //.PadRight()加右邊
            Console.WriteLine("\n 11.對齊字");
            test1.PadRight("769C", "Mr. Stephen Ortega", "$5,000.00");
            //去除句子裡的內容.IndexOf .Substring .Replace .Remove
            Console.WriteLine("\n 12.擷取一段內容");
            test1.IOSSRR("<div><h2>Widgets &trade;</h2><span>5000</span></div>");
            //顯示電子郵件地址
            Console.WriteLine("\n 13.顯示電子郵件地址");
            test1.email();
            //從方法傳回布林值 回文
            Console.WriteLine("\n 14.從方法傳回布林值(迴文)");
            test1.Pal();
            //




        }
    }
}