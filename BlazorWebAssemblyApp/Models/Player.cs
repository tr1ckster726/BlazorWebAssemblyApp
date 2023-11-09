using System.ComponentModel.DataAnnotations;

namespace BlazorWebAssemblyApp.Models;

public class Player
{
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public required string Name { get; set; }

    [Required]
    [StringLength(40)]

    public required string Nationality { get; set; }

    [Range(1, 30)]
    public int Majors { get; set; }

    public DateTime Birthday { get; set; }

    public bool IsSelected { get; set; }

    public PlayerStatistics? Statistics { get; set; }
}
