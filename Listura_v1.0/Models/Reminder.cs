namespace Listura_v1._0.Models
{
    public class Reminder:BaseEntity
    {
        public DateTime ReminderTime { get; set; }
        public int TaskItemId { get; set; }
        public Task Task { get; set; }
    }
}
