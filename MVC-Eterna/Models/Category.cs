namespace MVC_Eterna.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Project> Projects { get; set; }
    }
}
