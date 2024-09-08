using App.DataAccess.Dtos.payRules;
using App.InfraStructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Services.payRules
{
    public class payRulesService : IpayRulesService
    {
        DataContext _context;
        public payRulesService(DataContext context)
        {
            _context = context;
        }
        public async Task Add(AddOrUpdatePayRulesDto model)
        {
            await _context.payRules.AddAsync(new Domain.Entities.BaseData.PayRules
            {
                Title = model.Title,
                Description = model.Description,
            });
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var Data = await _context.payRules.FirstOrDefaultAsync(a => a.Id == id);
            if (Data is not null)
                _context.payRules.Remove(Data);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<payRulesDto>> GetAll()
        {
            var Data = await _context.payRules.Select(s => new payRulesDto
            {
                Id = s.Id,
                Title = s.Title,
                Description = s.Description,

            }).ToListAsync();
            return Data;
        }

        public async Task<payRulesDto> GeyById(int id)
        {
            var Data = await _context.payRules.FirstOrDefaultAsync(a => a.Id == id);
            if (Data is null)
                Debug.WriteLine("--Not Found--");
            return new payRulesDto
            {
                Id = Data.Id,
                Title = Data.Title,
                Description = Data.Description,
            };
        }

        public async Task Update(int id, AddOrUpdatePayRulesDto model)
        {
            var Data = await _context.payRules.FirstOrDefaultAsync(a => a.Id == id);
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
