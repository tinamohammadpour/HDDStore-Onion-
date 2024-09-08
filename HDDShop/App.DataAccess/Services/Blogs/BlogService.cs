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
    public class BlogService : IBlogService
    {
        DataContext _context;
        public BlogService(DataContext context)
        {
            _context = context;
        }
        public async Task Add(AddorUpdateBlogDto model)
        {
            await _context.Blogs.AddAsync(new Domain.Entities.Blogs.Blog
            {
                Name=model.Name,
                BlogCategoryId=model.BlogCategoryId,
                Description=model.Description,
                ShortText=model.ShortText,
            });
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var Data = await _context.Blogs.FirstOrDefaultAsync(a => a.Id == id);
            if (Data is not null)
                _context.Blogs.Remove(Data);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<BlogDto>> GetAll()
        {
            var Data = await _context.Blogs.Include(s => s.BlogCategory).Select(s => new BlogDto
            {
                Name = s.Name,
                Description = s.Description,
                ShortText = s.ShortText,
                Id = s.Id,
                BlogCategoryDto = new BlogCategoryDto
                {
                    Id = s.BlogCategory.Id,
                    Name = s.BlogCategory.Name,
                    Description = s.BlogCategory.Description,
                }

            }).ToListAsync();
            return Data;
        }

        public async Task<BlogDto> GetById(int id)
        {
            var Data = await _context.Blogs.Include(s => s.BlogCategory).FirstOrDefaultAsync(s => s.Id == id);
            if (Data is null)
                Debug.WriteLine("--Not Found--");
            return new BlogDto
            {
                Id = Data.Id,
                Name = Data.Name,
                Description = Data.Description,
                ShortText = Data.ShortText,
                BlogCategoryDto = new BlogCategoryDto
                {
                    Id = Data.BlogCategory.Id,
                    Name = Data.BlogCategory.Name,
                    Description = Data.BlogCategory.Description,

                }
            };
        }

        public async Task Update(int id, AddorUpdateBlogDto model)
        {
            var Data = await _context.Blogs.Include(s => s.BlogCategory).FirstOrDefaultAsync(s => s.Id == id);
            if(Data is not null)
            {
                Data.UpdateAt = DateTime.Now;
                Data.ShortText = model.ShortText;
                Data.Description = model.Description;
                Data.BlogCategoryId = model.BlogCategoryId;
            }
            await _context.SaveChangesAsync();
        }
    }
}
