using App.DataAccess.Dtos.Learnings;
using App.InfraStructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Services.Learnings
{
    public class LearningCategoryService : ILearningCategoryService
    {
        DataContext _context;
        public LearningCategoryService(DataContext context)
        {
            _context = context;
        }
        public async Task Add(AddOrUpdateLearningCategoryDto model)
        {
            await _context.LearningCategories.AddAsync(new Domain.Entities.Learnings.LearningCategory
            {
                Image = model.Image,
                Discription = model.Discription,
                Name = model.Name,
            });
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var Data = await _context.LearningCategories.FirstOrDefaultAsync(a => a.Id == id);
            if (Data is not null)
                _context.LearningCategories.Remove(Data);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<LearningCategoryDto>> GetAll()
        {
            var Data = await _context.LearningCategories.Select(s => new LearningCategoryDto
            {
                Id = s.Id,
                Discription = s.Discription,
                Image = s.Image,
                Name = s.Name,
            }).ToListAsync();
            return Data;
        }

        public async Task<LearningCategoryDto> GetById(int id)
        {
            var Data = await _context.LearningCategories.FirstOrDefaultAsync(a => a.Id == id);
            if (Data is null)
                Debug.WriteLine("--Not Found--");
            return new LearningCategoryDto
            {
                Id = Data.Id,
                Discription = Data.Discription,
                Image = Data.Image,
                Name = Data.Name,
            };
        }

        public async Task Update(int id, AddOrUpdateLearningCategoryDto model)
        {
            var Data = await _context.LearningCategories.FirstOrDefaultAsync(a => a.Id == id);
            if(Data is not null)
            {
                Data.UpdateAt = DateTime.Now;
                Data.Name = model.Name;
                Data.Discription = model.Discription;
                Data.Image = model.Image;

            }
            await _context.SaveChangesAsync();
        }
    }
}
