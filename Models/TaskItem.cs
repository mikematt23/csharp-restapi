namespace taskMangerment.Models
{
    public class TaskItem
    {
        public int id{ get; set; }

        public string Title{ get; set; }
        public string Description {  get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now; 
    }
}
