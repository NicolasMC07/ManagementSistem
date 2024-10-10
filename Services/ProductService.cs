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
    public class ProductService : IProductRepository
    {
        protected readonly AppDbContext _context; // Database context for accessing bookings

        public ProductService(AppDbContext context)
        {
            _context = context; // Initialize context
        }

        // Method to get a booking by ID
        public async Task<Product?> GetById(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        // Method to get all guests
        public async Task<IEnumerable<Product>> GetAll()
        {
            return await _context.Products.ToListAsync();
        }

        // Method to register a new guest
        public async Task Create(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product), "El producto no puede ser nulo.");
            }

            try
            {
                await _context.Products.AddAsync(product);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException dbEx)
            {
                throw new Exception("Error al agregar el producto a la base de datos.", dbEx);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado al agregar el producto.", ex);
            }
        }

        public async Task Update(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product), "El producto no puede ser nulo.");
            }

            try
            {
                _context.Entry(product).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException dbEx)
            {
                throw new Exception("Error al actualizar el producto en la base de datos.", dbEx);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado al actualizar el producto.", ex);
            }
        }

        public async Task Delete(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
            }
        }
    }
}