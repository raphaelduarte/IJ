using IJ.Domain.Commands.Contracts;

namespace IJ.Domain.Handlers.Contracts;

public interface IHandler<T>
{
    ICommandResult Handler(T command);
}