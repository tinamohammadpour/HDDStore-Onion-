using App.DataAccess.Dtos.faqs;
using App.Domain.Entities.Faqs;
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
    public class FaqService : IFaqService
    {
        DataContext _context;
        public FaqService(DataContext context)
        {
            _context = context;
        }
        public async Task Add(AddOrUpdateFaqDto model)
        {
            await _context.Faqs.AddAsync(new Faq
            {
                Answer = model.Answer,
                ShortKey = model.ShortKey,
                FaqCategoryId = model.FaqCategoryId,
                Question = model.Question,

            });
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var Data = await _context.Faqs.FirstOrDefaultAsync(a => a.Id == id);
            if (Data is not null)
                _context.Faqs.Remove(Data);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<FaqDto>> GetAll()
        {
            var Data = await _context.Faqs.Include(s => s.FaqCategory).Select(s => new FaqDto
            {
                ShortKey = s.ShortKey,
                Answer = s.Answer,
                Question = s.Question,
                Id = s.Id,
                FaqCategoryDto = new FaqCategoryDto
                {
                    Image = s.FaqCategory.Image,
                    Name = s.FaqCategory.Name,
                    Id = s.FaqCategory.Id,
                }

            }).ToListAsync();
            return Data;
        }

        public async Task<FaqDto> GetById(int id)
        {
            var Data = await _context.Faqs.Include(s => s.FaqCategory).FirstOrDefaultAsync(a => a.Id == id);
            if (Data is null)
                Debug.WriteLine("--Not Found--");
            return new FaqDto
            {
                ShortKey = Data.ShortKey,
                Answer = Data.Answer,
                Question = Data.Question,
                Id = Data.Id,
                FaqCategoryDto = new FaqCategoryDto
                {
                    Id = Data.FaqCategory.Id,
                    Image = Data.FaqCategory.Image,
                    Name = Data.FaqCategory.Name,
                }
            };
        }

        public async Task Update(int id, AddOrUpdateFaqDto model)
        {
            var Data = await _context.Faqs.Include(s => s.FaqCategory).FirstOrDefaultAsync(a => a.Id == id);
            if(Data is not null)
            {
                Data.UpdateAt = DateTime.Now;
                Data.Question = model.Question;
                Data.Answer = model.Answer;
                Data.ShortKey = model.ShortKey;
                Data.FaqCategoryId = model.FaqCategoryId;
                
            }
        }
    }
}
