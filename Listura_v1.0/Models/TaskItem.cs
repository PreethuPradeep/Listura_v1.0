using System.ComponentModel.DataAnnotations.Schema;

namespace Listura_v1._0.Models
{
    public class TaskItem:BaseEntity
    {
        //public string TaskItemId { get; set; }
        public string TaskName { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? DoneDate { get; set; }
        public bool IsReccuring { get; set; }
        public string SectionId { get; set; }
        [ForeignKey("SectionId")]
        public Section Section { get; set; }
        
        public ICollection<SubTask> SubTasks { get; set; }
        //enum: repeat :everyday, every 2 day, every 3 day, every 4 day, every 5 day, every 6 day, every week, every 2 week, every 3 week, every month etc.
    }
}
//single to-do item in a section
//can have sub tasks
//can have labels, reminders,etc