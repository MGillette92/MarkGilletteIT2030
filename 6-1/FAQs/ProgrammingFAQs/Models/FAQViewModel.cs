namespace ProgrammingFAQs.Models
{
    public class FAQViewModel
    {
        public FAQ FAQ { get; set; }
        public string ActiveCategory { get; set; } = "all";
        public string ActiveTopic { get; set; } = "all";
    }
}
