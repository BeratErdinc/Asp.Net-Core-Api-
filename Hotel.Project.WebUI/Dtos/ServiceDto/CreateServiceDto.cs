using System.ComponentModel.DataAnnotations;

namespace Hotel.Project.WebUI.Dtos.ServiceDto
{
    public class CreateServiceDto
    {
        [Required(ErrorMessage ="HizmetIcon Linki giriniz")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "HizmetIcon Linki giriniz")]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
