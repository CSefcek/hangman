Console.Title = "Hangman";
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("Welcome to Hangman!");

string[] hangman = new string[8]
{
    """
    +---+
           |
           |
           |
           |
           |
    ======= 
    """,
    """
    +---+
      |    |
           |
           |
           |
           |
    =======
    """,
    """
    +---+
      |    |
      O    |
           |
           |
           |
    =======
    """,
    """
    +---+
      |    |
      O    |
     /     |
           |
           |
    =======
    """,
    """
    +---+
      |    |
      O    |
     /|    |
           |
           |
    =======
    """,
    """
    +---+
      |    |
      O    |
     /|\   |
           |
           |
    =======
    """,
    """
    +---+
      |    |
      O    |
     /|\   |
     /     |
           |
    =======
    """,
    """
    +---+
      |    |
      O    |
     /|\   |
     / \   |
           |
    =======
    """

};

string[] words = new string[10] 
{
    "kernel",
    "classes", 
    "console", 
    "coffee", 
    "arrays", 
    "switches", 
    "boolean", 
    "memory", 
    "loops", 
    "methods"
};

Random random = new Random();
string wordToBeGuessed = words[random.Next(words.Length)];
int wordLength = wordToBeGuessed.Length;
char[] wordToBeGuessedArray = wordToBeGuessed.ToCharArray();


string blanks = new string('_', wordLength);
char[] blanksArray = blanks.ToCharArray();
Console.WriteLine(blanks);

int attemptsLeft = hangman.Length;
int asciiCounter = 0;


while (true)
{
    Console.WriteLine("Guess a letter!");
    char guess = Convert.ToChar(Console.ReadLine());
    attemptsLeft--;

    
    bool foundAny = false; 


    for (int index = 0; index < wordToBeGuessedArray.Length; index++)
    {
        if (guess == wordToBeGuessedArray[index])
        {
            for (int index2 = 0; index2 < blanksArray.Length; index2++)
            {
                if (index == index2)
                {
                    blanksArray[index2] = guess;
                    foundAny = true;
                    break;
                }
            }
        }
    }

    Console.WriteLine();
    Console.WriteLine(blanksArray);
    Console.WriteLine();

    if (!foundAny && asciiCounter < hangman.Length - 1)
    {
        asciiCounter++;
    }

    Console.WriteLine();
    Console.WriteLine(hangman[asciiCounter]);
    Console.WriteLine();

    if (new string(blanksArray) == wordToBeGuessed)
    {
        Console.WriteLine();
        Console.ForegroundColor= ConsoleColor.DarkYellow;
        Console.WriteLine("YOU WIN!");
        Console.ResetColor();
        Console.WriteLine();
        break;
    }

    if (attemptsLeft == 0)
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Game Over");
        Console.WriteLine("The secret word was:");
        Console.WriteLine(wordToBeGuessed);
        Console.ResetColor();
        break;
    }

}

