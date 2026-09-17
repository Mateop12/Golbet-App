// GolBet.Services/DTOs/TeamDto.cs
namespace GolBet.Services.DTOs;

/// <summary>
/// Read model for the teams list.
/// </summary>
public class TeamDto
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;
    public string City { get; set; } = null!;
    public string? CrestUrl { get; set; }
}
