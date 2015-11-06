using System;

namespace EBus.Contracts.Commands
{
    public interface IECommand
    {
        Guid Id { get; set; }

        string Name { get; set; }
    }
}
