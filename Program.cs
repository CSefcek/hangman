Console.Title = "Hangman";
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
    "recursion", 
    "boolean", 
    "conditional", 
    "loops", 
    "methods"
};

Random random = new Random();
string wordToBeGuessed = words[random.Next(words.Length)];
int wordLength = wordToBeGuessed.Length;
char[] wordToBeGuessedArray = wordToBeGuessed.ToCharArray();


string blanks = new string('_', wordLength);
Console.WriteLine(blanks);


while (true)
{
    Console.WriteLine("Guess a letter!");
    char guess = Convert.ToChar(Console.ReadLine());

    for (int index = 0; index < wordToBeGuessedArray.Length; index++)
    {
        Console.WriteLine(wordToBeGuessedArray[index]);

    }

