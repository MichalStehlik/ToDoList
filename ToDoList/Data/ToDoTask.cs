using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Data
{
    public class ToDoTask
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("SourceId")]
        public IdentityUser Source { get; set; }
        [ForeignKey("TargetId")]
        public IdentityUser Target { get; set; }
        public string SourceId { get; set; }
        public string TargetId { get; set; }
        public DateTime Created { get; set; }
        public DateTime End { get; set; }
        public bool Finished { get; set; }
    }
}
