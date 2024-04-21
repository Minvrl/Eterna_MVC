namespace MVC_Eterna.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public string URL { get; set; }
        public DateTime Date { get; set; }
        public Category Category { get; set; }
        public List<ProjectImg> ProjectImgs { get; set; }
    }
}
