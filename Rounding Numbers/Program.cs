double[] numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(double.Parse)
    .ToArray();

int[] num = new int[numbers.Length];

for (int i = 0; i < numbers.Length; i++)
{
    num[i] = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);
}
for (int i = 0 ;i < numbers.Length; i++)
{
    Console.WriteLine($"{numbers[i]} => {num[i]}");
}