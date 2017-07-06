using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //When would you use a loop?
            //Why would you use a loop?
            //Nested Loops
            //Infinite Loops
            //Keywords break and continue
            //allows for a repeated chunk of a code

            //For Loop
            //Can be used for both counting and/or ...
            //ITERATING through an array (or other collection type)
            //looks like this:
            //for(initializer; condition; updater)
            //{
            //      Do something
            //}
            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //for(int i = 15; i > 0; i--) 
            //{
            //    Console.WriteLine(i);
            //}

            //for(int i = 50; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //string greeting = "My name is Little Bill.";
            ////The .Split() method takes a string and turns it into an array of smaller
            ////strings (substrings). It defaults the split on spaces.
            //string[] wordsInGreeting = greeting.Split();
            ////for loop to print the words
            //for (int i = 0; i < wordsInGreeting.Length; i++)
            //{
            //    Console.WriteLine(wordsInGreeting[i]);
            //}

            ////Create an array called days with the elements Monday, Tuesday, and Wednesday.
            ////Using a For Loop, print the elements of the days array
            //string days = "Monday, Tuesday, Wednesday.";
            //string[] daysOfWeek = days.Split();
            //for (int i = 0; i < daysOfWeek.Length; i++)
            //{
            //    Console.WriteLine(daysOfWeek[i]);
            //}


            ////Start with the strings "Once upon a time" and create an array called
            ////storyWords using the Split method. Reverse the order of the elements in
            ////the array and using a For Loop, print each word.
            //string storyTime = "Once upon a time";
            //string[] storyWords = storyTime.Split();
            //Array.Reverse(storyWords);
            //for (int i = 0; i < storyWords.Length; i++)
            //{
            //    Console.WriteLine(storyWords[i]);
            //}


            ////Add the product (mulitplication) of 1 through 10 using a For Loop
            ////Print the product to the screen.
            //int product = 1;
            //for(int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(product = product * i);
            //    ////C.W in the curly brackets if you want it to print product of each on every line
            //}
            ////or
            //int product = 1;
            //for(int i = 1; i <= 10; i++)
            //{
            //    product = product * i;
            //}
            //Console.WriteLine(product);



            //Foreach Loops - used to literate over a collection (ex. list or array)
            //You can think of the structure of a foreach loop as the statement;
            //For each item in the collection, do something

            //foreach(dataType variable in collection)
            //{
            //    do something
            //}

            int[] studentGrades = { 4, 4, 3, 4, 3 };
            foreach(int grade in studentGrades)
            {
                Console.WriteLine(grade);
            }


            string[] firstMonths = { "Jan", "Feb", "Mar", "Apr", "May", "Jun" };
            //Always start with the keyword foreach
            foreach(string month in firstMonths)
            {
                Console.WriteLine(month);
            }
            //foreach loops allow temporary variable to "know" to assign
            //itself to each element in the collection (like an array), one at a time

            //Foreach loop will always go from begginning to end, no matter what
            //It counts the number of elements in the collection, and runs that number many times


            //Create an array of 6 musicians (bands or solo artists)
            //Using a foreach loop, print each musicains name
            string[] nameOfBands = { "NIN", "RHCP", "Linkin Park", "Starset", "BMTH", "Disturbed" };
            foreach(string bands in nameOfBands)
            {
                Console.WriteLine(bands);
            }
            
            
            




        }
    }
}
