var list = new List<int>();
try
{
    while (true)
    {
        list.Add(0);
        if (list.Count % 100_000 == 0)
            Console.WriteLine(list.Count);
    }
}
finally
{
    Console.WriteLine(list.Count);
}