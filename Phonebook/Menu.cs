using Spectre.Console;
using static Phonebook.Enums;

namespace Phonebook;
internal class Menu
{
    internal async Task MainMenu()
    {
        var exit = false;

        while (!exit)
        {
            AnsiConsole.Clear();

            AnsiConsole.Write(
                new FigletText("Phonebook")
                    .LeftJustified()
                    .Color(Color.Yellow));

            var selection = AnsiConsole.Prompt(
                new SelectionPrompt<MenuOptions>()
                .Title("Select from the menu:")
                .AddChoices(Enum.GetValues<MenuOptions>()));

            switch (selection)
            {
                case MenuOptions.AddContact:
                    break;
                case MenuOptions.DeleteContact:
                    break;
                case MenuOptions.UpdateContact:
                    break;
                case MenuOptions.ViewContact:
                    break;
                case MenuOptions.ViewAllContacts:
                    break;
                case MenuOptions.Exit:
                    break;
            }
        }
    }
}
