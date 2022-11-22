using SpeedwayParking.Models.Lot;

namespace SpeedwayParking.Services
{
    public interface ILotService
    {
        Task<bool> CreateLotAsync(LotCreate model);
        Task<bool> DeleteLotById(int Id);
        Task<bool> EditLotByIdAsync(LotEdit model);
        Task<List<LotIndex>> GetAllLots();
    }
}