using Abp.Application.Services;
using Abp.Domain.Repositories;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTaskSystem
{
    public class TaskAppService : SimpleTaskSystemAppServiceBase, ITaskAppService
    {
        private readonly ITaskRepository _taskRepository;
        private readonly IRepository<Person> _personRepository;

        public TaskAppService(ITaskRepository taskRepository, IRepository<Person> personRepository)
        {
            _taskRepository = taskRepository;
            _personRepository = personRepository;
        }
        public void CreateTask(CreateTaskInput input)
        {
            //We can use Logger, it's defined in ApplicationService class.
            Logger.Info("Creating a task for input: " + input);

            //Creating a new Task entity with given input's properties
            var task = new Task { Description = input.Description };

            if (input.AssignedPersonId.HasValue)
            {
                task.AssignedPersonId = input.AssignedPersonId.Value;
            }

            //Saving entity with standard Insert method of repositories.
            _taskRepository.Insert(task);
        }

        public GetTasksOutput GetTasks(GetTasksInput input)
        {
            //Called specific GetAllWithPeople method of task repository.
            var tasks = _taskRepository.GetAllWithPeople(input.AssignedPersonId, input.State);

            //Used AutoMapper to automatically convert List<Task> to List<TaskDto>.
            return new GetTasksOutput
            {
                Tasks = Mapper.Map<List<TaskDto>>(tasks)
            };
        }

     
    }
}
