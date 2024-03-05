using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Using_HashSets
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] names1 = new string[] { "mahesh","sabnis","manish","sharma","saket","karnik" };

            string[] names2 = new string[] { "suprotim","agarwal","vikram","pendse","mahesh","mitkari" };
            //2.

            HashSet<string> hSetN1 = new HashSet<string>(names1);
            Console.WriteLine("Data in First HashSet");
            foreach (var n in hSetN1)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("_______________________________________________________________");
            HashSet<string> hSetN2 = new HashSet<string>(names2);
            Console.WriteLine("Data in Second HashSet");
            foreach (var n in hSetN2)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("________________________________________________________________");
            //3.
            Console.WriteLine("Data After Union");
            hSetN1.UnionWith(hSetN2);
            foreach (var n in hSetN1)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine();
            Console.WriteLine("_________________________________");
            Console.WriteLine("Data in HashSet before using Except With");
            Console.WriteLine("_________________________________");
            //storing data of hSetN3 in temporary HashSet
            HashSet<string> hSetN3 = new HashSet<string>(names1);
            foreach (var n in hSetN3)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();
            Console.WriteLine("_________________________________");
            Console.WriteLine("Using Except With");
            Console.WriteLine("_________________________________");
            hSetN3.ExceptWith(hSetN2);
            foreach (var n in hSetN3)
            {
                Console.WriteLine(n);
            }


            HashSet<string> hSetN4 = new HashSet<string>(names1);
            Console.WriteLine("_________________________________");
            Console.WriteLine("Elements in HashSet before using SymmetricExceptWith");
            Console.WriteLine("_________________________________");
            Console.WriteLine("HashSet 1");
            foreach (var n in hSetN4)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("HashSet 2");
            foreach (var n in hSetN2)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("_________________________________");
            Console.WriteLine("Using SymmetricExceptWith");
            Console.WriteLine("_________________________________");
            hSetN4.SymmetricExceptWith(hSetN2);
            foreach (var n in hSetN4)
            {
                Console.WriteLine(n);
            }



            Get_Add_Performance_HashSet_vs_List();

            /// In this method the list 

        }

        static string[] names = new string[] {
    "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis", "Leena",
    "Neema", "Sita" , "Tejas", "Mahesh", "Ramesh", "Ram",
    "GundaRam", "Sabnis", "Leena", "Neema", "Sita" ,
    "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam",
    "Sabnis", "Leena", "Neema", "Sita" , "Tejas",
    "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",
    "Leena", "Neema", "Sita",
    "Tejas", "Mahesh", "Ramesh", "Ram", "GundaRam", "Sabnis",          };


        static void Get_Add_Performance_HashSet_vs_List()
        {

            Console.WriteLine("____________________________________");
            Console.WriteLine("List Performance while Adding Item");
            Console.WriteLine();
            List<string> lstNames = new List<string>();
            var s2 = Stopwatch.StartNew();
            foreach (string s in names)
            {
                lstNames.Add(s);
            }
            s2.Stop();

            Console.WriteLine(s2.Elapsed.TotalMilliseconds.ToString("0.000 ms")); Console.WriteLine();
            Console.WriteLine("Ends Here");
            Console.WriteLine();
            Console.WriteLine("____________________________________");
            Console.WriteLine("HashSet Performance while Adding Item");
            Console.WriteLine();

            HashSet<string> hStringNames = new HashSet<string>(StringComparer.Ordinal);
            var s1 = Stopwatch.StartNew();
            foreach (string s in names)
            {
                hStringNames.Add(s);
            }
            s1.Stop();

            Console.WriteLine(s1.Elapsed.TotalMilliseconds.ToString("0.000 ms")); Console.WriteLine();
            Console.WriteLine("Ends Here");
            Console.WriteLine("____________________________________");
            Console.WriteLine();

        }

    }
}
