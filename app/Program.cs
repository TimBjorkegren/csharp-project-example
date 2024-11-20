using System.Diagnostics;

string[] possible_words = ["new", "banana", "apple", "cool"];
Random get_random = new();

string solution = possible_words[get_random.Next(possible_words.Length)];

char guess;
string? input;

do
{
    Console.WriteLine("Please enter a character to guess with");
    input = Console.ReadLine();
    Debug.Assert(input != null);
} while (input.Length == 1);

bool guess_was_correct = false;

foreach (char c in solution)
{
    if (guess == c)
    {
        guess_was_correct = true;
    }
}

if (guess_was_correct)
{
    Console.WriteLine($"{guess} exists in the word");
}
else
{
    Console.WriteLine($"{guess} does not exist in the word");
}





