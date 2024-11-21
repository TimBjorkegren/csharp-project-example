using System.Diagnostics;

string[] possible_words = ["new", "banana", "apple", "cool"];
Random get_random = new();
string solution = possible_words[get_random.Next(possible_words.Length)];
string guess = get_user_guess();

string display = new('_', solution.Length);
Console.WriteLine(display);

do
{
    Console.WriteLine("Please enter a character to guess with");
    string? input = Console.ReadLine();
    Debug.Assert(input != null);
    if (input.Length == 1)
    {
        guess = input[0];
    }
} while (guess == null);

bool guess_was_correct = false;

for (int i = 0; i < solution.Length; i += 1)
{
    if (guess == solution[i])
    {
        display.Remove(i, 1);
        display.Insert(i,guess);
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

char get_user_guess()
{
    string? guess == null;
    do
    {
        Console.WriteLine("Please enter a character to guess with");
        string? input = Console.ReadLine();
        Debug.Assert(input != null);
        if (input.Length == 1)
        {
            guess = input[0];
        }
    } while (guess == null);
    return guess;
}



