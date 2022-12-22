using System;

namespace Benchmarks.Cast;

public interface IIntegrationEvent
{
    Guid CorrelationId { get; }
}