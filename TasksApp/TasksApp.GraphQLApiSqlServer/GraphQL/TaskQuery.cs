using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TasksApp.GraphQLApiSqlServer.Data;

namespace TasksApp.GraphQLApiSqlServer.GraphQL
{
    public class TaskQuery : ObjectGraphType
    {
        public TaskQuery(ApplicationDbContext db)
        {
            //Field<TaskType>(
            //    "Task",
            //    arguments: new QueryArguments()
            //    );

            Field<ListGraphType<TaskType>>(
                "Tasks",
                resolve: context => {
                    return db.Tasks.ToList();
                });
        }
    }
}
