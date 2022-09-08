using System;
using System.Collections;
using System.Text;

namespace Day_7
{

    //collections
    /*
     * non -generic collections   Generic collections
     * ArrayList                    List
     * HashTable                    Dictionary
     * SortedList                   SortedList
     * Stack                        Stack
     * queue                        queue
     */



    class Class8
    {
        public static void Main()
        {
            Console.WriteLine("========ArrayList==============");
            ArrayList al = new ArrayList();
            string str = "Vikash";
            int x = 7;
            DateTime d = DateTime.Now;
            al.Add(str);
            al.Add(x);
            al.Add(d);
            al.Remove(x);
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("========HashTable==============");
            Hashtable ht = new Hashtable();
            ht.Add("asp","asp.net");
            ht.Add("cs", "cs.net");
            ht.Add("vb", "vb.net");
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key+"===>"+item.Value);
            }
            Console.WriteLine("========SortedList==============");
            SortedList sl = new SortedList();
            sl.Add("ora","oracle");
            sl.Add("asp", "asp.net");
            sl.Add("cs", "cs.net");
            sl.Add("vb", "vb.net");

            foreach (DictionaryEntry item in sl)
            {
                Console.WriteLine(item.Key + "===>" + item.Value);
            }

            Console.WriteLine("========Stack==============");
            Stack st = new Stack();
            st.Push("oracle");
            st.Push("asp.net");
            st.Push("cs.net");
            st.Push("vb.net");

            foreach (var item in st)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("========Queues==============");
            Queue q = new Queue();
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
