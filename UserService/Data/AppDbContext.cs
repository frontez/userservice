using System;
using Microsoft.EntityFrameworkCore;
using UserService.Models;

namespace UserService;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
}
