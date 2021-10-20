using System.Collections.Generic;

namespace ProgrammingFAQs.Models
{
    public class FAQListViewModel : FAQViewModel
    {
        public List<FAQ> FAQs { get; set; }

        // use full properties for Categorys and Topics 
        // so can add 'All' item at beginning
        private List<Category> categorys;
        public List<Category> Categorys {
            get => categorys; 
            set {
                categorys = value;
            }
        }

        private List<Topic> topics;
        public List<Topic> Topics {
            get => topics; 
            set {
                topics = value;
            }
        }

        // methods to help view determine active link
        public string CheckActiveCategory(string c) => 
            c.ToLower() == ActiveCategory.ToLower() ? "active" : "";
          
        public string CheckActiveTopic(string d) => 
            d.ToLower() == ActiveTopic.ToLower() ? "active" : "";
    }
}