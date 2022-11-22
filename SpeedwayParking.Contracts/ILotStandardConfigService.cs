using SpeedwayParking.Data;
using SpeedwayParking.Models.LotStandardConfig;

namespace SpeedwayParking.Services
{
    public interface ILotStandardConfigService
    {
        Task<List<LotStandardConfigIndex>> GetAllLotStandardConfigsAsync();
        Task<bool> CreateLotStandardConfigAsync(LotStandardConfigCreate model);
        Task<bool> DeleteLotStandardConfigAsync(int id);
        Task<bool> EditLotStandardConfigAsync(LotStandardConfigEdit model);
        Task<LotStandardConfig> GetLotStandardConfigByIdAsync(int? id);
    }
}