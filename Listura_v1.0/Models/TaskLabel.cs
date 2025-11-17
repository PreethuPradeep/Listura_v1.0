using System.ComponentModel.DataAnnotations.Schema;

namespace Listura_v1._0.Models
{
    public class TaskLabel:BaseEntity
    {
        //public string TaskLabelId { get; set; }
        public string LabelId { get; set; }
        public string TaskItemId { get; set; }
        [ForeignKey("LabelId")]
        public Label Label { get; set; }
        [ForeignKey("TaskItemId")]
        public TaskItem TaskItem { get; set; }
    }
}
