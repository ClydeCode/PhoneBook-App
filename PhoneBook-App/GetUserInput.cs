
static class GetUserInput
{
    static internal int GetInt()
    {
        int x = 0;

        while(x == 0)
        {
            Console.WriteLine("\nInput a number: ");
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
            Console.WriteLine($"Input a {title}: ");
            Input = Console.ReadLine();
        }

        return Input;
    }
}

