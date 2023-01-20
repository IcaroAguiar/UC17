using System.ComponentModel.DataAnnotations;

namespace ChapterApi.ViewModels
{
    public class LoginViewModels
    {
        [Required(ErrorMessage = "Informe o e-mail do usuário")]
        public string email { get; set; }

        [Required(ErrorMessage = "Informe o senha do usuário")]
        public string senha { get; set; }

    }
}
