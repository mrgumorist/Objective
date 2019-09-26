using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Objective.Entities
{
    public class TaskTag
    {
        public int TaskID { get; set; }
        public Task Task { get; set; }

        public int TagID { get; set; }
        public Tag Tag { get; set; }
    }
}
