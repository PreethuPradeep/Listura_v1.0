using System.ComponentModel.DataAnnotations.Schema;

namespace Listura_v1._0.Models
{
    public class Reminder:BaseEntity
    {
        //public int ReminderId { get; set; }
        public DateTime ReminderTime { get; set; }
        public int TaskItemId { get; set; }
        [ForeignKey("TaskItemId")]
        public TaskItem TaskItem { get; set; }
    }
}
