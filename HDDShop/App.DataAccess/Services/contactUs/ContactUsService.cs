using App.DataAccess.Dtos.contactUs;
using App.InfraStructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Services.contactUs
{
    public class ContactUsService : IContactService
    {
        DataContext _context;
        public ContactUsService(DataContext context)
        {
            _context = context;
        }
        public async Task Add(AddOrUpdateContactUsDto model)
        {
            await _context.contactUs.AddAsync(new Domain.Entities.BaseData.ContactUs
            {
                FullName=model.FullName,
                Phonenumber=model.Phonenumber,
                Title=model.Title,
                Description=model.Description,
            });
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var Data = await _context.contactUs.FirstOrDefaultAsync(a => a.Id == id);
            if (Data is not null)
                _context.contactUs.Remove(Data);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<ContactUsDto>> GetAll()
        {
            var Data = await _context.contactUs.Select(s => new ContactUsDto
            {
                Id = s.Id,
                FullName = s.FullName,
                Title = s.Title,
                Description = s.Description,
            }).ToListAsync();
            return Data;
        }

        public async Task<ContactUsDto> GetById(int id)
        {
            var Data = await _context.contactUs.FirstOrDefaultAsync(a => a.Id == id);
            if (Data is null)
                Debug.WriteLine("--Not Foud--");

            return new ContactUsDto
            {
                Description = Data.Description,
                Id = Data.Id,
                FullName = Data.FullName,
                Title = Data.Title,
            };
            
        }

        public async Task Update(int id, AddOrUpdateContactUsDto model)
        {
            var Data = await _context.contactUs.FirstOrDefaultAsync(a => a.Id == id);
            if (Data is not null)
            {
                Data.UpdateAt = DateTime.Now;
                Data.Description = model.Description;
                Data.FullName = model.FullName;
                Data.Title = model.Title;
            }
        }
    }
}
