using System.ComponentModel.DataAnnotations;

namespace Portfolio.Data.Entities
{
    public class Project
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Görsel url boş bırakılamaz.")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Proe Adı boş bırakılamaz.")]
        [MinLength(3,ErrorMessage = "Project Adı en az 3 karakter olmalıdır")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Proje açıklaması boş bırakılamaz.")]
        [MaxLength(100,ErrorMessage ="Proje Açıklaması en fazla 100 karakter olmalıdır. ")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Github url  boş bırakılamaz.")]
        public string GitHubUrl { get; set; }

        public List<ProjectTechStack>? ProjectTechStacks { get; set; }
    }
}
