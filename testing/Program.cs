// See https://aka.ms/new-console-template for more information
using System.Globalization;

int width = Convert.ToInt32(Console.ReadLine());
int heigh = Convert.ToInt32(Console.ReadLine());
int n = width;
int m = heigh;
int[,] array = new int[heigh, width];
int counter = 1;
int k = 0;
int l = 0;

while ((n) != k && (m) != l)
{
    if((n) != k)
    {
        fillLineLeftToRight(n, l, k, ref counter, ref array);
        //printFunction(in array, heigh, width);
        l++;
        fillLineUpToDown(n, m, l, ref counter, ref array);
        //printFunction(in array, heigh, width);
        n--;
    }
    if((m) != l && n > 1)
    {
        fillLineRightToLeft(n, m, k, ref counter, ref array);
        //printFunction(in array, heigh, width);
        m--;
        fillLineDownToUp(n, m, l, k, ref counter, ref array);
        //printFunction(in array, heigh, width);
        k++;
    }
    
    //Console.WriteLine(n + " " + m + " " + l + " " + k + "\n");
}
printFunction(in array, heigh, width);

static void printFunction(in int[,] array, int m, int n)
{
    //Console.WriteLine(m + " " + n + " " + array.GetUpperBound(0) + " " + array.GetUpperBound(1));
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
    Console.WriteLine("");
}
static void fillLineLeftToRight(int n, int l, int k, ref int counter, ref int[,] array)
{
    for (int i = k; i < n; i++)
    {
        //Console.WriteLine(n + " " + k + " " + l + " " + counter + array.GetUpperBound(0) + " " + array.GetUpperBound(1));
        array[l, i] = counter++;
       // Console.WriteLine(array[l, i] + " " + l + " " + i + " " + array.GetUpperBound(1));
    }
}
static void fillLineUpToDown(int n, int m, int l, ref int counter, ref int[,] array)
{
    //Console.WriteLine(n + " " + m + " " + l);
    for (int i = l; i < m; i++)
    {
        array[i, n - 1] = counter++;
    }
}
static void fillLineRightToLeft(int n, int m, int k, ref int counter, ref int[,] array)
{
    for (int i = n - 1; i >= k; i--)
    {
        array[m - 1, i] = counter++;
    }
}
static void fillLineDownToUp(int n, int m, int l, int k, ref int counter, ref int[,] array)
{
    for (int i = m - 1; i >= l; i--)
    {
        array[i, k] = counter++;
        //Console.WriteLine(k + " " + n + " " + l + " " + m);
    }
}