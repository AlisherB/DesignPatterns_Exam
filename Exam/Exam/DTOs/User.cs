using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class User
    {
        public Guid UserId { get; set; }
        public string FullName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Guid TaskId { get; set; }
        public List<Task> Tasks { get; set; }
    }
}
