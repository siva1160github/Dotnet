using DotnetPracticePbm;

static void Functionality()
{
    Console.WriteLine("1.ReverseString");
    int input = int.Parse(Console.ReadLine());
    Problems problem = new();
    switch (input)
    {
        case 1:
            problem.ReverseString();
            break;
    }
    Functionality();
}

Functionality();

