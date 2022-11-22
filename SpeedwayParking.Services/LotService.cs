using Microsoft.EntityFrameworkCore;
using SpeedwayParking.Contracts;
using SpeedwayParking.Data;
using SpeedwayParking.Models.Event;
using SpeedwayParking.Models.Lot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedwayParking.Services
{
    public class LotService : ILotService
    {
        private readonly ApplicationDbContext _context;
        public LotService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateLotAsync(LotCreate model)
        {
            var createEntity =
                new Lot()
                {
                    Name = model.Name,
                    Entrance = model.Entrance,
                    Surface = model.Surface
                };
            _context.Lots.Add(createEntity);
            return await _context.SaveChangesAsync() == 1 ? true : false;
        }

        public async Task<List<LotIndex>> GetAllLots()
        {
            var lots = await _context
                .Lots
                .Select(e => new LotIndex
                {
                    Id = e.Id,
                    Name = e.Name,
                    Entrance = e.Entrance,
                    Surface = e.Surface
                })
                .ToListAsync();
            return lots;
        }

        public async Task<bool> EditLotByIdAsync(LotEdit model)
        {
            var editEntity = _context
                    .Lots
                    .Single(e => e.Id == model.Id);

            editEntity.Name = model.Name;
            editEntity.Entrance = model.Entrance;
            editEntity.Surface = model.Surface;

            return await _context.SaveChangesAsync() == 1 ? true : false;
        }

        public async Task<bool> DeleteLotById(int Id)
        {
            var deleteEntity = await _context.Lots.FindAsync(Id);
            _context.Lots.Remove(deleteEntity);
            return await _context.SaveChangesAsync() == 1 ? true : false;
        }
    }
}
