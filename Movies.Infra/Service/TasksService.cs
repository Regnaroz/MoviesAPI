using Movies.Core.Data;
using Movies.Core.Repository;
using Movies.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Infra.Service
{
    public class TasksService : ITasksService
    {
        private readonly ITasksRepository TasksRepository;
        public TasksService(ITasksRepository TasksRepository)
        {
            this.TasksRepository = TasksRepository;
        }
        public bool DeleteTasks(int id)
        {
            return TasksRepository.DeleteTasks(id);
        }

        public List<Tasks> GetTasks()
        {
            return TasksRepository.GetTasks();
        }

        public List<Tasks> GetTasksByAccountantId(int accountantId)
        {
            return TasksRepository.GetTasksByAccountantId(accountantId);
        }

        public bool InsertTasks(Tasks Task)
        {
            return TasksRepository.InsertTasks(Task);
        }

        public bool UpdateTasks(Tasks Task)
        {
            return TasksRepository.UpdateTasks(Task);
        }
    }
}
