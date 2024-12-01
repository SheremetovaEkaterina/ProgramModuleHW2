using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramModuleHW2
{
    public class TaskView
    {
        public void DisplayTasks(List<Task> tasks)
        {
            Console.WriteLine("Список задач:");
            foreach (var task in tasks)
            {
                Console.WriteLine($"[{task.Id}] {task.Title} - {task.Description} (Выполнено: {task.IsCompleted})");
            }
        }

        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
