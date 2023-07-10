using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Analyser
{
    class Program
    {
        static Dictionary<string, int> WordFrequencies(string senInput)
        {
            // spliting paramter string by spaces
            string[] words = senInput.Split(' ');
            // creating dictionary for making pair values
        Dictionary<string, int> wordFrequencies = new Dictionary<string, int>();

            // using loop to traverse
            foreach (string word in words)
            {
                if (wordFrequencies.ContainsKey(word))
                {
                    wordFrequencies[word]++;
                }
                else
                {
                    wordFrequencies[word] = 1;
                }
            }
            // return output
            return wordFrequencies;
        }

        static void SentenceMaker(string senInput, int N)
        {
            // taking and spliting the paramter string by spaces
            string[] temp_arr = senInput.Split(' ');

            // using 2D array with N rows (enter by user) and coloums
            string[,] shuffled_arr = new string[N, temp_arr.Length];

            // using class for random function
            Random random = new Random();

            // using loop for rows
            for (int i = 0; i < N; i++)
            {
                // using loop for coloums
                for (int j = 0; j < temp_arr.Length; j++)
                {
                    // choosing 1 random index
                    int index = random.Next(0, temp_arr.Length);

                    // putting random index values to 2D array 
                    shuffled_arr[i, j] = temp_arr[index];
                }
            }

            // using loops to print the shuffled array
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < temp_arr.Length; j++)
                {
                    Console.Write(shuffled_arr[i, j] + (" "));
                }
                Console.WriteLine();
                
            }
            Console.ReadKey();
        }


        static void LongestandShortestWordFinder(string senInput)
        {
            // taking function parameter and spliting it by spaces then storing into new string
            string[] newstr = senInput.Split(' ');
            string[] arr = new string[newstr.Length];

            for (int i = 0; i < newstr.Length; i++)
            {
             //   Console.WriteLine(newstr[i] + ": " + newstr[i].Length);
                arr[i] = newstr[i];
            }

            // declear new intgers for storing max and min value into them
            int max = 0;
            int min = arr[0].Length;

            // assing empty values
            string maximum = "";
            string minimum = "";

            // loop to traverse length and store max and min value
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i].Length)
                {
                    max = arr[i].Length;
                    maximum = arr[i];

                }


                if (min > arr[i].Length)
                {
                    min = arr[i].Length;
                    minimum = arr[i];
                }

            }

            // output result
            Console.WriteLine("Longest word(s) is: " + maximum);
            Console.WriteLine("Shortest word(s) is: " + minimum);
            Console.ReadKey();
        }

        static void WordSearch(string senInput)
        {
            // input search word from user
            Console.WriteLine("Please enter the word to search");
            string word = (Console.ReadLine());

            // spliting function paramter by spaces into an array
            string[] newstr = senInput.Split(' ');
            int count = 0;

            // loop if search word matches the entire loop it will count its value
            for (int i = 0; i < newstr.Length; i++)
            {
                if (word == newstr[i])
                {
                    count++;
                }
            }

            // output result
            Console.WriteLine("The word '" + word + "' appears " + count + " time(s) in a sentence");
            Console.ReadKey();
        }

        static bool IsPalindrome(string str)
        {
            // 2 integers assiing value to start and end of string
            int left = 0;
            int right = str.Length - 1;

            // if not palindrome return false until then traversing both start and end
            while (left < right)
            {
                if (str[left] != str[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }

        static void PalindromeDetector(string senInput)
        {
            // spliting function paramter
            string[] newstr = senInput.Split(' ');
            int check = 0;

            // loop to traverse the array
            for (int i = 0; i < newstr.Length; i++)
            {
                // if palindrom true assign 1 to check integer
                if (IsPalindrome(newstr[i]) == true)
                {
                    // output if palindrome
                    Console.WriteLine("The word '" + newstr[i] + "' is Palindrome");
                    check = 1;
                }
            }

            // if no palidrome values remains 0 and show output
            if (check == 0)
            {
                Console.WriteLine("There are no Palindrom words in the sentence");
                
            }
            Console.ReadKey();

        }

        static void VovelConsonent(string abc)
        {
            // assigning 0 values will use for counting
            int vovel = 0;
            int consonent = 0;

            // loop to check if user input matches the if condition
            for (int i = 0; i < abc.Length; i++)

            {
                if (abc[i] == 'A' || abc[i] == 'a' || abc[i] == 'E' || abc[i] == 'e' || abc[i] == 'I' || abc[i] == 'i' || abc[i] == 'O' || abc[i] == 'o' || abc[i] == 'U' || abc[i] == 'u')
                {
                    // if vovels matches vovel++
                    vovel++;
                }
                else
                {
                    // else consonent++
                    consonent++;
                }

            }

            // output result
            Console.WriteLine(abc + ": " + vovel + " vovel(s) and " + consonent + " consonent(s)");
            Console.ReadKey();
        }

        static void VovelConsonantCounter(string senInput)
        {
            // spliting function paramter into string array
            char[] delimiterChars = { ',' };
            string[] newstr = senInput.Split(delimiterChars);
            for (int i = 0; i < newstr.Length; i++)
            {
                //calling another function
                VovelConsonent(newstr[i]);
            }
        }
        static void Main(string[] args)
        {
            // app welcome line and asking user to enter sentence
            Console.WriteLine("\nWelcome to the Text Analyzer \nPlease enter a sentence");

            // storing input from the user
            string senInput = (Console.ReadLine());

            // asking the user to press their desired number
            Console.WriteLine("\nPlease choose the following by pressing number \n\n1. Word Frequency Analysis \n2. Sentence Maker \n3. Longest and Shortest Word Finder \n4. Word Search \n5. Palindrome Detector \n6. Vovel/Consonant Counter");

            int choice = int.Parse(Console.ReadLine());

            // condition if user enter 1
            if (choice == 1)
            {
                // calling function
                Dictionary<string, int> wordcount = WordFrequencies(senInput);

                // using loop to display result
                foreach (var pair in wordcount)
                {
                    Console.WriteLine($"Word: {pair.Key} \t Count: {pair.Value}");
                }
                Console.ReadKey();
            }

            // if user enters 2
            else if (choice == 2)
            {
                // input from user
                Console.WriteLine("Please enter N value");
                int N = int.Parse(Console.ReadLine());

                // calling the function
                SentenceMaker(senInput, N);
            }

            else if (choice == 3)
            {
                // calling the function
                LongestandShortestWordFinder(senInput);
            }
            else if (choice == 4)
            {
                // calling the function
                WordSearch(senInput);
            }
            else if (choice == 5)
            {
                // calling the function
                PalindromeDetector(senInput);
            }
            // calling the function
            else if (choice == 6)
            {
                // calling the function
                VovelConsonantCounter(senInput);
            }
        }
    }
}
