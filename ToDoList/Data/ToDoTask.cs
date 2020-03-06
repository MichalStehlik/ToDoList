using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Data
{
    public class ToDoTask
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IdentityUser Source { get; set; }
        public IdentityUser Target { get; set; }
        public Guid SourceId { get; set; }
        public Guid TargetId { get; set; }
        public DateTime Created { get; set; }
        public DateTime End { get; set; }
        public bool Finished { get; set; }
    }
}
