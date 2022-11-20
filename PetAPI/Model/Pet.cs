using System.ComponentModel.DataAnnotations;

namespace PetApi.Model
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public Category Category { get; set; }

        public string[] PhotoUrls { get; set; }

        public ICollection<Tag> Tags { get; set; }
        public string Status { get; set; }
    }
}
