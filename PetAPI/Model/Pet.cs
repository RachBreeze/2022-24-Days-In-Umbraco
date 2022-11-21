using PetAPI.PetStatus;
using System.ComponentModel.DataAnnotations;

namespace PetApi.Model
{
    public class Pet
    {
        /// <example>10</example>
        public int Id { get; set; }
        /// <example>doggie</example>
        public string Name { get; set; }    
        public Category Category { get; set; }
        public string[] PhotoUrls { get; set; }

        public ICollection<Tag> Tags { get; set; }
        public Status Status { get; set; }
    }
}
