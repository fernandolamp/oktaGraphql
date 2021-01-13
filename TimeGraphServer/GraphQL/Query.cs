using HotChocolate;
using HotChocolate.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeGraphServer.Database;
using TimeGraphServer.Models;

namespace TimeGraphServer.GraphQL
{
    public class Query
    {
        [UseDbContext(typeof(TimeGraphContext))]
        public IQueryable<Project> GetProjects([ScopedService] TimeGraphContext dbcontext)
        {
            return dbcontext.Projects;
        }
        [UseDbContext(typeof(TimeGraphContext))]
        public IQueryable<TimeLog> GetTimeLogs([ScopedService] TimeGraphContext dbcontext)
        {
            return dbcontext.TimeLogs;
        }
    }
}
