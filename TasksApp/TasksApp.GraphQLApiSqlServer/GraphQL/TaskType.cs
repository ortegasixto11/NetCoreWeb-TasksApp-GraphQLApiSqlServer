using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TasksApp.GraphQLApiSqlServer.GraphQL
{
    public class TaskType : ObjectGraphType<Models.Task>
    {
        public TaskType()
        {
            Name = "Task";

            Field(x => x.Name).Description("Task name");
            Field(x => x.IsActive).Description("Task is active");
            Field(x => x.CreatedAt).Description("Task date created");
        }
    }
}
