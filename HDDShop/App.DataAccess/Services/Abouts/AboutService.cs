using App.DataAccess.Dtos.Abouts;
using App.InfraStructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Services.Abouts
{
    public class AboutService : IAboutService
    {
        DataContext _context;
        public AboutService(DataContext context)
        {
            _context = context;
        }
        public async Task Add(AddOrUpdateAboutDto model)
        {
            await _context.Abouts.AddAsync(new Domain.Entities.BaseData.About
            {
                Description = model.Description,
                Title = model.Title,
                Image = model.Image,
            });
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var Data = await _context.Abouts.FirstOrDefaultAsync(a => a.Id == id);
            if(Data is not null)
            {
                _context.Abouts.Remove(Data);
            }
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<AboutDto>> GetAll()
        {
            var Data = await _context.Abouts.Select(s => new AboutDto()
            {
                Id = s.Id,
                Title = s.Title,
                Image = s.Image,
                Description = s.Description,
            }).ToListAsync();
            return Data;
        }

        public async Task<AboutDto> GetById(int id)
        {
            var Data = await _context.Abouts.FirstOrDefaultAsync(a => a.Id == id);
            if (Data is null)
                Debug.WriteLine("--Not Found__");

            return new AboutDto()
            {
                Description = Data.Description,
                Title = Data.Title,
                Image = Data.Image,
                Id = Data.Id,
            };
            
        }

        public async Task Update(int id, AddOrUpdateAboutDto model)
        {
            var Data = await _context.Abouts.FirstOrDefaultAsync(a => a.Id == id);
            if(Data is not null)
            {
                Data.UpdateAt = DateTime.Now;
                Data.Title = model.Title;
                Data.Description = model.Description;
                Data.Image = model.Image;
            }
            await _context.SaveChangesAsync();
        }
    }
}
