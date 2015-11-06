using System;

namespace EBus.Contracts.Messages
{
    public interface IERemoteMessage
    {
        Guid Id { get; set; }

        string Name { get; set; }
    }
}
