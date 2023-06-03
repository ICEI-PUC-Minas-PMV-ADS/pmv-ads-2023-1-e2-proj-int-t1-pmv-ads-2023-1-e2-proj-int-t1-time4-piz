using System.ComponentModel.DataAnnotations;

namespace PizzApp.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Informe o nome")]
        [Display(Name ="Usuário")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Informe a senha")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{6,}$",
        ErrorMessage = "A senha deve conter no mínimo 6 caracteres, sendo pelo menos uma letra maiúscula, uma letra minúscula, um número e um caractere especial.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string ReturnUrl { get; set; }

    }
}
