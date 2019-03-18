using System.Collections.Generic;

namespace KayakerApp.Domain
{
    public class Kayaker
    {
        public Kayaker()
        {
            Quotes = new List<Quote>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Quote> Quotes { get; set; }
        public int BattleId { get; set; }
    }
}
