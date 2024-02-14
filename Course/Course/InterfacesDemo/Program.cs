// Interface Segregation SOLID
IWorker[] workers =
[
    new Manager(),
    new Worker(),
    new Robot()
];

foreach (var worker in workers)
{
    worker.Work();
}

IEat[] eats =
[
    new Manager(),
    new Worker()
];

Console.ReadKey();
