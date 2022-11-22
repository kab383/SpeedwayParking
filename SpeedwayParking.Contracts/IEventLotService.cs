using Microsoft.AspNetCore.Mvc;
using SpeedwayParking.Models.EventLot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedwayParking.Contracts
{
    public interface IEventLotService
    {
        Task<bool> CreateEventLotAsync(EventLotCreate model);
        Task <List<EventLotIndex>> GetAllEventLotsAsync();
    }
}
