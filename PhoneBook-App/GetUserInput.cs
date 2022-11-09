
internal class GetUserInput
{
    internal int GetInt()
    {
        int x = 0;

        while(x == 0)
        {
            Console.WriteLine("\nInput a number: ");
            string? input = Console.ReadLine();

            Int32.TryParse(input, out x);

            if (x == 0) Console.WriteLine("Wrong format!");
        }

        return x;
    }
}

