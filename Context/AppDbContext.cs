using apifuncionario.Models;
using Microsoft.EntityFrameworkCore;

namespace apifuncionario.Context;

public class AppDbContext : DbContext
{
     public AppDbContext(DbContextOptions options) : base (options)
    {
    }
    public DbSet<Funcionario> Funcionario {get; set;}
    public DbSet<Setor> Setor {get; set;}
}

