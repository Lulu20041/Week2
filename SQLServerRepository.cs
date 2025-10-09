using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperWeek2
{
    class SQLServerRepository : IRepository
    {
        private SqlConnection connection;

        public SQLServerRepository(SqlConnection connection) { this.connection = connection; }

        public void AddTask(Task task)
        {
            string query = @"insert into tasks(title,description,isCompleted,createdAt) values
            (@title,@description,@isCompleted,@createdAt)";
            connection.Execute(query, task);
        }

        public void DeleteTaskById(int id)
        {
            string query = @"delete from tasks where id=@id";
            connection.Execute(query, id);
        }

        public List<Task> GetTasks()
        {
            string query = "select * from tasks";
            var tasks = connection.Query<Task>(query).AsList();
            return tasks;
        }

        public void UpdateTaskStatus(int id,bool status)
        {
            string query = @"update tasks set tasks.isCompleted =@status where tasks.id=@id";
            connection.Execute(query, new[] { new { status, id } });
        }
    }
}
