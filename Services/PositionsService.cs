using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreAngularCrudDemo.Data;
using AspNetCoreAngularCrudDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreAngularCrudDemo.Services
{
    public class PositionsService : IPositionsService
    {
        private readonly FootballDbContext _context;

        public PositionsService(FootballDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Position>> GetPositionsList()
        {
            var list= await _context.Positions
                .OrderBy(x => x.DisplayOrder)
                .ToListAsync();
            return list;
        }
    }
}
