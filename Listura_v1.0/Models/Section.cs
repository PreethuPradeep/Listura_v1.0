using System.ComponentModel.DataAnnotations.Schema;

namespace Listura_v1._0.Models
{
    public class Section:BaseEntity
    {
        public string SectionName { get; set; }
        public int ProjectId { get; set; }
        [ForeignKey("ProjectId")]
        public Project project { get; set; }
        public ICollection<TaskItem> Tasks { get; set; }
    }
}
//sub-divisions within a project
//“Today,” “Upcoming,” or custom lists
//Belongs to one project
//contains many task items
