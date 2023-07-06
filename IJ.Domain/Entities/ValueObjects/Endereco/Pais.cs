namespace IJ.Domain.Entities.ValueObjects.Endereco
{
    public class Pais : Entity
    {
        public Pais(string paisName)
        {
            PaisName = paisName;
        }
        private string PaisName { get; set; }
    }
}
