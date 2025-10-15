
using DapperWeek2;
using DapperWeek2.Database;
using DapperWeek2.Database.Factory;
using DapperWeek2.Database.Repository;



DatabaseCreator dbCreator = new SQLServerDatabaseCreator();
IDatabase database = dbCreator.CreateDatabase();
database.OpenConnection();

IRepository repo = new SQLServerRepository(database.Connection);

repo.UpdateTaskStatus(1, true);

DapperWeek2.Task task = new();
task.Title = "Grocery shopping";
task.Description = "Buy vegetables, fruits, and cleaning supplies for the week.";
task.IsCompleted = false;
task.CreatedAt = DateTime.Now;
repo.AddTask(task);

List<DapperWeek2.Task> tasks = repo.GetTasks();

foreach (var item in tasks)
{
    Console.WriteLine($"Id: {item.Id}\n" +
    $"Title: {item.Title}\n" +
    $"Description: {item.Description}\n" +
    $"Is completed: {item.IsCompleted}\n" +
    $"Created at: {item.CreatedAt}\n"
    );
}

database.Dispose();