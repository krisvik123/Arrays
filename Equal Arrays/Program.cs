int[] array1 = Console.ReadLine()
    .Split(' ')
    .Select(int.Parse)
    .ToArray();

int[] array2 = Console.ReadLine()
    .Split(' ')
    .Select(int.Parse)
    .ToArray();

bool areIdentical = true;
int differentIndex = -1;

if (array1.Length != array2.Length)
{
    areIdentical = false;
    differentIndex = Math.Min(array1.Length, array2.Length);
}
else
{
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i] != array2[i])
        {
            areIdentical = false;
            differentIndex = i;
            break;
        }
    }
}

if (areIdentical)
{
    int sum = array1.Sum();
    Console.WriteLine($"Arrays are identical. Sum: {sum}");
}
else
{
    Console.WriteLine($"Arrays are not identical. Found difference at {differentIndex} index");
}