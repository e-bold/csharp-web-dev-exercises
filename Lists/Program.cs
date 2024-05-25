//Exercises: Control Flow & Collections

//TODO: Write your code for List Practice below:


//Checks even numbers and adds all of them
static int sumEven(List<int> arr)
{
   int total = 0;
   foreach (int integer in arr)
   {
      if (integer % 2 == 0)
      {
         total += integer;
      }
   }
   return total;
}


List<int> newList = new List<int> {25, 20, 32, 48, 19, 3, 8, 11, 90, 100};


Console.WriteLine(sumEven(newList));



List <string> wordList = new List<string> {"anna", "blake", "jerome", "bruce"};

//Write a static method to print out each word in a list that has exactly 5 letters.


static void printFiveLetterWords(List<string> wordlist)
{
   foreach (string word in wordlist)
   {
      if (word.Length == 5)
      {
         Console.WriteLine(word);
      }
   }
};

//Modify your code to prompt the user to enter the word length for the search.

   Console.Write("Enter a word length: ");
   string numInput = Console.ReadLine();
   int numChars = int.Parse(numInput);
   Console.WriteLine("You have entered " + numChars + " for the word length.");

// Call the method to print out list words of the chosen length:
   printXLetterWords(wordList, numChars);


   static void printXLetterWords(List<string> wordlist, int length)
   {
      foreach (string word in wordlist)
      {
         if (word.Length == length)
         {
            Console.WriteLine(word);
         }
      }
   }
