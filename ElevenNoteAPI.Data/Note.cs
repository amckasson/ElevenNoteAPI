using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNoteAPI.Data
{
    public class Note

        //This class is the Note Entity
    {

        //This is the primary key that that uniquely identifies the entity
        [Key]
        public int NoteId { get; set; }
        
        [Required]
        public Guid OwnerId { get; set; }
       
        [Required]
        public string Title { get; set; }
        
        [Required]
        public string Content { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
