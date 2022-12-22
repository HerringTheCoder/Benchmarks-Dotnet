using System;
using System.Collections.Generic;

namespace Benchmarks.Cast;

public record AggregateCreatedDomainEvent(
        Guid Id, 
        Dictionary<Guid, List<string>> Entries,
        DateTimeOffset? ExpiresAt)
    : IDomainEvent;