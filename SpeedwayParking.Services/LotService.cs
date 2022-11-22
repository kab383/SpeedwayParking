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

        public bool CreateLot(LotCreate model)
        {
            var createEntity =
                new Lot()
                {
                    Name = model.Name,
                    Entrance = model.Entrance,
                    Surface = model.Surface
                };
            _context.Lots.Add(createEntity);
            return _context.SaveChanges() == 1 ? true : false;
        }

        public IEnumerable<LotIndex> GetAllLots()
        {
            var lots = _context
                .Lots
                .Select(e => new LotIndex
                {
                    Id = e.Id,
                    Name = e.Name,
                    Entrance = e.Entrance,
                    Surface = e.Surface
                })
                .ToList();
            return lots;
        }
        
        public LotDetail GetLotById(int id)
        {
            var entity = _context
               .Lots
               .Single(e => e.Id == id);
            var lotEntity =
                new LotDetail
                {
                    Id = entity.Id,
                    Entrance = entity.Entrance,
                    Surface = entity.Surface,

                };
            return lotEntity;
        }

        public LotDetail GetLotByIdWithLotStandardConfig(int id)
        {
            var entity = _context.Lots.Include(r => r.LotStandardConfiguration).FirstOrDefault(e => e.Id == id);

            if (entity == null)
                return null;

            var lotDetail = new LotDetail
            {
                Id = entity.Id,
                Name = entity.Name,
                Entrance = entity.Entrance,
                Surface = entity.Surface,
                //NumberOfAutoSpaces = entity.LotStandardConfiguration.
            };

            return lotDetail;
        }

        public bool EditLot(LotEdit model)
        {
            var editEntity = _context
                    .Lots
                    .Single(e => e.Id == model.Id);

            editEntity.Name = model.Name;
            editEntity.Entrance = model.Entrance;
            editEntity.Surface = model.Surface;

            return _context.SaveChanges() == 1 ? true : false;
        }

        public bool DeleteLot(int id)
        {
            var deleteEntity = _context
                .Lots
                .Single(e => e.Id == id);

            _context.Lots.Remove(deleteEntity);

            return _context.SaveChanges() == 1 ? true : false;
        }
    }
}
