using OrderedDictionary;

var orderedDictionary = new OrderedDictionary<int, string>();

for (var i = 0; i<100; i++)
{
    var random = new Random();
    while (orderedDictionary.TryAdd(random.Next(101), $"Вставка по порядку #{i}") is false)
    {

    }
}

foreach (var item in orderedDictionary)
{
    Console.WriteLine(item.Key+"\t"+item.Value);
}

Console.ReadKey();
