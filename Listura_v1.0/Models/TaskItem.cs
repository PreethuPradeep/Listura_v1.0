using Listura_v1._0.enums;
using System.ComponentModel.DataAnnotations.Schema;
using TaskStatus = Listura_v1._0.enums.TaskStatus;

namespace Listura_v1._0.Models
{
    public class TaskItem:BaseEntity
    {
        //public int TaskItemId { get; set; }
        public string TaskName { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? DoneDate { get; set; }
        public TaskPriority Priority { get; set; }
        public TaskStatus Status { get; set; } = TaskStatus.pending;
        public TaskRepeat Repeat { get; set; } 
        public bool IsRecurring { get; set; }
        public int SectionId { get; set; }
        [ForeignKey("SectionId")]
        public Section Section { get; set; }
        
        public ICollection<SubTask> SubTasks { get; set; }
        public ICollection<TaskLabel> TaskLabel { get; set; }
        public ICollection<Reminder> Reminders { get; set; }
        
    }
}
//single to-do item in a section
//can have sub tasks
//can have labels, reminders,etc