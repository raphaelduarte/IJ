using IJ.Entities.Interface;
using IJ.Entities.Service;
using Microsoft.EntityFrameworkCore;

namespace IJ.Context;

public class DataContext : DbContext
{
    public DbSet<Usuario>? Usuarios { get; set; }
    public DbSet<Cpf>? Cpfs { get; set; }
    public DbSet<Telefone>? Telefones { get; set; }
    public DbSet<NomeCompleto>? NomesCompletos { get; set; }
    public DbSet<Endereco> Enderecos { get; set; }
}