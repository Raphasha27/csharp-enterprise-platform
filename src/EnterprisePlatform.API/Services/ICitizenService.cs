namespace EnterprisePlatform.API.Services;

public interface ICitizenService
{
    Task<IEnumerable<Citizen>> GetAllCitizensAsync();
    Task<Citizen?> GetCitizenByIdAsync(Guid id);
    Task<Citizen> CreateCitizenAsync(Citizen citizen);
    Task<bool> UpdateCitizenAsync(Guid id, Citizen citizen);
    Task<bool> DeleteCitizenAsync(Guid id);
}
