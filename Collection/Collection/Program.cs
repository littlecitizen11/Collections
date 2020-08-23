using System;
using System.Collections.Generic;
using System.Linq;

namespace Collection
{
    class Program
    {
        public static void ListOperations(List<string> myList)
        {
            if (myList.Count < 0)
            {
                return;
            }
            myList.RemoveAt(myList.Count / 2);
            if (!String.IsNullOrEmpty((myList.Find(x => x.Contains("mamas")))))
            {
                myList.Add("6");
            }
            foreach (var itemInList in myList) //check for 1st
            {
                Console.WriteLine(itemInList);
            }
            int aramIndex = myList.FindIndex(x => x.Contains("aram"));
            if (aramIndex > -1&& aramIndex % 2!=0)
            {
                myList.Reverse();
            }
            foreach (var itemInList in myList) //check for 2nd
            {
                Console.WriteLine(itemInList);
            }
            if (myList.Distinct().Count()>=3)
            {
                List<string> str = new List<string>{ "2", "3", "4" };
                myList.InsertRange(1, str);
            }
            foreach (var itemInList in myList) //check for 3rd
            {
                Console.WriteLine(itemInList);
            }

        }

        public static void DictionaryOperations(Dictionary<string, int> dict)
        {
            if (dict == null)
                return;
            if (dict.Keys.Contains("Scuba"))
            {
                int numToCheck;
                if(dict.TryGetValue("Scuba", out numToCheck))
                    if (numToCheck == 6) 
                    dict.Add("Empire", 6); 
            }
        }
        public static void StackOperations(Stack<DateTime> dateTimeStack)
        {
            if (dateTimeStack == null)
                return;
            if(dateTimeStack.Peek()<DateTime.Now)
            {
                dateTimeStack.Pop();
                dateTimeStack.Push(DateTime.Now);
            }
        }
        static void Main(string[] args)
        {
            List<string> checkList = new List<string> { "guy", "guy", "daniel", "ben" };
            Dictionary<string, int> checkDict = new Dictionary<string, int> { { "Scuba",6 } };
            DictionaryOperations(checkDict);
        }
    }
}
