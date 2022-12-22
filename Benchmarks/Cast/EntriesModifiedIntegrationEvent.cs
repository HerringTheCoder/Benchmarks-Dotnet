using System;
using System.Collections.Generic;

namespace Benchmarks.Cast;

public record EntriesModifiedIntegrationEvent(Guid Id, List<string> Entries, DateTimeOffset? ExpiresAt, Guid CorrelationId) 
    : IIntegrationEvent;