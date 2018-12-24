using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTaskSystem
{
  public  interface ITaskAppService:IApplicationService
    {
        GetTasksOutput GetTasks(GetTasksInput input);
        void CreateTask(CreateTaskInput input);
    }
}
