using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzApp.Models
{
    [Table("Pizzas")]
    public class Pizza
    {
        [Key]
        public int PizzaId { get; set; }
        [Required(ErrorMessage ="O nome do produto deve ser informado")]
        [Display(Name ="Nome do produto")]
        [StringLength(80, MinimumLength = 5, ErrorMessage ="O {0} deve ter no máximo {1} e no mínimo {2}")]
        public string PizzaName { get; set; }
        [Required(ErrorMessage ="A descrição do produto deve ser informada")]
        [Display(Name = "Descrição do produto")]
        [MinLength(10, ErrorMessage ="A descrição deve ter no mínimo {1} caracteres")]
        [MaxLength(200, ErrorMessage ="A descrição não pode exceder {1} caracteres")]
        public string DescricaoCurta { get; set; }
        [Required(ErrorMessage = "A descrição detalhada do produto deve ser informada")]
        [Display(Name = "Descrição detalhada do produto")]
        [MinLength(10, ErrorMessage = "A descrição detalhada deve ter no mínimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "A descrição detalhada não pode exceder {1} caracteres")]
        public string DescricaoDetalhada { get; set; }
        [Required(ErrorMessage ="Informe o preço do produto")]
        [Display(Name ="Preço")]
        [Column(TypeName ="decimal(10,2)")]
        [Range(1,999.99, ErrorMessage="O preço deve estar entre 1 e 999,99")]
        public decimal Preco { get; set; }
        [Display(Name ="Caminho da imagem normal")]
        [StringLength(200, ErrorMessage ="O {0} deve ter no máximo {1} caracteres")]
        public string ImagemUrl { get; set; }
        [Display(Name = "Caminho da imagem miniatura")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string ImagemThumbnailUrl { get; set; }
        [Display(Name ="Preferido?")]
        public bool IsPizzaPreferida { get; set; }
        [Display(Name ="Estoque")]
        public bool EmEstoque { get; set; }

        [Display(Name ="Categorias")]
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }

    }
    
}
