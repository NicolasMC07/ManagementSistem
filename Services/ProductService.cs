// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using ManagementSystem.Data;
// using ManagementSystem.Models;
// using ManagementSystem.Repositories;

// namespace ManagementSystem.Services
// {
//     public class ProductService : IProductRepository
//     {
//         protected readonly AppDbContext _context; // Database context for accessing bookings

//         public ProductService(AppDbContext context)
//         {
//             _context = context; // Initialize context
//         }

//         // Method to get a booking by ID
//         public async Task<Product?> GetById(int id)
//         {
//             return await _context.pro.FindAsync(id);
//         }

//         // Method to get all guests
//         public async Task<IEnumerable<Product>> GetAll()
//         {
//             return await _context.pro.ToListAsync();
//         }

//         // Method to register a new guest
//         public async Task Create(Product product)
//         {
//             if (product == null)
//             {
//                 throw new ArgumentNullException(nameof(product), "El categoria no puede ser nulo.");
//             }

//             try
//             {
//                 await _context.pro.AddAsync(product);
//                 await _context.SaveChangesAsync();
//             }
//             catch (DbUpdateException dbEx)
//             {
//                 throw new Exception("Error al agregar el categoria a la base de datos.", dbEx);
//             }
//             catch (Exception ex)
//             {
//                 throw new Exception("Ocurrió un error inesperado al agregar el categoria.", ex);
//             }
//         }

//         public async Task Update(Product product)
//         {
//             if (product == null)
//             {
//                 throw new ArgumentNullException(nameof(product), "El categoria no puede ser nulo.");
//             }

//             try
//             {
//                 _context.Entry(product).State = EntityState.Modified;
//                 await _context.SaveChangesAsync();
//             }
//             catch (DbUpdateException dbEx)
//             {
//                 throw new Exception("Error al actualizar el categoria en la base de datos.", dbEx);
//             }
//             catch (Exception ex)
//             {
//                 throw new Exception("Ocurrió un error inesperado al actualizar el categoria.", ex);
//             }
//         }

//         public async Task Delete(int id)
//         {
//             var product = await _context.pro.FindAsync(id);
//             if (product != null)
//             {
//                 _context.pro.Remove(product);
//                 await _context.SaveChangesAsync();
//             }
//         }
//     }
// }