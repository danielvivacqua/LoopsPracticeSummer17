using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsPracticeSummer17
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

            //For Loop
            //Can be used for both counting and/or ...
            // ITERATING through an array (or other collection type)
            //Looks like this:
            //for(initializer; condition; updater)
            //{
            //     Do something
            //}


            //int i;
            //for(int i = 15; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}
            // Console.WriteLine("After the loop has run, i now has the value of " + i);

            //for(int i = 50; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //string greeting = "My name is Little Bill.";
            ////The .Split() method takes a string and turns it into an array of smaller
            ////strings (substrings). It defaults the split on spaces.
            //string[] wordsInGreeting = greeting.Split();
            ////for loop to print the words
            //for(int i = 0; i < wordsInGreeting.Length; i++)
            //{
            //    Console.WriteLine(wordsInGreeting[i]);
            //}

            //Create an array called days with the elements Monday, Tuesday, and Wednesday.
            //Using a For Loop, print the elements of the days array.
            //string[] days = { "Monday", "Tuesday", "Wednesday" };
            //for(int i = 0; i < days.Length; i++)
            //{
            //    Console.WriteLine(days[i]);
            //}

            //Start with the string "Once upon a time" and create an array called
            //storyWords using the Split method. Reverse the order of the elements in
            //the array and using a For Loop, print each word
            //string story = "Once upon a time";
            //string[] storyWords = story.Split();
            //Array.Reverse(storyWords);
            //for(int i = 0; i < storyWords.Length; i++)
            //{
            //    Console.WriteLine(storyWords[i]);
            //}

            //Determine the product (multiplication) of 1 through 10 using a For Loop
            //Print the product to the screen
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int product = numbers[0];
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    product = product * numbers[i];
            //}
            //Console.WriteLine(product);

            //int product = 1;
            //for(int i = 1; i <= 10; i++)
            //{
            //    product = product * i;
            //}
            //Console.WriteLine(product);

            //Foreach loop - used to iterate over a collection (ex. list or array)
            //You can think of the structure of a foreach loop as the statement:
            //For each item in the collection, do something

            //foreach(datatype variable in collection)
            //{
            //     do something
            //}

            //string[] calendar = { "Jan", "Dog", "Mar", "Apr", "May", "Jun" };
            ////Always start with the keyword foreach
            //foreach(string month in calendar)
            //{
            //    Console.WriteLine(month);
            //}
            //foreach loops allow the temporary variable to "know" to assign
            //itself to each element in the collection (like an array), one at a time

            //Foreach loop will always go from beginning to end, no matter what
            //It counts the number of elements in the collection, and runs that many times

            ////Create an array of 6 musicians (bands or solo artists)
            ////Using a foreach loop, print each musician's name
            //string[] musicians = { "The Clash", "Tiger Army", "Justin Bieber", "The Scissor Sisters", "Childish Gambino", "Bach" };
            //foreach(string musician in musicians)
            //{
            //    Console.WriteLine(musician);
            //}

            //While loop is used when you want a chunk of code to run only if a 
            //condition is met first.
            //While something is TRUE, do this thing.

            //Console.WriteLine("What is your first name?");
            //string firstName = Console.ReadLine();
            //while(firstName.ToUpper() == "DANIEL")
            //{
            //    Console.WriteLine("Dude, you are amazing.");
            //    break;
            //}

            //Console.WriteLine("Do you want to play the game? YES/NO");
            //string playAgain = Console.ReadLine().ToUpper();
            //while(playAgain == "YES")
            //{
            //    Console.WriteLine("It's a rematch!");
            //    Console.WriteLine("Do you want to play again? YES/NO");
            //    playAgain = Console.ReadLine();
            //}

            //A Do-While loop is similar to a While loop, however
            //The Do-While loop is used when you want a chunk of code to run
            //AT LEAST ONCE, but repeat only if the While condition is met

            //The structure of a do-while loop looks like this:
            //do
            //{
            //     Do something
            //}
            //while(condition);

            //string playAgain;
            //do
            //{
            //    Console.WriteLine("Welcome to my game!");
            //    //let's pretend the code for the game is here
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

            //string answer;
            //string classes;
            //string grade;
            //Console.WriteLine("Would you like to add a class to your GPA calculation?");
            //answer = Console.ReadLine().ToLower();
            //if (answer == "yes")
            //{
            //    do
            //    {
            //        Console.WriteLine("What class would you like to add?");
            //        classes = Console.ReadLine();
            //        Console.WriteLine("Please enter your letter grade for this class.");
            //        grade = Console.ReadLine();
            //        Console.WriteLine("Would you like to add another class? YES/NO");
            //        answer = Console.ReadLine().ToLower();
            //    }
            //    while (answer == "yes");
            //}



            //NESTED LOOPS
            //Loop inside of another loop
            //The inner loop is executed more times than the outer loop
            //REAL LIFE EXAMPLE - Clock

            //Create a nested loop structure that prints:
            // 1234
            // 1234

            //for(int rows = 1; rows <= 2; rows++)
            //{
            //    for(int columns = 1; columns <= 4; columns++)
            //    {
            //        Console.Write(columns);
            //    }
            //    Console.WriteLine();
            //}

            //Print a Triangle
            //Outer loop will go line by line
            //The inner loop will go over different elements in the line.
            //Result:
            //1
            //1 2
            //1 2 3
            //1 2 3 4 ...

            Console.WriteLine("How many rows do you want in your triangle?");
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }





        }
    }
}
