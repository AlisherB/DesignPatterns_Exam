using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public abstract class ToDo
    {
        public abstract void SetPriority(int priority);
        public abstract void AddTag(string tag);
        public abstract void Save(string filename);
        public abstract void Load(string filename);
        public abstract void Edit(Task data);
        public abstract void DeleteByTag(string tag);
        public abstract void DeleteByTitle(string title);
        public abstract List<Task> SearchByTag(string tag);
    }
}
