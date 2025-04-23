using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorTasker.Models
{
    public class TaskerItem
    {
        //GUID is a unique identifier for each task
        public Guid Id { get; set; }

        //name of task followed by a default
        [Required(ErrorMessage = "Every task must have a name")]
        public string Name { get; set; } = "";

        public bool IsComplete { get; set; } = false;
    }
}