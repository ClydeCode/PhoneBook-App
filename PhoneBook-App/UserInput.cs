using System.Text.RegularExpressions;

static class UserInput
{
    static internal int GetInt(string title)
    {
        int value = 0;

        while(value == 0)
        {
            Console.WriteLine($"\nInput [{title}]: ");
            string? input = Console.ReadLine();

            Int32.TryParse(input, out value);

            if (value == 0) Console.WriteLine("Wrong format!");
        }

        return value;
    }

    static internal string GetPhoneNumber()
    {
        string pattern = "^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$";

        string? input = "";

        while (input == "" || !Regex.IsMatch(input, pattern))
        {
            Console.WriteLine($"Input [Phone Number]: ");
            input = Console.ReadLine();

            if (!Regex.IsMatch(input, pattern)) Console.WriteLine("Wrong format!");
        }

        return input;
    }

    static internal string GetString(string title)
    {
        string? input = "";

        while (input == "")
        {
            Console.WriteLine($"Input [{title}]: ");
            input = Console.ReadLine();
        }

        return input;
    }

    static internal string GetUpdateOptionString()
    {
        string[] options = { "1", "2" };

        string? input = "";

        while (!Array.Exists(options, element => element == input))
        {
            Console.WriteLine($"Input [Option]: ");
            input = Console.ReadLine();
        }

        return input;
    }
}

