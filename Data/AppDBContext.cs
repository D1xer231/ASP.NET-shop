using MethShop.Models;
using Microsoft.EntityFrameworkCore;

namespace MethShop.Data;

public class AppDBContext : DbContext
{
    public DbSet<Blog> posts { get; set; } = null!;
    public DbSet<Item> items { get; set; } = null!;
    public DbSet<Category> categories { get; set; } = null!;

    public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }



}