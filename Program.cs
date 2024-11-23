using Referat1;

class Program
{
    private static void Main()
    {
        //    элементы графа    1, 2, 3,  4, 5,  6,  7,  8,  9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19
        int[] p = new int[19] { 4, 4, 13, 4, 12, 14, 13, 10, 3,  4,  2, 12,  8,  5,  0,  0,  0,  0, 5};
        int[] p0 = p;
        DSU m1 = new DSU(19, p0, 6, 4);
        int e1 = 3;
        int e2 = 6;
        Console.WriteLine($"Множества к которым принадлежат X = {e1} и Y = {e2}");
        Console.WriteLine($"X = {e1} в множестве с корнем {m1.Find(e1)}");
        Console.WriteLine($"Y = {e2} в множестве с корнем {m1.Find(e2)}\n");
        Console.WriteLine("Теперь объединим эти множества!"); m1.Unite(e2, e1);
        Console.WriteLine($"X = {e1} в множестве с корнем {m1.Find(e1)}");
        Console.WriteLine($"Y = {e2} в множестве с корнем {m1.Find(e2)}\n");
        Console.ReadKey();
    }
}
