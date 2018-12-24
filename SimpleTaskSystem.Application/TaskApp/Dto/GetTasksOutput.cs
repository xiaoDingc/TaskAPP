using System.Collections.Generic;

namespace SimpleTaskSystem
{
    public class GetTasksOutput
    {
        public List<TaskDto> Tasks { get; internal set; }
    }
}