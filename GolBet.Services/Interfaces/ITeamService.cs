// GolBet.Services/Interfaces/ITeamService.cs
using GolBet.Services.DTOs;

namespace GolBet.Services.Interfaces;

public interface ITeamService
{
    /// <summary>Teams list: all active teams.</summary>
    Task<IEnumerable<TeamDto>> GetAllAsync();
}
