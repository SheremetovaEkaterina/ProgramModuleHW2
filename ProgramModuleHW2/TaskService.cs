using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramModuleHW2
{
    public class TaskService
    {
        private readonly ITaskRepository _taskRepository;

        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public void AddTask(Task task) => _taskRepository.AddTask(task);

        public List<Task> GetTasks() => _taskRepository.GetTasks();

        public bool MarkAsCompleted(int taskId)
        {
            var task = _taskRepository.GetTaskById(taskId);
            if (task != null)
            {
                task.IsCompleted = true;
                return true;
            }
            return false;
        }

        public bool DeleteTask(int taskId) => _taskRepository.DeleteTask(taskId);
    }
}
