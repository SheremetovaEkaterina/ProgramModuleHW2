using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramModuleHW2
{
    public class TaskController
    {
        private readonly TaskService _taskService;
        private readonly TaskView _taskView;

        public TaskController(TaskService taskService, TaskView taskView)
        {
            _taskService = taskService;
            _taskView = taskView;
        }

        public void AddTask(string title, string description)
        {
            _taskService.AddTask(new Task { Title = title, Description = description });
            _taskView.DisplayMessage("Задача успешно добавлена!");
        }

        public void DisplayTasks()
        {
            var tasks = _taskService.GetTasks();
            _taskView.DisplayTasks(tasks);
        }

        public void MarkTaskAsCompleted(int taskId)
        {
            var result = _taskService.MarkAsCompleted(taskId);
            _taskView.DisplayMessage(result ? "Задача выполнена!" : "Задача не найдена.");
        }

        public void DeleteTask(int taskId)
        {
            var result = _taskService.DeleteTask(taskId);
            _taskView.DisplayMessage(result ? "Задача удалена!" : "Задача не найдена.");
        }
    }
}
