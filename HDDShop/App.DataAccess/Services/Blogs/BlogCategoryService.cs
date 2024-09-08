using App.DataAccess.Dtos.Blogs;
using App.InfraStructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Services.Blogs
{
    public class BlogCategoryService : IBlogCategoryService
    {
        DataContext _context;
        public BlogCategoryService(DataContext context)
        {
            _context = context;
        }
        public async Task Add(AddOrUpdateBlogCategoryDto model)
        {
            await _context.BlogCategories.AddAsync(new Domain.Entities.Blogs.BlogCategory
            {
                Name = model.Name,
                Description = model.Description,
            });
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var Data = await _context.BlogCategories.FirstOrDefaultAsync(a=>a.Id==id);
            if (Data is not null)
                _context.BlogCategories.Remove(Data);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<BlogCategoryDto>> GetAll()
        {
            var Data = await _context.BlogCategories.Select(s => new BlogCategoryDto
            {
                Name = s.Name,
                Id = s.Id,
                Description = s.Description,
            }).ToListAsync();
            return Data;
        }

        public async Task<BlogCategoryDto> GetById(int id)
        {
            var Data = await _context.BlogCategories.FirstOrDefaultAsync(a => a.Id == id);
            if (Data is null)
                Debug.WriteLine("--Not Found--");
            return new BlogCategoryDto
            {
                Id = Data.Id,
                Name = Data.Name,
                Description = Data.Description,
            };
        }

        public async Task Update(int id, AddOrUpdateBlogCategoryDto model)
        {
            var Data = await _context.BlogCategories.FirstOrDefaultAsync(a => a.Id == id);
            if(Data is not null)
            {
                Data.UpdateAt = DateTime.Now;
                Data.Name = model.Name;
                Data.Description = model.Description;
                
            }
            await _context.SaveChangesAsync();
        }
    }
}
