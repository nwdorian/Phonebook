using System.ComponentModel.DataAnnotations;

namespace Phonebook.Models;
internal class Contact
{
    public int Id { get; set; }
    [Required]
    public string? Name { get; set; }
    [Required]
    public string? Email { get; set; }
    [Required]
    public string? PhoneNumber { get; set; }
}
