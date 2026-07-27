namespace Portfolio.Data.Entities
{
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }


        public int AboutId { get; set; }
        public About About { get; set; }
    }
}
