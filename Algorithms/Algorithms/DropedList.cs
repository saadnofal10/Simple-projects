using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class DropedList
    {
        class NodeLetter {
           public NodeLetter? Next { set; get; }
           public NodeWord? Drop { set; get; }
           public char Letter { set; get; }
            public NodeLetter()
            {
            }
            public NodeLetter(char data)
            {
                Letter = data;
                Drop = null;
                Next = null;
            }
        }
        class NodeWord
        {
            public NodeWord? Next { set; get; }
            public string Word { get; set; }
            public NodeWord() { }
            public NodeWord(string data) 
            {
                Word = data;
                Next = null;
            }
        }
        NodeLetter FirstLetter;
        NodeWord LastWord;
        int LLength = 0;
        int WLength = 0;
       
        public void AddLetterFirst(char Letter)
        {
            NodeLetter newLetter = new(Letter);
            if (LLength == 0)
            {
                FirstLetter = newLetter;
            }
            else
            {
                newLetter.Next = FirstLetter;
                FirstLetter = newLetter;
            }
            LLength++;
        }
        public void AddWord(string Word)
        {
            
            if(FirstLetter == null)
            {
                Console.WriteLine("There is no Letter here.......so we create Letter " + Word[0] +" from the Word "+Word);
                AddLetterFirst(Word[0]);
            }
            NodeLetter curr = FirstLetter;
            while (curr!=null&&curr.Letter != Word[0])
            { 
                curr = curr.Next;
            }
            if(curr == null)
            {
                Console.WriteLine("There is no Letter here.......so we create Letter " + Word[0] + " from the Word " + Word);
                AddLetterFirst(Word[0]);
                AddWord(Word);
                return;
            }
            NodeWord newWord = new NodeWord(Word);
            if (curr.Drop == null) 
            {
                curr.Drop = newWord;
                LastWord = newWord;
               
            }
            else
            {
                newWord.Next = curr.Drop;
                /*LastWord = newWord.Next;*/
                curr.Drop = newWord;
            }
            WLength++;
          
        }
        public void DeleteName(string Name)
        {
            NodeLetter currLetter = FirstLetter;
            while (Name[0] != currLetter.Letter)
            {
                currLetter = currLetter.Next;
            }
            NodeWord currWord = currLetter.Drop;
            if (WLength == 1) { currLetter.Drop = null; WLength--; }
            else if (currWord.Word == Name) {currLetter.Drop=currWord.Next; currWord = null; WLength--; }
        /*    else if (LastWord.Word == Name) { }*/
            else
            {
                currWord = currWord.Next;
                NodeWord PrevWord = currLetter.Drop;
                while (currWord!=null)
                {
                    if (currWord.Word == Name) break;
                    PrevWord = currWord;
                    currWord = currWord.Next;
                }
                if (currWord == null) { Console.WriteLine("No Word To Delete Here"); }
                else{
                    PrevWord.Next = currWord.Next;
                    if (LastWord == currWord)
                    {
                        LastWord = PrevWord;
                    }
                    WLength--;
                }
            }
            
        }
        public void Print()
        {
            NodeLetter currLetter = FirstLetter;
            Console.WriteLine("My List Is :");
            while (currLetter!=null)
            {
                NodeWord currWord = currLetter.Drop;
               
                Console.Write(currLetter.Letter+"--> ");
                while (currWord!=null)
                {
                    Console.Write(currWord.Word+"--> ");
                    currWord = currWord.Next;
                }
                Console.Write(@"
|
v
");
               currLetter=currLetter.Next;
            }

        }
        
    }
}

