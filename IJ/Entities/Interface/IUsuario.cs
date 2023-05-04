namespace IJ.Entities.Interface;

    public interface IUsuario : INomeCompleto, ICpf, ITelefone, IEndereco, IImage
    {
        public Guid IdUsuario { get;}
        public int IdNomeCompleto { get; set; }
        public int IdCpf { get; set; }
        public int IdTelefone { get; set; }
        public int IdEndereco { get; set; }
        public int IdImage { get; set; }
    
    }
