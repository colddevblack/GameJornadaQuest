using JogoTurno.Models.Persist;
using Microsoft.EntityFrameworkCore;

namespace JogoTurno;

public class GameContext : DbContext
{
    public GameContext(DbContextOptions<GameContext> options)
    : base(options)
    {
    }

    public DbSet<CharacterModel> Characters => Set<CharacterModel>();
}
