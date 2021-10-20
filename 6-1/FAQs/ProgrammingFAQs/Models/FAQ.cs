namespace ProgrammingFAQs.Models
{
    public class FAQ
    {
        public int FAQID { get; set; }

        public Category Category { get; set; }
        public Topic Topic { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}
