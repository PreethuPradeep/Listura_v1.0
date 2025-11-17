namespace Listura_v1._0.Models
{
    public class Label : BaseEntity
    {
        public string Name { get; set; }
        public int UserId { get; set; }
        public ICollection<TaskLabel> TaskLabels { get; set; }
    }

    public class TaskLabel
    {
        public int TaskItemId { get; set; }
        public Task TaskItem { get; set; }

        public int LabelId { get; set; }
        public Label Label { get; set; }
    }

}
