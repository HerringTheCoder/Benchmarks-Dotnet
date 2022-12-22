using System;
using System.Collections.Generic;

namespace EFCoreBenchmarks.Models;

public class EntityBase
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}

public class Aggregate : EntityBase
{
    public List<Entity1> Entities1 { get; set; } = new();
    public List<Entity2> Entities2 { get; set; } = new();
    public List<Entity3> Entities3 { get; set; } = new();
    public List<Entity4> Entities4 { get; set; } = new();
    public List<Entity5> Entities5 { get; set; } = new();
}


public class Entity1  : EntityBase
{
}

public class Entity2 : EntityBase
{
}

public class Entity3 : EntityBase
{
}

public class Entity4 : EntityBase
{
}

public class Entity5 : EntityBase
{
}
