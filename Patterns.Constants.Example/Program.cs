using Example.Constants;

Console.WriteLine($"Constant To Dictionary Example: ");

foreach(var value in ConstantToDictionary.All)
{
    Console.WriteLine($"{value.Key}: {value.Value}");
}
Console.WriteLine();
Console.WriteLine($"Constant To Type Collection Example: ");

foreach (var value in ConstantToTypeCollection.All)
{
    Console.WriteLine($"{value.Name}: {value.Value}");
}

Console.WriteLine();
Console.WriteLine("Press any key to exit...");
Console.Read();