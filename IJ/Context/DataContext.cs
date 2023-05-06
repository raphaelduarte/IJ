using IJ.Entities.Service;
using IJ.Entities.Service.Investigacao;
using Microsoft.EntityFrameworkCore;

namespace IJ.Context;

public class DataContext : DbContext
{
    
    public DbSet<Usuario>? Usuarios { get; set; }
    public DbSet<Cpf>? Cpfs { get; set; }
    public DbSet<Telefone>? Telefones { get; set; }
    public DbSet<NomeCompleto>? NomesCompletos { get; set; }
    public DbSet<Endereco>? Enderecos { get; set; }
    public DbSet<AgenteCampana>? AgentesCampanas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer("Server=SQLEXPRESS;Database=Investigation Job;Integrated Security=SSPI");
    }
}