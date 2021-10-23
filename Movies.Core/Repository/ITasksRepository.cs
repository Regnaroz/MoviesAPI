using Movies.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Core.Repository
{
   public  interface ITasksRepository
    {
        public List<Tasks> GetTasks();
        public bool InsertTasks(Tasks Task);
        public bool UpdateTasks(Tasks Task);
        public bool DeleteTasks(int id);
        public List<Tasks> GetTasksByAccountantId(int accountantId);

    }
}
