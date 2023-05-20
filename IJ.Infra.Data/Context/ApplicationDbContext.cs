using IJ.Domain.Entities;
using IJ.Domain.Entities.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace IJ.Infra.Data.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<NomeCompleto> NomesCompletos { get; set; }
    public DbSet<Telefone> Telefones { get; set; }
    public DbSet<Endereco> Enderecos { get; set; }
    public DbSet<Cpf> Cpfs { get; set; }
    public DbSet<Email> Emails { get; set; }
    public DbSet<Senha> Senhas { get; set; }
    public DbSet<AgenteCampana> AgentesCampanas { get; set; }
    public DbSet<AgenteInteligencia> AgentesInteligencia { get; set; }
    public DbSet<Investigacao> Investigacoes { get; set; }
    public DbSet<Contratante> Contratantes { get; set; }
    public DbSet<Investigado> Investigados { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }

}