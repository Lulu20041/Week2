using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperWeek2.Database
{
    interface IRepository
    {
        public void AddTask(Task task);

        public List<Task> GetTasks();

        public void UpdateTaskStatus(int id,bool status);

        public void DeleteTaskById(int id);
    }
}
