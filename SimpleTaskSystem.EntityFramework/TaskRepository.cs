using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.EntityFramework;
using SimpleTaskSystem.EntityFramework;
using SimpleTaskSystem.EntityFramework.Repositories;

namespace SimpleTaskSystem
{
    public class TaskRepository : SimpleTaskSystemRepositoryBase<Task, long>, ITaskRepository
    {
        public TaskRepository(IDbContextProvider<SimpleTaskSystemDbContext> dbContextProvider) : base(dbContextProvider)
        {

        }

        public List<Task> GetAllWithPeople(int? assignedPersonId, TaskStatus? state)
        {
            var query = GetAll();
            if (assignedPersonId.HasValue)
            {
                query = query.Where(task => task.AssignedPersonId == assignedPersonId);
            }
            if (state.HasValue)
            {
                query = query.Where(task => task.State == state);
            }

            
            return query
                .OrderByDescending(x => x.CreationTime)
                .Include(x => x.AssignedPerson)
                .ToList();
        }

    }
}
