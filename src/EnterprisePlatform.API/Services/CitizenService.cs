using Microsoft.EntityFrameworkCore;
using EnterprisePlatform.API.Data;
using EnterprisePlatform.API.Models;

namespace EnterprisePlatform.API.Services;

public class CitizenService : ICitizenService
{
    private readonly AppDbContext _context;

    public CitizenService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Citizen>> GetAllCitizensAsync()
    {
        return await _context.Citizens.ToListAsync();
    }

    public async Task<Citizen?> GetCitizenByIdAsync(Guid id)
    {
        return await _context.Citizens.FindAsync(id);
    }

    public async Task<Citizen> CreateCitizenAsync(Citizen citizen)
    {
        _context.Citizens.Add(citizen);
        await _context.SaveChangesAsync();
        return citizen;
    }

    public async Task<bool> UpdateCitizenAsync(Guid id, Citizen citizen)
    {
        var existing = await _context.Citizens.FindAsync(id);
        if (existing == null) return false;

        existing.Name = citizen.Name;
        existing.Email = citizen.Email;
        existing.Phone = citizen.Phone;

        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteCitizenAsync(Guid id)
    {
        var citizen = await _context.Citizens.FindAsync(id);
        if (citizen == null) return false;

        _context.Citizens.Remove(citizen);
        await _context.SaveChangesAsync();
        return true;
    }
}
