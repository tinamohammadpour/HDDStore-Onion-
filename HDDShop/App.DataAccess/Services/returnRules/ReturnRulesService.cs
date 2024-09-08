using App.DataAccess.Dtos.returnRules;
using App.InfraStructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Services.returnRules
{
    public class ReturnRulesService : IReturnRulesService
    {
        DataContext _context;
        public ReturnRulesService(DataContext context)
        {
            _context = context;
        }
        public async Task Add(AddOrUpdatereturnRulesDto model)
        {
            await _context.returnRules.AddAsync(new Domain.Entities.BaseData.ReturnRules
            {
                Description = model.Description,
                Title = model.Title,
            });
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var Data = await _context.returnRules.FirstOrDefaultAsync(a => a.Id == id);
            if (Data is not null)
                _context.returnRules.Remove(Data);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<returnRulesDto>> GetAll()
        {
            var Data = await _context.returnRules.Select(s => new returnRulesDto
            {
                Description = s.Description,
                Id = s.Id,
                Title = s.Title,
            }).ToListAsync();
            return Data;
        }

        public async Task<returnRulesDto> GetById(int id)
        {
            var Data = await _context.returnRules.FirstOrDefaultAsync(a => a.Id == id);
            if (Data is null)
                Debug.WriteLine("--Not Found--");
            return new returnRulesDto
            {
                Id = Data.Id,
                Title = Data.Title,
                Description = Data.Description,
            };
        }

        public async Task Update(int id, AddOrUpdatereturnRulesDto model)
        {
            var Data = await _context.returnRules.FirstOrDefaultAsync(a => a.Id == id);
            if(Data is not null)
            {
                Data.UpdateAt = DateTime.Now;
                Data.Title = model.Title;
                Data.Description = model.Description;
            }
            await _context.SaveChangesAsync();
        }
    }
}
