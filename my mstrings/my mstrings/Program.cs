using System;

namespace assci
{

    internal class Program
    {
        class MyString
        {
            string sent;

            public MyString() { }
            public MyString(string sent) { this.sent = sent; }
            public static MyString operator -(MyString s, int n)
            {
                MyString t = new MyString();
                if (s.sent.Length <= n) { return t; }
                for (int i = 0; i < s.sent.Length - n; i++)
                {
                    t.sent += s.sent[i];
                }
                return t;
            }// remove last n letter:
            public static MyString operator -(MyString s, char a)
            {
                MyString t = new MyString();
                for (int i = 0; i < s.sent.Length; i++)
                {
                    if (s.sent[i] != a)
                    {
                        t.sent += s.sent[i];
                    }

                }
                return t;
            }//remove letter that u select:
            public static MyString operator +(MyString s, char a)
            {
                MyString t = new MyString(s.sent);

                if (s.sent.Length <= 0) { return s; }

                t.sent += a;


                return t;
            }// add letter that u selcet:

            public static MyString operator ++(MyString s)
            {
                if (s.sent.Length <= 0) { return s; }
                MyString t = new MyString(s.sent);
                // (add a letter from s to t then give me t) (-1: last char of sentence)
                t.sent += s.sent[s.sent.Length - 1];
                return t;
            }// add last letter
            public static MyString operator --(MyString s)
            {
                if (s.sent.Length <= 0) { return s; }
                MyString t = new MyString();//s.sent=====>هي الكلمة الرئيسية
                for (int i = 0; i < s.sent.Length - 1; i++) { t.sent += s.sent[i]; }//i: index of letters// s.sent: main word// t.sent: temprary word// 

                return t;
            }// remove last letter

            public override string ToString()
            {
                return sent;
            }//print
        }
        class Mystring
        {
            char[] text;
            public Mystring() { }
            public Mystring(string temp)
            {
                text = new char[temp.Length];
                for (int i = 0; i < temp.Length; i++) { text[i] = temp[i]; }
            }
            public static Mystring operator --(Mystring s)
            {
                Mystring t = new Mystring();
                t.text = new char[s.text.Length - 1];
                for (int i = 0; i < t.text.Length; i++)
                {
                    t.text[i] = s.text[i];
                }
                return t;
            }
            public void print() { Console.WriteLine(text); }

        }



        static void Main(string[] args)
        {
            MyString s = new MyString("saad");
            s = s + 'a';

            Console.WriteLine(s);
            Mystring s2 = new Mystring("saad");
            s2--;
            s2.print();
        }
    }
}
