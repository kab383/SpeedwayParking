using SpeedwayParking.Data;
using SpeedwayParking.Models.LotStandardConfig;

namespace SpeedwayParking.Services
{
    public interface ILotStandardConfigService
    {
        IEnumerable<LotStandardConfigIndex> GetAllLotStandardConfigs();
        bool CreateLotStandardConfig(LotStandardConfigCreate model);
        LotStandardConfig GetLotStandardConfigById(int? id);
        IEnumerable<LotStandardConfig> GetAllLotStandardConfigsById(int id)
        bool EditLotStandardConfig(LotStandardConfigEdit model);
        bool DeleteLotStandardConfig(int id);
        
    }
}