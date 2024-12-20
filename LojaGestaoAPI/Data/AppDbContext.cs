using System;
using LojaGestaoAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LojaGestaoAPI.Data;

public class AppDbContext : DbContext

{
    public DbSet<Produto> Produtos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=lojaGestao.db");
    }   
}
