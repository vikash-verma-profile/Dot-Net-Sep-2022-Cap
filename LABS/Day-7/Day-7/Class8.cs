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
            
        }
    }
}
