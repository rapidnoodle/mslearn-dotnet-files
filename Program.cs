foreach (string file in GetSales())
{
    Console.WriteLine(file);
}

IEnumerable<string> GetSales()
{
    List<string> list = new List<string>();

    IEnumerable<string> files = Directory.EnumerateFiles("stores", "sales.json", SearchOption.AllDirectories);

    foreach (string file in files)
    {
        list.Add(file);
    }

    return list;
}