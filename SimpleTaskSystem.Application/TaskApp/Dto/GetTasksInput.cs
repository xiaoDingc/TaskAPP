using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace SimpleTaskSystem
{
    public class GetTasksInput
    {
        [Range(1, long.MaxValue)]
        public long TaskId { get; set; }

        public int? AssignedPersonId { get; set; }

        public TaskStatus? State { get; set; }
    }
}