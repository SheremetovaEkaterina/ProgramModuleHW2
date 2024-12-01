using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramModuleHW2
{
    public class InMemoryTaskRepository : ITaskRepository
    {
        private readonly List<Task> _tasks = new();
        private int _nextId = 1;

        public void AddTask(Task task)
        {
            task.Id = _nextId++;
            _tasks.Add(task);
        }

        public List<Task> GetTasks() => _tasks;

        public Task GetTaskById(int taskId) => _tasks.FirstOrDefault(t => t.Id == taskId);

        public bool DeleteTask(int taskId)
        {
            var task = GetTaskById(taskId);
            if (task != null)
            {
                _tasks.Remove(task);
                return true;
            }
            return false;
        }
    }
}
