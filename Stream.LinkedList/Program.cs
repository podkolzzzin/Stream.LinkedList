var list = new LinkedList<int>();
try
{
    while (true)
    {
        list.AddLast(0);
        if (list.Count % 100_000 == 0)
            Console.WriteLine(list.Count);
    }
}
finally
{
    Console.WriteLine(list.Count);
}
// 116 600 000
