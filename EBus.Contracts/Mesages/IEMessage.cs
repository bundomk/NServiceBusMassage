using System;

namespace EBus.Contracts.Messages
{
    public interface IEMessage
    {
        Guid Id { get; set; }

        string Name { get; set; }

        string Description { get; set; }
    }
}
