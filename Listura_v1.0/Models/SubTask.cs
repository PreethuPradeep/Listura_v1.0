namespace Listura_v1._0.Models
{
    public class SubTask : BaseEntity
    {
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
        public int TaskItemId { get; set; }
        public Task Task { get; set; }
    }

}
