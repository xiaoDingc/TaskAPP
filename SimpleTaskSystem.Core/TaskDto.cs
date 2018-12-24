using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;

namespace SimpleTaskSystem
{
    public class TaskDto : Entity<long>
    {
        [ForeignKey("AssignedPersonId")]
        public virtual Person AssignedPerson { get; set; }

        public virtual int? AssignedPersonId { get; set; }

        public virtual string Description { get; set; }

        public virtual DateTime CreationTime { get; set; }

        public virtual TaskStatus State { get; set; }

        public TaskDto()
        {
            CreationTime = DateTime.Now;
            State = TaskStatus.WaitingForActivation;
        }
    }
}
