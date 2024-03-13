Console.WriteLine("Hello, User!!! YO!");
int[] arr = { 1, 2, 3, 4, 5 };
Console.WriteLine(GetAvg(arr));

static double GetAvg(int[] arr)
{
    int sum = 0;
    foreach (var num in arr)
    {
        sum += num;
    }

    return (double)sum / arr.Length;
}