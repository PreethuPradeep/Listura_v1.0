namespace Listura_v1._0.Models
{
    public class Project: BaseEntity
    {
        public string Name { get; set; }
        public int SectionId { get; set; }
        public Section Section { get; set; }
        public ICollection<Task> Tasks { get; set; }
    }
}
