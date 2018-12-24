using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Abp.Runtime.Validation;
using Abp.UI;

namespace SimpleTaskSystem
{
    public class CreateTaskInput: IShouldNormalize,ICustomValidate
    {
        public int? AssignedPersonId { get; set; }

        [Required]
        public string Description { get; set; }

        public DateTime CreateTime { get; set; }

        public void AddValidationErrors(CustomValidationContext context)
        {
            if (Description.Length>5)
            {
                context.Results.Add(new ValidationResult("描述长度不能大于5"));
               // throw new UserFriendlyException("省份编码长度不能超过5个字符");
            }
        }

        public void Normalize()
        {
            CreateTime = DateTime.Now;
        }

        public override string ToString()
        {
            return string.Format("[CreateTaskInput > AssignedPersonId = {0}, Description = {1}]", AssignedPersonId, Description);
        }
    }
}