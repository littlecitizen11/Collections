using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;

namespace Collection
{
    class Program
    {
        public static void ListOperations(List<string> mylist)
        {
            if (mylist.Count < 0)
            {
                return;
            }
            mylist.RemoveAt(mylist.Count / 2);
            if (!String.IsNullOrEmpty((mylist.Find(x => x.Contains("mamas")))))
            {
                mylist.Add("6");
            }
            foreach (var item in mylist) //check for 1st
            {
                Console.WriteLine(item);
            }
            int aramindex = mylist.FindIndex(x => x.Contains("aram"));
            if (aramindex>-1&&aramindex%2!=0)
            {
                mylist.Reverse();
            }
            foreach (var item in mylist) //check for 2nd
            {
                Console.WriteLine(item);
            }
            if (mylist.Distinct().Count()>=3)
            {
                List<string> str = new List<string>{ "2", "3", "4" };
                mylist.InsertRange(1, str);
            }
            foreach (var item in mylist) //check for 3rd
            {
                Console.WriteLine(item);
            }

        }

        public static void DictionaryOperations(Dictionary<string, int> dict)
        {
            if (dict == null)
                return;
            if (dict.Keys.Contains("Scuba"))
            {
                int numtocheck;
                if(dict.TryGetValue("Scuba", out numtocheck))
                    if (numtocheck == 6) 
                    dict.Add("Empire", 6); 
            }
        }
        public static void StackOperations(Stack<DateTime> datetimestack)
        {
            if (datetimestack == null)
                return;
            if(datetimestack.Peek()<DateTime.Now)
            {
                datetimestack.Pop();
                datetimestack.Push(DateTime.Now);
            }
        }
        static void Main(string[] args)
        {
            List<string> a = new List<string> { "guy", "guy", "daniel", "ben" };
            Dictionary<string, int> d = new Dictionary<string, int> { { "Scuba",6 } };
            DictionaryOperations(d);
        }
    }
}
