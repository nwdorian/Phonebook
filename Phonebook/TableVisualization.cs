using Phonebook.Models;
using Spectre.Console;

namespace Phonebook;
internal static class TableVisualization
{
    internal static void ShowContacts(List<Contact> contacts)
    {
        var table = new Table();
        table.AddColumns("Name", "Email", "Phone Number");

        foreach (var contact in contacts)
        {
            table.AddRow(contact.Name, contact.Email, contact.PhoneNumber);
        }

        AnsiConsole.Write(table);
        AnsiConsole.Write("Press any key to continue...");
        Console.ReadKey();
    }
}
