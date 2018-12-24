using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;

namespace SimpleTaskSystem
{
    public class Person : Entity, ISoftDelete
    {
        public virtual string Name { get; set; }
        public bool IsDeleted { get; set; }

    }
}
