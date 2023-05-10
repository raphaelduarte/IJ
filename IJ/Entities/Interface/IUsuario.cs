namespace IJ.Entities.Interface;

public interface IUsuario : INomeCompleto, ICpf, ITelefone, IEndereco, IImage
{
    public Guid IdUsuario { get; }
    public INomeCompleto NomeCompleto { get; set; }
     public ICpf Cpf { get; set; }
    public IList<ITelefone> Telefones { get; set; }
    public IList<IEndereco> Enderecos { get; set; }
    public IList<IImage> Imagens { get; set; }



    
}
