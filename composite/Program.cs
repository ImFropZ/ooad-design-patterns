using composite;

IComponent comp = new Composite(
    new IComponent[]
    {
        new Component("Morning"),
        new Composite(
            new IComponent[]
            {
                new Component("M1"),
                new Component("M2"),
                new Component("M3"),
                new Composite(new IComponent[]
                {
                    new Component("A1"),
                    new Component("A2"),
                    new Component("A3"),
                })
            }
        ),
        new Component("Afternoon")
    });
    
    Console.WriteLine(comp.Operation());