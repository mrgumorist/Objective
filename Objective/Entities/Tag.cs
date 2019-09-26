using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Objective.Entities
{
    public class Tag
    {
        [Key]
        public int Id { get; set; }
        [Required, MinLength(3)]
        public string Name { get; set; }
        public List<TaskTag> TaskTags { get; set; }

        public Tag()
        {
            TaskTags = new List<TaskTag>();
        }
    }
}
