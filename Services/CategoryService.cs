using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManagementSystem.Data;
using ManagementSystem.Models;
using ManagementSystem.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ManagementSystem.Services
{
    public class CategoryService : ICategoryRepository
    {
        protected readonly AppDbContext _context; // Database context for accessing bookings

        public CategoryService(AppDbContext context)
        {
            _context = context; // Initialize context
        }

        // Method to get a booking by ID
        public async Task<Category?> GetById(int id)
        {
            return await _context.Categories.FindAsync(id);
        }

        // Method to get all guests
        public async Task<IEnumerable<Category>> GetAll()
        {
            return await _context.Categories.ToListAsync();
        }

        // Method to register a new guest
        public async Task Create(Category category)
        {
            if (category == null)
            {
                throw new ArgumentNullException(nameof(category), "El categoria no puede ser nulo.");
            }

            try
            {
                await _context.Categories.AddAsync(category);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException dbEx)
            {
                throw new Exception("Error al agregar el categoria a la base de datos.", dbEx);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado al agregar el categoria.", ex);
            }
        }

        public async Task Update(Category category)
        {
            if (category == null)
            {
                throw new ArgumentNullException(nameof(category), "El categoria no puede ser nulo.");
            }

            try
            {
                _context.Entry(category).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException dbEx)
            {
                throw new Exception("Error al actualizar el categoria en la base de datos.", dbEx);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado al actualizar el categoria.", ex);
            }
        }

        public async Task Delete(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category != null)
            {
                _context.Categories.Remove(category);
                await _context.SaveChangesAsync();
            }
        }
        
    }
}