using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Repositories;

namespace SimpleTaskSystem
{
    public interface ITaskRepository : IRepository<Task, long>
    {
        List<Task> GetAllWithPeople(int? assignedPersonId, TaskStatus? state);
    }
}
