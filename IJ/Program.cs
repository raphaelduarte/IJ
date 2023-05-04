using IJ.Context;
using IJ.Entities.Service;

class InvestigationJob
{
    static void Main(string[] args)
    {
        
        using (var context = new DataContext())
        {
            var Usuario = new Usuario 
            { 
                Nome = "Raphael",
                Sobrenome = "Duarte Silva Silveira",
                NumeroCpf = 14167910780,
                Ddd = 48,
                NumeroTelefone = 988221299,
                Rua = "Estrada Geral das Picadas",
                Numero = 0,
                Bairro = "Lessa",
                Cidade = "Alfredo Wagner",
                Estado = "Santa Catarina",
                Pais = "Brasil"
            };
            context.Usuarios.Add(Usuario);
            context.SaveChanges();
            Console.WriteLine("Foi para o banco");
        }
    }
}