using System;
using System.Collections.Generic;
using System.Text;

namespace Day_7
{
    /// <summary>
    /// indexers
    /// </summary>
    /// 

    //indexers vs properties
    class IndexerClass
    {
        private string[] name = new string[3];
        public string this[int i]
        {
            get
            {
                return name[i];
            }
            set
            {
                name[i] = value;
            }
        }
    }
    class Class7
    {
        //indexers will be created using this keyword
        public static void Main8()
        {
            IndexerClass c = new IndexerClass();
            c[0] = "Vikash Verma";
            c[1] = "Raj Kumar";
            c[2] = "Ravi";

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(c[i]);
            }

        }
    }
}
