namespace Listura_v1._0.Models
{
    public class Task:BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? DueDate { get; set; }
        public TimeSpan? DueTime { get; set; }
        public bool IsReccuring { get; set; }
        public string? ReccurancePattern { get; set; }
        public int SectionId { get; set; }
        public Section Section { get; set; }

        public ICollection<SubTask> SubTasks { get; set; }
        public ICollection<Task> Tasks { get; set; }
    }
    public enum TaskPriority { Low = 1, Medium, High, Critical }
    public enum TaskStatus { Pending, Completed, Overdue }

}
