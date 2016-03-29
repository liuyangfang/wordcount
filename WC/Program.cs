using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
namespace ProjectWC
    {
        public static class WC
        {
            public static int count1(string n)//文本汉字数目
             {
                MatchCollection c = Regex.Matches(n, "[\u4e00-\u9fa5]");//正则表达
                    return c.Count;
             }
             public static int count2(string n)//文本注释数目
             {
                MatchCollection c = Regex.Matches(n, "//");//正则表达
            return c.Count;
            }
            public static int count3(string n)//文本标点数目
            {
                MatchCollection c = Regex.Matches(n, @"\p{P}");//正则表达
            return c.Count;
            }       
            public static int count4(string n)//文本空行数目
            {
                MatchCollection c = Regex.Matches(n, @"\n\r");//正则表达
            return c.Count;
            }
             public static int count5(string n)//文本非空字符数目
            {    
                MatchCollection c = Regex.Matches(n, "[^\\s]");//正则表达
            return c.Count;
             }
       
    }
        class Program
        {
            static void Main(string[] args)
            {
            string s = "E:\\file.txt";
            StreamReader n = new StreamReader(s, Encoding.Default);
            string L;
            L = n.ReadToEnd();
            Console.WriteLine(L);
            Console.WriteLine("txt中汉字数:" + WC.count1(L));//输出文本汉字数
            Console.WriteLine("txt中注释行数:" + WC.count2(L));//输出文本注释行数
            Console.WriteLine("txt中标点符号数:" + WC.count3(L));//输出文本标点符号
            Console.WriteLine("txt中空行数:" + WC.count4(L));//输出文本空行数
            Console.WriteLine("txt中非空字符数:" + WC.count5(L));//输出文本中非空字符数
        }
    }
    }


