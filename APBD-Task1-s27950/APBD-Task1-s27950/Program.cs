// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, Wolrd 2");

int[] intlist = new int[10] {1,2,3,4,5,6,7,8,9,10};

int sum = 0;

for (int i = 0; i < intlist.Length; i++)
{
    sum += intlist[i];
}