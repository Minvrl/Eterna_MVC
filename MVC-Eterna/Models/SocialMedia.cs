namespace MVC_Eterna.Models
{
    public class SocialMedia
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Icon { get; set; }
        public Member Member { get; set; }
    }
}
