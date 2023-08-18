using System.ComponentModel.DataAnnotations;

namespace WebApplication1
{
    public class TaskControl
    {
        [Key]
        public int id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "O Campo não pode ser nulo")]
        [Display(Name = "Nome:")]
        public string Name { get; set; }
        [Display(Name = "Prioridade:")]
        public int DisplayOrder { get; set; }

        [Display(Name = "Status da Tarefa:")]
        public string Status { get; set; }

        [Display(Name = "Descrição da Tarefa:")]
        public string Description { get; set; }


    }
}
