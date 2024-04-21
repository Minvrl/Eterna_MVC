namespace MVC_Eterna.Models
{
    public class ProjectImg
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public bool IsPrimary { get; set; }
        public Project Project { get; set; }
    }
}
