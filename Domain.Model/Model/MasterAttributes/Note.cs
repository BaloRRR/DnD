using System;
using Domain.Model.Abstract;

namespace Domain.Model.Model
{
    public class Note
    {
        public int NoteId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Text { get; set; }

        public DateTime CreateDate { get; set; }

        //public int UserId { get; set; } createdBy ?
    }
}
