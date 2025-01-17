using System.ComponentModel.DataAnnotations;
using JogoTurno.Enums;

namespace JogoTurno.Models.Persist;

public sealed class CharacterModel
{
    [Key]
    public int Id { get; init; }
    [Required]
    public string Name { get; init; } = string.Empty;
    public Race Race { get; init; }
    public CharacterClass Class { get; init; }
}