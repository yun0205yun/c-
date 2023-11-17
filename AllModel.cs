using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_
{
    internal class AllModel
    {
        //Mix
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }
        //PlanSchoolVisit
        public string[] pettingZoo =
        {
            "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
            "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
            "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
        };
        //找數字加總 foreach
        public int[] numbers = { 4, 8, 9, 15, 16, 23, 42 };
        //翻轉 找出o用了幾次 Array.Reverse
        public string ReverseO = "The quick brown fox jumps over the lazy dog.";
        //decimal.TryParse()  將 string 變數 value 轉換為 decimal
        public string[] DTP = { "12.3", "45", "AB", "11", "CDE" };
        //Array.Sort()由小到大Array.Reverse()反轉矩陣
        public string[] ASARC = { "B14", "A11", "B12", "A13" };
        //.split()
        public string split= "B123,C234,A345,C15,B177,G3003,C235,B179";
        //顯示電子郵件地址
        public string[,] Inemail =
        {
            {"Robert", "Bavin"}, {"Simon", "Bright"},
            {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
            {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
        };

        public string[,] Outemail =
        {
            {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
            {"Shay", "Lawrence"}, {"Daren", "Valdes"}
        };
        //從方法傳回布林值 迴文
        public string[] Pal = { "racecar", "talented", "deified", "tent", "tenet" };
        //

    }
}
