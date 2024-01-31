// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var list = new Queue<string>();

static IEnumerable<string> Fn(Queue<string> args)
{
    if (args.Count == 5) return args;

    args.Enqueue("a");
    return Fn(args);
}

Fn(list);

Console.WriteLine(list.Count);
