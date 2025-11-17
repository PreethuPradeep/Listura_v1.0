using System.ComponentModel.DataAnnotations.Schema;

namespace Listura_v1._0.Models
{
    public class SubTask:BaseEntity
    {
        //public string SubTaskId { get; set; }
        public string SubTaskName { get; set; }
        public bool IsCompleted { get; set; }
        public string TaskItemId { get; set; }
        [ForeignKey("TaskItemId")]
        public TaskItem Task { get; set; }
    }
}
//smaller steps in a task
//belongs to one task id