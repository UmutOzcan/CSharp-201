
List<string> cities = new();
cities.Add("Istanbul");
cities.Add("Sakarya");
Console.WriteLine(cities.Count);
//foreach (var city in cities)
//{
//    Console.WriteLine(city);
//}

Console.WriteLine();

MyList<string> cities2 = new();
cities2.Add("Ankara");
cities2.Add("Konya");
Console.WriteLine(cities2.Count);
//foreach (var city in cities2)
//{
//    Console.WriteLine(city);
//}

Console.ReadKey();


class MyList<T> // Generic Class
{
    T[] _array;
    T[] _temp;

    public MyList()
    {
        _array = new T[0];
    }
    public void Add(T item)
    {
        _temp = _array;
        _array = new T[_array.Length + 1];

        for (int i = 0; i < _temp.Length; i++)
        {
            _array[i] = _temp[i];
        }

        _array[_array.Length - 1] = item;
    }

    public int Count
    {
        get { return _array.Length; }
    }

}