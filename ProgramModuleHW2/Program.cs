using ProgramModuleHW2;

class Program
{
    static void Main(string[] args)
    {
        var repository = new InMemoryTaskRepository();
        var service = new TaskService(repository);
        var view = new TaskView();
        var controller = new TaskController(service, view);

        controller.AddTask("Сделать домашнее задание", "Завершить проект по C#");
        controller.AddTask("Сходить в магазин", "Купить продукты для ужина");
        controller.DisplayTasks();

        controller.MarkTaskAsCompleted(1);
        controller.DisplayTasks();

        controller.DeleteTask(2);
        controller.DisplayTasks();
    }
}
