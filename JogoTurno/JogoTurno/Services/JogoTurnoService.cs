using JogoTurno.Models.Persist;
using Microsoft.EntityFrameworkCore;

namespace JogoTurno.Services;

public interface IJogoTurnoService
{
    public Task<List<CharacterModel>> GetAllCharactersAsync();
    public Task AddCharacterAsync(CharacterModel character);
    public Task<CharacterModel> GetCharacterAsync(int id);
    public Task UpdateCharacterAsync(CharacterModel model);
    public  Task DeleteCharacterAsync(CharacterModel model);
}

public sealed class JogoTurnoService : IJogoTurnoService
{
    private readonly GameContext _context;

    public JogoTurnoService(GameContext context)
    {
        _context = context;
    }

    public async Task<List<CharacterModel>> GetAllCharactersAsync()
    {
        var allCharacters = await _context.Characters
            .AsNoTracking()
            .OrderBy(c => c.Id)
            .ToListAsync();

        return allCharacters;
    }

    public async Task AddCharacterAsync(CharacterModel character)
    {
        _context.Characters.Add(character);
        await _context.SaveChangesAsync();
    }

    public async Task<CharacterModel> GetCharacterAsync(int id)
        => await _context.Characters.AsNoTracking().SingleAsync(c => c.Id == id);

    public async Task UpdateCharacterAsync(CharacterModel model)
    {
        _context.Characters.Update(model);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteCharacterAsync(CharacterModel model)
    {
        _context.Characters.Remove(model);
        await _context.SaveChangesAsync();
    }
}