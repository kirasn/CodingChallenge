// See https://aka.ms/new-console-template for more information
using RobotInAGrid;

int[,] test1 = new int[3, 5]{
    {0, 0, 1, 0, 0},
    {1, 0, 0, 0, 1},
    {1, 0, 0, 0, 0}
};

try
{
    for (int i = 0; i < test1.GetLength(0); i++)
    {
        for (int j = 0; j < test1.GetLength(1); j++)
        {
            Console.Write("{0} ", test1[i, j]);
        }
        Console.WriteLine();
    }

    Solution sol1 = new Solution();
    List<Point> result1 = sol1.GetPath(test1);

    Console.Write("Result: ");
    foreach (var item in result1)
    {
        Console.Write(item + " ");
    }
}
catch (System.Exception e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine("\n------------------------");

int[,] test2 = new int[4, 4]{
    {0, 0, 1, 0},
    {0, 1, 0, 0},
    {0, 0, 1, 0},
    {1, 0, 0, 0}
};

try
{
    for (int i = 0; i < test2.GetLength(0); i++)
    {
        for (int j = 0; j < test2.GetLength(1); j++)
        {
            Console.Write("{0} ", test2[i, j]);
        }
        Console.WriteLine();
    }

    Solution sol2 = new Solution();
    List<Point> result2 = sol2.GetPath(test2);

    Console.Write("Result: ");
    foreach (var item in result2)
    {
        Console.Write(item + " ");
    }
}
catch (System.Exception e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine("\n------------------------");

int[,] test3 = new int[2, 2]{
    {0, 1},
    {1, 0}
};

try
{
    for (int i = 0; i < test3.GetLength(0); i++)
    {
        for (int j = 0; j < test3.GetLength(1); j++)
        {
            Console.Write("{0} ", test3[i, j]);
        }
        Console.WriteLine();
    }

    Solution sol3 = new Solution();
    List<Point> result3 = sol3.GetPath(test3);

    Console.Write("Result: ");
    foreach (var item in result3)
    {
        Console.Write(item + " ");
    }
}
catch (System.Exception e)
{
    Console.WriteLine("Result: " + e.Message);
}