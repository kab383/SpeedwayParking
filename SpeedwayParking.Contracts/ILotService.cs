using SpeedwayParking.Data;
using SpeedwayParking.Models.Event;
using SpeedwayParking.Models.Lot;

namespace SpeedwayParking.Services
{
    public interface ILotService
    {
        IEnumerable<LotIndex> GetAllLots();
        bool CreateLot(LotCreate model);
        LotDetail GetLotById(int id);
        //LotDetail GetLotByIdWithLotStandardConfig(int id);
        bool EditLot(LotEdit model);
        bool DeleteLot(int id);

    }
}