string[] characters = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();
for (int i = characters.Length - 1; i >= 0; i--)
{
    Console.Write(characters[i] + " ");
}