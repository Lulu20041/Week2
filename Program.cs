
using DapperWeek2;


DatabaseCreator dbCreator = new SQLServerDatabaseCreator();
IDatabase database = dbCreator.CreateDatabase();
database.OpenConnection();

IRepository repo = new SQLServerRepository(database.Connection);

List<DapperWeek2.Task> tasks = repo.GetTasks();
repo.UpdateTaskStatus(1, true);

DapperWeek2.Task task = new();
task.Title = "Grocery shopping";
task.Description = "Buy vegetables, fruits, and cleaning supplies for the week.";
task.IsCompleted = false;
task.CreatedAt = DateTime.Now;
repo.AddTask(task);

database.Dispose();