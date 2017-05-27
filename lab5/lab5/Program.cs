using System;
using System.Text;

namespace Lab5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            StringExample();//Задание 1
            foreach (string str in SumInWords(1908))//Задание 2
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();
            SplitJoin("Строка, предназначенная для рассоединения и обратного объединения");//Задание 4
            TestStringBuilder();//Задание 4-5
            CharArray();//Задание 6
            Console.ReadLine();
        }

        public static void StringExample()
        {
            string str1 = "Строка1";
            string str2 = new string('s', 5);
            char[] charray = { 't', 'e', 's', 't' };
            string str3 = new string(charray);
            string str4 = str1;
            Console.WriteLine(str1 == str4);
            Console.WriteLine(str1 != str4);
            str4 = str4 + " " + str2[3];
            Console.WriteLine(str4);
            str4 = "Строка с текстом в скобках (Текст в скобках)";
            string str5 = "";
            bool b = false;
            foreach (char c in str4)
            {
                if (b)
                {
                    if (c == ')') break;
                    str5 = str5 + c;
                }
                else
                {
                    if (c == '(')
                    {
                        b = true;
                    }
                }
            }
            str4 = antiStudent("строка содержащая подстроку student и еще какой-то текст");
            Console.WriteLine(str4);
        }

        public static string antiStudent(string str)
        {
            int first = str.IndexOf("student");
            if (first == -1) return str;
            string rezstr = str.Substring(0, first) + str.Substring(first + 7);
            rezstr = antiStudent(rezstr);
            return rezstr;
        }

        public static string[] SumInWords(int sum)
        {
            string[] ar1 = { "", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };
            string[] ar2 = { "", "десять", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят", "девяносто" };
            string[] ar3 = { "", "сто", "двести", "триста", "четыреста", "пятьсот", "шетьсот", "семьсот", "восемьсот", "девятьсот" };
            string[] ar4 = { "одна тысяча", "две тысячи", "тысячи" };
            string[] ar5 = { "рубль", "рубля", "рублей" };
            int count = 0;
            int local = sum;
            while (local > 0)
            {
                local = local / 10;
                count++;
            }
            string[] strarr = null;
            if (count == 4)
            {
                strarr = new string[5];
                local = sum / 1000;
                sum %= 1000;
                if (local > 2)
                {
                    strarr[4] = ar1[local - 1] + " " + ar4[2];
                }
                else
                {
                    strarr[4] = ar4[local - 1];
                }
            }
            if (count >= 3)
            {
                if (strarr == null) strarr = new string[4];
                local = sum / 100;
                sum %= 100;
                strarr[3] = ar3[local];
            }
            if (count >= 2)
            {
                if (strarr == null) strarr = new string[3];
                local = sum / 10;
                sum %= 10;
                strarr[2] = ar2[local];
            }
            if (count >= 1)
            {
                if (strarr == null) strarr = new string[2];
                local = sum % 10;
                strarr[1] = ar1[local];
                switch (local)
                {
                    case 1:
                        strarr[0] = ar5[0];
                        break;
                    case 2 - 4:
                        strarr[0] = ar5[1];
                        break;
                    default:
                        strarr[0] = ar5[2];
                        break;
                }
            }
            Array.Reverse(strarr);
            return strarr;
        }

        public static void SplitJoin(string str)
        {
            string[] SimpleSentences, Words;
            SimpleSentences = str.Split(',');
            Words = str.Split(' ');
            string str2 = string.Join(" ", Words);
            Console.WriteLine(str);
            Console.WriteLine(str2);
        }

        public static void TestStringBuilder()
        {
            StringBuilder str1 = new StringBuilder("String - example of StringBuilder");
            StringBuilder str2 = new StringBuilder("String number 2");
            str1.Append(str2);
            Console.WriteLine(str1);
            str1.Remove(9, 8);
            Console.WriteLine(str1);
            str1 = new StringBuilder("Строка, содержащая простые предложения, которые будут нумероваться");
            str1.Append(str2);
            str1.Insert(0, str2);
            str2.Remove(0, str2.Length);
            string str = str1.ToString();
            string[] strarr = str.Split(',');
            int num = 1;
            foreach (string strarg in strarr)
            {
                str2.AppendFormat(" {0} : {1}", num++, strarg);
            }
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            int vol = str2.Capacity;
            int maxVol = str2.MaxCapacity;
            Console.WriteLine("str2:\nvol = " + vol + "\tmaxVol = " + maxVol);
            vol = str1.Capacity;
            maxVol = str1.MaxCapacity;
            Console.WriteLine("str1:\nvol = " + vol + "\tmaxVol = " + maxVol);
            str1.EnsureCapacity(150);
            str2.EnsureCapacity(150);
            vol = str2.Capacity;
            maxVol = str2.MaxCapacity;
            Console.WriteLine("str2:\nvol = " + vol + "\tmaxVol = " + maxVol);
            vol = str1.Capacity;
            maxVol = str1.MaxCapacity;
            Console.WriteLine("str1:\nvol = " + vol + "\tmaxVol = " + maxVol);
        }

        public static void CharArray()
        {
            char[] str1 = "Hello, World!".ToCharArray();
            string str2 = "Здравствуй, Мир!";
            PrintCharAr(str1);
            string str3 = CharArrayToString(str1);
            Console.WriteLine(str3);
            Console.WriteLine(IndexOfStr(str1, "World".ToCharArray()));
        }

        public static void PrintCharAr(char[] arr)
        {
            foreach (char c in arr)
            {
                Console.Write(c);
            }
            Console.WriteLine();
        }

        public static string CharArrayToString(char[] ar)
        {
            StringBuilder str = new StringBuilder();
            foreach (char c in ar)
            {
                str.Append(c);
            }
            return str.ToString();
        }

        public static int IndexOfStr(char[] s1, char[] s2)
        {
            int size = s2.Length;
            bool sovp = false;
            int count = 0;
            int counts2 = 0;
            int tmp = 0;
            foreach (char c in s1)
            {
                if (sovp)
                {
                    if (counts2 == size) return tmp;
                    if (c != s2[counts2])
                    {
                        sovp = false;
                    }
                    ++counts2;
                }
                if (c == s2[0])
                {
                    tmp = count + 1;
                    sovp = true;
                    counts2 = 1;
                }
                ++count;
            }
            return -1;
        }
    }
}