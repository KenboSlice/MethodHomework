﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsWeekendHomeWork072316
{
    class Program
    {
        static void Main(string[] args)
        {
            //PROBLEM 1
            //Console.WriteLine("Type in a phrase");
            //string y = Console.ReadLine();
            //ReverseString(y);





            //PROBLEM 2
            //string.Compare("A", "a", true);
            //Console.WriteLine("Type out your first name:");
            //string a = Console.ReadLine();

            //Console.WriteLine("Type out your birth month:");
            //string b = Console.ReadLine();

            //NameBirthday(a,b);








            //PROBLEM 3
            //Console.WriteLine("Type out your first name?");
            //string c = Console.ReadLine();

            ////Spacing purposes to look cleaner while running
            //Console.WriteLine();

            //Console.WriteLine("Type out your last name?");
            //string d = Console.ReadLine();

            ////Spacing purposes to look cleaner while running
            //Console.WriteLine();

            //name(c, d);






            //PROBLEM 4
            Console.WriteLine("Type in a single word");
            string x = Console.ReadLine();
            ridOfZero(x);


            
            










            Console.ReadKey();
        }























        //PROBLEM 1
        //static void ReverseString(string x)
        //{
        //    string[] items = x.Split(' ');
        //    Array.Reverse(items);
        //    foreach(string s in items)
        //    {
        //        Console.Write(s + " ");
        //    }
        //}



        //"a":Jan, Feb, Mar, May, Jun, July, Sep, Nov, Dec.
        //"an": Apr, Aug, Oct
        //PROBLEM 2
        //static void NameBirthday(string x, string y)
        //{
        //    string.Compare("A", "a", true);
        //    if (y == "January")
        //    {
        //        Console.WriteLine(x + " is a January baby");
        //    }
        //    if (y == "February")
        //    {
        //        Console.WriteLine(x + " is a February baby");
        //    }
        //    if (y == "March")
        //    {
        //        Console.WriteLine(x + " is a March baby");
        //    }
        //    if (y == "May")
        //    {
        //        Console.WriteLine(x + " is a May baby");
        //    }
        //    if (y == "June")
        //    {
        //        Console.WriteLine(x + " is a june baby");
        //    }
        //    if (y== "July")
        //    {
        //        Console.WriteLine(x + " is a July baby");
        //    }
        //    if (y == "September")
        //    {
        //        Console.WriteLine(x + " is a September baby");
        //    }
        //    if (y == "November")
        //    {
        //        Console.WriteLine(x + " is a November baby");
        //    }
        //    if (y == "December")
        //    {
        //        Console.WriteLine(x + " is a December baby");
        //    }
        //    if (y == "April")
        //    {
        //        Console.WriteLine(x + " is an April baby");
        //    }
        //    if (y == "August")
        //    {
        //        Console.WriteLine(x + " is an August baby");
        //    }
        //    if (y == "October")
        //    {
        //        Console.WriteLine(x + " is an October baby");
        //    }
        //    else
        //    {
        //        Console.WriteLine("N/A");
        //    }
        //}




        //PROBLEM 3
        //static void name(string firstName, string lastName)
        //{
        //    string firstNameCasing = firstName.Substring(0, 1);
        //    string a = firstNameCasing.ToUpper();
        //    string restOfFirstName = firstName.Substring(1, firstName.Length -1);
        //    string entireFirstName = a + restOfFirstName;


        //    string lastNameCasing = lastName.Substring(0, 1);
        //    string b = lastNameCasing.ToUpper();
        //    string restOfLastname = lastName.Substring(1, lastName.Length -1);
        //    string entireLastName = b + restOfLastname;


        //    Console.Write(entireFirstName + " " + entireLastName);
        //}





        //PROBLEM 4
        static void ridOfZero(string a)
        {
            int indexZero = a.IndexOf('0');
            if (indexZero != -1)
            {
                string Remove = a.Remove(indexZero, 1);
                Console.WriteLine(Remove);
            }
            if (indexZero == -1)
            {
                Console.WriteLine("This string is okay!");
            }
        }














    }
}
