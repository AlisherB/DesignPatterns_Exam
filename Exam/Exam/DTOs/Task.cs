using System;
using System.Collections.Generic;

namespace Exam
{
    public class Task
    {
        public Guid TaskId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
        public List<Tag> Tags { get; set; }
        public DateTime DateOfCreation { get; set; }
        public DateTime DateOfCompletion { get; set; }
    }
}
