namespace KayakerApp.Domain
{
    public class Quote
    {
            public int Id { get; set; }
            public string Text { get; set; }
            public Kayaker Kayaker { get; set; }
            public int KayakerId { get; set; }
    }
}
