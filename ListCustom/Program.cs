
using System;
using System.Collections.Generic;

namespace ListCustom
{
    class Program
    {   
        static void Main(string[] args)
        {
            Mylist<int> mylist = new();
            mylist.Add(12);
            mylist.Add(12);
            mylist.Add(12);
            mylist.Add(4);
            mylist.Add(5);
             mylist.Add(3);
            mylist.Insert (7, 0);          
            Console.WriteLine( mylist.Contains(48));
           
        }
    }
}
