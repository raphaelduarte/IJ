using IJ.Domain.Entities.ValueObjects;

namespace IJ.Domain.Repositories;

public interface INomeCompletoRepository
{
    void Create(NomeCompleto nomeCompleto);
    void Update(NomeCompleto nomeCompleto);
    void Remove(NomeCompleto nomeCompleto);
    NomeCompleto GetById(Guid id);
    IEnumerable<NomeCompleto> GetAll();
}