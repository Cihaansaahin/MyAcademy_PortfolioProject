namespace Portfolio.Data.Entities
{
    public class About
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        public List<Skill> Skills { get; set; } = new List<Skill>();
    }
}


