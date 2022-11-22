using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using SpeedwayParking.Contracts;
using SpeedwayParking.Data;
using SpeedwayParking.Models.Event;
using SpeedwayParking.Models.Lot;
using SpeedwayParking.Models.LotStandardConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedwayParking.Services
{
    public class LotStandardConfigService : ILotStandardConfigService
    {
        private readonly ApplicationDbContext _context;
        public LotStandardConfigService(ApplicationDbContext context)
        {
            _context = context;
        }

        // Create a LotStandardConfig Index to use in the for each loop.
        public IEnumerable<LotStandardConfigIndex> GetAllLotStandardConfigs()
        {
            var lotStandardConfigEntity = _context
                .LotStandardConfigs
                .Select(e => new LotStandardConfigIndex
                {
                    Id = e.Id,
                    NumberOfAutoSpaces = e.NumberOfAutoSpaces,
                    NumberOfRvSpaces = e.NumberOfRvSpaces,
                    NumberOfMotorcycleSpaces = e.NumberOfMotorcycleSpaces,
                    NumberOfAdaSpaces = e.NumberOfAdaSpaces,
                })
                .ToList();
            return lotStandardConfigEntity;
        }

        public bool CreateLotStandardConfig(LotStandardConfigCreate model)
        {
            if (_context.Lots.Find(model.Id) == null)
            {
                return false;
            }
            var createEntity =
                new LotStandardConfig()
                {
                    Id = model.Id,
                    NumberOfAutoSpaces = model.NumberOfAutoSpaces,
                    NumberOfRvSpaces = model.NumberOfRvSpaces,
                    NumberOfMotorcycleSpaces = model.NumberOfMotorcycleSpaces,
                    NumberOfAdaSpaces = model.NumberOfAdaSpaces
                };
            _context.LotStandardConfigs.Add(createEntity);
            return _context.SaveChanges() == 1;
        }

        public LotStandardConfig GetLotStandardConfigById(int? id)
        {
            var entity = _context.LotStandardConfigs.Find(id);
            if (entity == null)
                return null;
            LotStandardConfig lotStandardConfigDetails = new LotStandardConfig()
            {
                NumberOfAutoSpaces = entity.NumberOfAutoSpaces,
                NumberOfRvSpaces = entity.NumberOfRvSpaces,
                NumberOfMotorcycleSpaces = entity.NumberOfMotorcycleSpaces,
                NumberOfAdaSpaces = entity.NumberOfAdaSpaces
            };
            return lotStandardConfigDetails;
        }

        public IEnumerable<LotStandardConfig> GetAllLotStandardConfigsById(int id)
        {
            var lotStandardConfigEntity = _context
                .LotStandardConfigs
                .Select(e => new LotStandardConfig
                {
                    Id = e.Id,
                    NumberOfAutoSpaces = e.NumberOfAutoSpaces,
                    NumberOfRvSpaces = e.NumberOfRvSpaces,
                    NumberOfMotorcycleSpaces = e.NumberOfMotorcycleSpaces,
                    NumberOfAdaSpaces = e.NumberOfAdaSpaces
                })
                .ToList();
            return lotStandardConfigEntity;

        }

        public bool EditLotStandardConfig(LotStandardConfigEdit model)
        {
            var editEntity = _context.LotStandardConfigs.Find(model.Id);
            if (editEntity?.Id != model.Id)
                return false;

            editEntity.NumberOfAutoSpaces = model.NumberOfAutoSpaces;
            editEntity.NumberOfRvSpaces = model.NumberOfRvSpaces;
            editEntity.NumberOfMotorcycleSpaces = model.NumberOfMotorcycleSpaces;
            editEntity.NumberOfAdaSpaces = model.NumberOfAdaSpaces;

            return _context.SaveChanges() == 1;
        }

        public bool DeleteLotStandardConfig(int id)
        {
            var deleteEntity = _context.LotStandardConfigs
                .Single(e => e.Id == id);

            _context.LotStandardConfigs.Remove(deleteEntity);

            return _context.SaveChanges() == 1;
        }
    }
}
