using Spectre.Console;

while (true)
{
    Console.Clear();

    var choice = AnsiConsole.Prompt(
        new SelectionPrompt<MenuOption>()
        .Title("What do you want to do next?")
        .AddChoices(Enum.GetValues<MenuOption>()));

    switch (choice)
    {
        case MenuOption.Viewbooks:
            AnsiConsole.MarkupLine("You chose to view books. Press Any Key to Continue.");
            Console.ReadKey();
            break;
        case MenuOption.AddBook:
            AnsiConsole.MarkupLine("You chose to add a book. Press Any Key to Continue.");
            Console.ReadKey();
            break;
        case MenuOption.DeleteBook:
            AnsiConsole.MarkupLine("You chose to delete a book. Press Any Key to Continue.");
            Console.ReadKey();
            break;
    }
}

enum MenuOption
{
    Viewbooks,
    AddBook,
    DeleteBook
}