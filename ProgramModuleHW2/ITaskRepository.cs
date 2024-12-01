using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramModuleHW2
{
    public interface ITaskRepository
    {
        void AddTask(Task task);
        List<Task> GetTasks();
        Task GetTaskById(int taskId);
        bool DeleteTask(int taskId);
    }
}
