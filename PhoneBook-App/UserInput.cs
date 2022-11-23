﻿using System.Text.RegularExpressions;

static class UserInput
{
    static internal int GetInt(string Title)
    {
        int value = 0;

        while(value == 0)
        {
            Console.WriteLine($"\nInput [{Title}]: ");
            string? Input = Console.ReadLine();

            Int32.TryParse(Input, out value);

            if (value == 0) Console.WriteLine("Wrong format!");
        }

        return value;
    }

    static internal string GetPhoneNumber()
    {
        string pattern = "^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$";

        string? Input = "";

        while (Input == "" || !Regex.IsMatch(Input, pattern))
        {
            Console.WriteLine($"Input [Phone Number]: ");
            Input = Console.ReadLine();

            if (!Regex.IsMatch(Input, pattern)) Console.WriteLine("Wrong format!");
        }

        return Input;
    }

    static internal string GetString(string Title)
    {
        string? Input = "";

        while (Input == "")
        {
            Console.WriteLine($"Input [{Title}]: ");
            Input = Console.ReadLine();
        }

        return Input;
    }

    static internal string GetUpdateOptionString()
    {
        string[] options = { "1", "2" };

        string? Input = "";

        while (!Array.Exists(options, element => element == Input))
        {
            Console.WriteLine($"Input [Option]: ");
            Input = Console.ReadLine();
        }

        return Input;
    }
}

