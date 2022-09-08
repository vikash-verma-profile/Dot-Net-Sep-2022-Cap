using System;
using System.Collections.Generic;
using System.Text;

namespace Day_7
{
    class Class9
    {
        public static void Main()
        {
            Console.WriteLine("========List==============");
            List<int> al = new List<int>();
            al.Add(1);
            al.Add(2);
            al.Add(3);
            al.Remove(1);
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("========Dictionay==============");
            Dictionary<string,string> ht = new Dictionary<string, string>();
            ht.Add("asp", "asp.net");
            ht.Add("cs", "cs.net");
            ht.Add("vb", "vb.net");
            foreach (KeyValuePair<string,string> item in ht)
            {
                Console.WriteLine(item.Key + "===>" + item.Value);
            }
            Console.WriteLine("========SortedList==============");
            SortedList<string,string> sl = new SortedList<string, string>();
            sl.Add("ora", "oracle");
            sl.Add("asp", "asp.net");
            sl.Add("cs", "cs.net");
            sl.Add("vb", "vb.net");

            foreach (KeyValuePair<string, string> item in sl)
            {
                Console.WriteLine(item.Key + "===>" + item.Value);
            }

            Console.WriteLine("========Stack==============");
            Stack<string> st = new Stack<string>();
            st.Push("oracle");
            st.Push("asp.net");
            st.Push("cs.net");
            st.Push("vb.net");

            foreach (var item in st)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("========Queues==============");
            Queue<string> q = new Queue<string>();
            q.Enqueue("oracle");
            q.Enqueue("asp.net");
            q.Enqueue("cs.net");
            q.Enqueue("vb.net");

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
        }
    }
}
