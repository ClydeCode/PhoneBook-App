PhoneBookController Program = new();

while (true)
{
    Program.ShowMenu();

    Program.Navigate(GetUserInput.GetInt("Option"));

    Console.WriteLine("\nPress ENTER to Continue...");
    Console.ReadLine();
}