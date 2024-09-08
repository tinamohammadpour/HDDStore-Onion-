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
    public class LearningService : ILearningService
    {
        DataContext _context;
        public LearningService(DataContext context)
        {
            _context = context;
        }
        public async Task Add(AddOrUpdateLearningDto model)
        {
            await _context.Learnings.AddAsync(new Domain.Entities.Learnings.Learning
            {
                Video = model.Video,
                Image = model.Image,
                LearningCategoryId = model.LearningCategoryId,
                Text = model.Text,
                Title = model.Title,
            });
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var Data = await _context.Learnings.FirstOrDefaultAsync(a => a.Id == id);
            if (Data is not null)
                _context.Learnings.Remove(Data);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<LearningDto>> GetAll()
        {
            var Data = await _context.Learnings.Include(s => s.LearningCategory).Select(s => new LearningDto
            {
                Video = s.Video,
                Image = s.Image,
                Id = s.Id,
                Text = s.Text,
                Title = s.Title,
                LearningCategoryDto = new LearningCategoryDto
                {
                    Discription = s.LearningCategory.Discription,
                    Id = s.LearningCategory.Id,
                    Image = s.LearningCategory.Image,
                    Name = s.LearningCategory.Name,
                }
            }).ToListAsync();
            return Data;
        }

        public async Task<LearningDto> GetById(int id)
        {
            var Data = await _context.Learnings.Include(s => s.LearningCategory).FirstOrDefaultAsync(s => s.Id == id);
            if (Data is null)
                Debug.WriteLine("--Not Found--");
            return new LearningDto
            {
                Id = Data.Id,
                Image = Data.Image,
                Text = Data.Text,
                Title = Data.Title,
                Video = Data.Video,
                LearningCategoryDto = new LearningCategoryDto
                {
                    Image = Data.LearningCategory.Image,
                    Discription = Data.LearningCategory.Discription,
                    Id = Data.LearningCategory.Id,
                    Name = Data.LearningCategory.Name,
                }
            };
        }

        public async Task Update(int id, AddOrUpdateLearningDto model)
        {
            var Data = await _context.Learnings.FirstOrDefaultAsync(a => a.Id == id);
            if(Data is not null)
            {
                Data.UpdateAt = DateTime.Now;
                Data.Title = model.Title;
                Data.Video = model.Video;
                Data.Text = model.Text;
                Data.LearningCategoryId = model.LearningCategoryId;
            }
            await _context.SaveChangesAsync();
        }
    }
}
