using System;
using System.Collections.Generic;

namespace KayakerApp.Domain
{
    public class Battle
    {
            public int Id { get; set; }
            public string Name { get; set; }
            public DateTime StartDate { get; private set; }
            public DateTime EndDate { get; private set; }
            public List<Kayaker> Kayakers { get; set; }
    }
}

