using App.DataAccess.Dtos.rules;
using App.InfraStructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Services.rules
{
    public class RulesService : IRulesService
    {
        DataContext _context;
        public RulesService(DataContext context)
        {
            _context = context;
        }
        public async Task Add(AddOrUpdateRulesDto model)
        {
            await _context.rules.AddAsync(new Domain.Entities.BaseData.Rules
            {
                Description = model.Description,
                Title = model.Title,
            });
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var Data = await _context.rules.FirstOrDefaultAsync(a => a.Id == id);
            if (Data is not null)
                _context.rules.Remove(Data);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<RulesDto>> GetAll()
        {
            var Data =await _context.rules.Select(s => new RulesDto
            {
                Id = s.Id,
                Description = s.Description,
                Title = s.Title,

            }).ToListAsync();
            return Data;
        }

        public async Task<RulesDto> GetById(int id)
        {
            var Data = await _context.rules.FirstOrDefaultAsync(a => a.Id == id);
            if (Data is null)
                Debug.WriteLine("--Not Found--");
            return new RulesDto
            {
                Id = Data.Id,
                Description = Data.Description,
                Title = Data.Title,
            };
        }

        public async Task Update(int id, AddOrUpdateRulesDto model)
        {
            var Data = await _context.rules.FirstOrDefaultAsync(a => a.Id == id);
            if(Data is not null)
            {
                Data.UpdateAt = DateTime.Now;
                Data.Description = model.Description;
                Data.Title = model.Title;
            }
            await _context.SaveChangesAsync();
        }
    }
}
