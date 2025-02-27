// See https://aka.ms/new-console-template for more information

using System.Data;
using static System.Console;

static void Task1()
{
    Write("Enter array size: ");
    int n = int.Parse(ReadLine());

    int[] a = new int[n];

    int [,] b = new int [n,n];

    Random rand = new Random();

    for (int i = 0; i < n; i++)
    {
        a[i] = rand.Next(-9, 9);
    }
    for(int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            b[i,j] = rand.Next(-9, 9);
        }
    }

    for(int i = 0; i < n; i++)
    {
        if(i % 2 != 0)
        {
            if(a[i] > 0)
            {
                WriteLine($"[Positive element][{a[i]}][with odd index][{i}]");
            }
        }
    }
    WriteLine("Two dimensional array.");
    for(int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if(i % 2 != 0)
        {
            if(b[i, j] > 0)
            {
                WriteLine($"[Positive element][{b[i, j]}][with odd index][{i}]");
            }
        }
        }
    }
}

static void Task2()
{
    Write("Enter array size: ");
    int n = int.Parse(ReadLine());

    int[] a = new int[n];

    Random rand = new Random();

    for (int i = 0; i < n; i++)
    {
        a[i] = rand.Next(-9, 9);
    }

    int count = 0;

    for (int i = 0; i < a.Length-1; i++)
    {
        if(a[i] < a[i + 1])
        {
            count++;
            WriteLine($"[{a[i]}] < [{a[i + 1]}]");
        }
    } 
    for (int i = 0; i < a.Length; i++) 
        Write($"[{a[i]}]");

    WriteLine($"\nCount a[i] < a[i + 1]: {count}");
    
}

static void Task3()
{
    Write("Enter array size: ");
    int n = int.Parse(ReadLine());

    int [,] b = new int [n,n];

    Random rand = new Random();

    for(int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            b[i,j] = rand.Next(-9, 9);
        }
    }

    WriteLine("Before swap:");
    for(int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Write($"[{b[i,j]}]");
        }
        WriteLine();
    }

    for (int i = 0; i < n; i++) 
    {
        for (int j = 0; j < n / 2; j++) 
        {
            int temp = b[i, j]; 
            b[i, j] = b[i, n - j - 1]; 
            b[i, n - j - 1] = temp;
        }
    }
    WriteLine("After swap:");
    for(int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Write($"[{b[i,j]}]");
        }
        WriteLine();
    }
}

static void Task4()
{
    Write("Enter array size: ");
    int n = int.Parse(ReadLine());

    int[][] c = new int[n][];

    Random rand = new Random();

    for(int i = 0; i < n; i++)
    {
        c[i] = new int[rand.Next(1, 9)];
    }

    for (int i = 0; i < c.Length; i++)
    {
        for (int j = 0; j < c[i].Length; j++)
        {
            c[i][j] = rand.Next(-9, 9);
        }
    }

    for (int i = 0; i < c.Length; i++)
    {
        for (int j = 0; j < c[i].Length; j++)
        {
            Write($"[{c[i][j]}]");
        }
        WriteLine();
    }

    int[] a = new int[n];
    Write("Enter number: ");
    int x = int.Parse(ReadLine());

    for (int i = 0; i < c.Length; i++)
    {
        int count = 0;
        for (int j = 0; j < c[i].Length; j++)
        {
            if(c[i][j] > x) count++;
        }
        a[i] = count;
    }
    WriteLine("Result:");
    for(int i = 0; i < a.Length; i++)
        Write($"[{a[i]}]");
}

Task4();


