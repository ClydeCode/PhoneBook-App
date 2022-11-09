
static class GetUserInput
{
    static internal int GetInt(string title)
    {
        int x = 0;

        while(x == 0)
        {
            Console.WriteLine($"\nInput [{title}]: ");
            string? Input = Console.ReadLine();

            Int32.TryParse(Input, out x);

            if (x == 0) Console.WriteLine("Wrong format!");
        }

        return x;
    }

    static internal string GetString(string title)
    {
        string? Input = "";

        while (Input == "")
        {
            Console.WriteLine($"Input [{title}]: ");
            Input = Console.ReadLine();
        }

        return Input;
    }
}

