using Newtonsoft.Json.Converters;
using PetAPI.PetStatus;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PetApi.Model
{
    public class Pet
    {
        /// <example>10</example>
        public int Id { get; set; }


        /// <example>doggie</example>
        [Required]
        public string Name { get; set; }    
        public Category Category { get; set; }

        [Required]
        public string[] PhotoUrls { get; set; }

        public ICollection<Tag> Tags { get; set; }

        [EnumDataType(typeof(Status))]
        [JsonConverter(typeof(StringEnumConverter))]
        [DefaultValue(Status.Pending)]
        public Status Status { get; set; }
    }
}
