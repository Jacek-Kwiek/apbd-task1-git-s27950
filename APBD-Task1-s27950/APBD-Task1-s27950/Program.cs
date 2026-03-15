// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, Wolrd 2");

// Interesting discretion

int[] intlist = new int[10] {1,2,3,4,5,6,7,8,9,10};

int sum = 0;

for (int i = 0; i < intlist.Length; i++)
{
    sum += intlist[i];
}

Console.WriteLine("average of numbers: " + sum/intlist.Length);

Console.WriteLine("average of numbers with function:" + average(intlist));

Console.WriteLine("maximum value in list: " + max(intlist));

Console.WriteLine("minimum value in list: " + min(intlist));
static int average(int[] intlist)
{

    int sum = 0;

    for (int i = 0; i < intlist.Length; i++)
    {
        sum += intlist[i];
    }

    return sum/intlist.Length;
}

static int max(int[] intlist)
{
    int max = intlist[0];
    for (int i = 1; i < intlist.Length; i++)
    {
        if(intlist[i] > max) { max = intlist[i]; }
    }
    return max;
}

static int min(int[] intlist)
{
    int min = intlist[0];
    for (int i = 1; i < intlist.Length; i++)
    {
        if (intlist[i] < min) { min = intlist[i]; }
    }
    return min;
}