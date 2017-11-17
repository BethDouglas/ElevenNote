using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    public class NoteListItemModel
    {
        [DisplayName("ID #")]
        public int NoteId { get; set; }

        public string Title { get; set; }

        [UIHint("Starred")]
        [DisplayName("Important")]
        public bool IsStarred { get; set; }

        [DisplayName("Created")]
        public DateTime CreatedUtc { get; set; }

        [DisplayName("Modified")]
        public DateTime? ModifiedUtc { get; set; }
    }
}
