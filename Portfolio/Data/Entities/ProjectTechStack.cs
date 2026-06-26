namespace Portfolio.Data.Entities
{
    public class ProjectTechStack
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        // Navigation property to the Project entity
        public Project Project { get; set; }
        public int TechStackId   { get; set; }
        // Navigation property to the TechStack entity
        public TechStack TechStack { get; set; }
    }
}
