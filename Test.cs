using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace c_
{
    class Test
    {
        AllModel allmodel = new AllModel();
        public Test(int a,int b) //建構值
        {
            allmodel = new AllModel {a=a,b=b };
        }
        public void Mix()//void不會輸出任何型別
        {
            allmodel.c=allmodel.a*allmodel.b;
            Console.WriteLine($"乘法 :{allmodel.a}x {allmodel.b} = {allmodel.c}");

        }
        //農場拜訪 隨機
        public void PlanSchoolVisit(string schoolName, int group = 6)
        {
            RandomizeAnimals();
            string[,] group1 = AssignGroup(group);
            Console.WriteLine(schoolName);
            PrintGroup(group1);
        }

        void RandomizeAnimals()
        { 
            Random random = new Random();

            for (int i = 0; i < allmodel.pettingZoo.Length; i++)
            {
                int r = random.Next(i, allmodel.pettingZoo.Length);

                string temp = allmodel.pettingZoo[r];
                allmodel.pettingZoo[r] = allmodel.pettingZoo[i];
                allmodel.pettingZoo[i] = temp;
            }
        }

        string[,] AssignGroup(int group = 6)
        {
            string[,] result = new string[group, allmodel.pettingZoo.Length / group];
            int start = 0;

            for (int i = 0; i < group; i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] = allmodel.pettingZoo[start++];
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
        //找數字加總 foreach
        public void Number()
        {
            int total = 0;
            bool found = false;
            foreach(int number in allmodel.numbers)
            {
                total += number;
                if(number==23)
                    found = true;
            }
            if (found)
                Console.WriteLine("有找到23");
            Console.WriteLine($"加總:{total}");
        }
        //翻轉 找出o用了幾次 Array.Reverse
        public void ReverseO()
        {
            char[] message = allmodel.ReverseO.ToCharArray();
            Array.Reverse(message);
            int count = 0;
            foreach(char c in message)
            {
                if(c == 'o')
                {
                    count++;
                }
            }
            string newmessage=new string(message);
            Console.WriteLine(newmessage);
            Console.WriteLine($"'o'出現{count}次");
        }
        //switch case 名字等級
        public void switchLevel(string name,int level)
        {
            string title = "";
            switch (level)
            {
                case 100:
                    title = "還行";
                    break;
                case 200:
                    title = "中等";
                    break;
                case 300:
                    title = "高等";
                    break;
                default:
                    title = "完了";
                    break;
            }
            Console.WriteLine($"{name}\t { title}");
        }
        //int.TryParse()  將 string 變數 value 轉換為 int
        public void intTryParse(string str)
        {
            int result = 0;
            if(int.TryParse(str, out result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("無法報告測量結果。");
            }
            if (result > 0)
                Console.WriteLine($"{50+result}");
        }
        //decimal.TryParse()  將 string 變數 value 轉換為 decimal精準
        public void decimalTryParse()
        {
            decimal total = 0;
            string message = "";
            foreach(var c in allmodel.DTP) 
            {
                decimal number;
                if(decimal.TryParse(c, out number))
                {
                    total += number;//68.3
                }
                else
                {
                    message += c;//ABCDE
                }
            }
            Console.WriteLine(message);
            Console.WriteLine(total);
        }
        //Array.Sort()由小到大Array.Reverse()反轉矩陣
        //由大到小Array.Clear(清除的陣列,清除之項目範圍的起始索引,要清除的項目數目);
        //
        public void ASARC()
        {
            Array.Sort(allmodel.ASARC);
            Console.WriteLine("Array.sort()");
            foreach (var a in allmodel.ASARC)
            {
                
                Console.WriteLine(a);
            }
            Array.Reverse(allmodel.ASARC);
            Console.WriteLine("Array.Reverse()");
            foreach (var b in allmodel.ASARC)
            {
                 
                Console.WriteLine(b);
            }
            Array.Clear(allmodel.ASARC,2,1);
            Console.WriteLine("Array.Clear()");
            foreach (var c in allmodel.ASARC) 
            {
                 
                Console.WriteLine(c); 
            }
            Array.Resize(ref allmodel.ASARC,6);
            allmodel.ASARC[4] = "C01";
            allmodel.ASARC[5] = "C02";
            Console.WriteLine("Array.Resize()");
            foreach (var d in allmodel.ASARC)
            {
                 
                Console.WriteLine($"{d}");
            }
        }
        //.split()
        public void SPLIT()
        {
            string[] items=allmodel.split.Split(",");
            Array.Sort(items);
            foreach (var item in items)
            {
                if (item.Length != 4)
                {
                    Console.WriteLine(item + "\t -Error");
                }
                else
                {
                    Console.WriteLine(item);
                }
            }
        }
        //:C 貨幣格式規範是用來將 price 與 discount 變數呈現為貨幣
        public void MONEY(decimal price,int discount)
        {
            Console.WriteLine($"價格:{price:C}(save{discount:C})");
        }
        //.PadRight()加右邊
        public void PadRight(string ID,string name,string price)
        {
            var line = ID.PadRight(6);
            line += name.PadRight(24);
            line += price.PadLeft(10);
            Console.WriteLine("1234567890123456789012345678901234567890");
            Console.WriteLine(line);
        }
        //去除句子裡的內容.IndexOf .Substring .Replace .Remove
        public void IOSSRR(string input) 
        {
            string quantity = "";
            string output = "";

            int qstart = input.IndexOf("<span>");//回報這個執行個體中指定之字串第一次出現時的所在索引 (以零為起始)。
            int qend = input.IndexOf("</span>");
            qstart += "<span>".Length;
            int qlength = qend - qstart;
            quantity = input.Substring(qstart, qlength);
            


            output = input.Replace("&trade;", "&reg;");
            int divstart = input.IndexOf("<div>");
            int divlength = "<div>".Length;
            output = output.Remove(divstart, divlength); ;

            int divend = output.IndexOf("</div>");
            int divendlength = "</div>".Length;
            output = output.Remove(divend, divendlength); ;

            Console.WriteLine("原本字串:<div><h2>Widgets &trade;</h2><span>5000</span></div>");
            Console.WriteLine($"拿到<span></span>裡的字:\t{ quantity}");
            Console.WriteLine($"用&reg取代&trade ,去掉<div></div>: \t{output}");
        }
        //顯示電子郵件地址
        public  void email()
        {
            string outdomain = "out.com";
            for(int i= 0; i < allmodel.Inemail.GetLength(0); i++)
            {
                displayemail(first: allmodel.Inemail[i, 0], last: allmodel.Inemail[i,0],domain:outdomain);
            }
            for (int i = 0; i < allmodel.Outemail.GetLength(0); i++)
            {
                displayemail(first: allmodel.Outemail[i, 0], last: allmodel.Outemail[i, 0]);
            }
            void displayemail(string first,string last,string domain="in.com")
            {
                string email = first.Substring(0, 2) + last;
                email=email.ToLower();
                Console.WriteLine($"{email}@{domain}");
            }
        }
        //




    }
}
