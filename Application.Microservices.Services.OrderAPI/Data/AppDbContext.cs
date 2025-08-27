using Application.Microservices.Services.OrderAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Application.Microservices.Services.OrderAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<OrderDetails> orderDetails { get; set; }
        public DbSet<OrderHeader> orderHeaders { get; set; }
        public object OrderHeaders { get; internal set; }
    }
}
