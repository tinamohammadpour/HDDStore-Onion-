using App.DataAccess.Dtos.faqs;
using App.InfraStructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Services.faqs
{
    public class FaqCategoryService : IFaqCategoryService
    {
        DataContext _context;
        public FaqCategoryService(DataContext context)
        {
            _context = context;
        }
        public async Task Add(AddOrUpdateFaqCategoryDto model)
        {
            await _context.FaqCategories.AddAsync(new Domain.Entities.Faqs.FaqCategory
            {
                Name = model.Name,
                Image = model.Image,
            });
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var Data = await _context.FaqCategories.FirstOrDefaultAsync(a => a.Id == id);
            if (Data is not null)
                _context.FaqCategories.Remove(Data);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<FaqCategoryDto>> GetAll()
        {
            var Data = await _context.FaqCategories.Select(s => new FaqCategoryDto
            {
                Id = s.Id,
                Name = s.Name,
                Image = s.Image,
            }).ToListAsync();
            return Data;

        }

        public async Task<FaqCategoryDto> GetById(int id)
        {
            var Data = await _context.FaqCategories.FirstOrDefaultAsync(a => a.Id == id);
            if (Data is null)
                Debug.WriteLine("--Not Found--");
            return new FaqCategoryDto
            {
                Id = Data.Id,
                Name = Data.Name,
                Image = Data.Image,
            };
        }

        public async Task Update(int id, AddOrUpdateFaqCategoryDto model)
        {
            var Data = await _context.FaqCategories.FirstOrDefaultAsync(a => a.Id == id);
            if(Data is not null)
            {
                Data.UpdateAt = DateTime.Now;
                Data.Name = model.Name;
                Data.Image = model.Image;
              
            }
            await _context.SaveChangesAsync();
        }
    }
}
