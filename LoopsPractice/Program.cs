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

            //int[] studentGrades = { 4, 4, 3, 4, 3 };
            //foreach(int grade in studentGrades)
            //{
            //    Console.WriteLine(grade);
            //}


            //string[] firstMonths = { "Jan", "Feb", "Mar", "Apr", "May", "Jun" };
            ////Always start with the keyword foreach
            //foreach(string month in firstMonths)
            //{
            //    Console.WriteLine(month);
            //}
            ////foreach loops allow temporary variable to "know" to assign
            ////itself to each element in the collection (like an array), one at a time

            ////Foreach loop will always go from begginning to end, no matter what
            ////It counts the number of elements in the collection, and runs that number many times


            ////Create an array of 6 musicians (bands or solo artists)
            ////Using a foreach loop, print each musicains name
            //string[] nameOfBands = { "NIN", "RHCP", "Linkin Park", "Starset", "BMTH", "Disturbed" };
            //foreach(string bands in nameOfBands)
            //{
            //    Console.WriteLine(bands);
            //}


            //While loop is used when you want a chunk of code to run only if a
            //conditon is met first.
            //While something is TRUE, do this thing.

            //Console.WriteLine("What is your first name?");
            //string firstName = Console.ReadLine();
            //while (firstName.ToUpper() == "PAIGE")
            //{
            //    Console.WriteLine("Dude, you are amazing.");
            //    break;
            //}


            //Console.WriteLine("Do you want to play a game? YES/NO");
            //string playAgain = Console.ReadLine();//you can put .ToUpper with this or..
            //while (playAgain.ToUpper() == "YES")//..you can put .ToUpper in with the while
            //{
            //    Console.WriteLine("It's a rematch!");
            //    Console.WriteLine("Do you want to play again? YES/NO");
            //    playAgain = Console.ReadLine();
            //}


            //A Do-While loop is similiar to a while loop, however
            //the Do-While loop is used when you want a chunk of code to run AT LEAST ONCE,
            //but repeat only if the While condition is met

            //the structure of a Do-While loop looks like this:
            //do
            //{
            //      Do something
            //}
            //while(condition);

            //string playAgain;//does not need to be = " "; because essentially, there will always be a value in this case
            //do
            //{
            //    Console.WriteLine("Welcome to my game!");
            //    //lets pretend the code for the game is here
            //    Console.WriteLine("Great game!!");
            //    Console.WriteLine("Do you want to play again? YES/NO");
            //    playAgain = Console.ReadLine();
            //}
            //while (playAgain == "YES");


            //Ask the user for the class (in school) that they would like to add to their 
            //GPA calculation.
            //Ask the user for the letter grade for the class (no + or -)
            //Ask the user if they have another class they would like to add to their 
            //GPA calculation.
            //Using a Do-While Loop, repeat the code if the user says "YES"
            //string classGPA;
            //do
            //{
            //    Console.WriteLine("Which class would you like to add to your GPA calculation?");
            //    string classOne = Console.ReadLine();
            //    Console.WriteLine("What is the letter grade for that class?");
            //    string classGrade = Console.ReadLine();
            //    Console.WriteLine("Do you have another class that you would like to add to your GPA calculation? YES/NO");
            //    classGPA = Console.ReadLine();
            //}
            //while (classGPA == "YES");



            //NESTED LOOPS
            //It is a loop nested inside another loop
            //The inner loop is executed more times than the outer loop
            //REAL LIFE EXAMPLE - Clock

            //Create a nested loop structure that prints:
            // 1234
            // 1234

            //for (int rows = 1; rows <= 2; rows++)
            //{
            //   for(int columns = 1; columns <= 4; columns++)
            //    {
            //        Console.Write(columns);
            //    }
            //    Console.WriteLine();
            //}


            //Print a triangle
            //Outer loop will go line by line
            //The inner loop will go over different elements in the line.
            //Result:
            //1
            //1 2
            //1 2 3
            //1 2 3 4 ...

            //for(int rows = 1; rows <= 4; rows++)//you can replace the 4 with any number you want too. Just CW "How many would you like in your row?"
            //{
            //    for (int columns =1 ; columns <= rows; columns++) 
            //    {
            //        Console.Write(columns);
            //    }
            //    Console.WriteLine();
            //}


            ////Remember that in FizzBuzz, if it is not a FizzBuzz, Fizz, or Buzz number
            ////you print the number itself.
            //Console.WriteLine("Let's Play FizzBuzz!");
            //Console.WriteLine("Please enter your FIZZ number");
            //int fizz = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter your BUZZ number");
            //int buzz = int.Parse(Console.ReadLine());
            //Console.WriteLine("What number would you like me to count to? (Pick a high one)");
            //int endNumber = int.Parse(Console.ReadLine());
            //for (int i = 0; i <= endNumber; i++)
            //{
            //    if (i % fizz == 0 && i % buzz == 0)
            //    {
            //        Console.WriteLine("Fizz Buzz!");
            //    }
            //    else if (i % fizz == 0)
            //    {
            //        Console.WriteLine("Fizz!");
            //    }
            //    else if (i % buzz == 0)
            //    {
            //        Console.WriteLine("Buzz!");
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //}









        }
    }
}
