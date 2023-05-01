using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzApp.Models
{
    [Table("Pizzas")]
    public class Pizza
    {
        [Key]
        public int PizzaId { get; set; }
        [Required(ErrorMessage ="O nome da pizza deve ser informada")]
        [Display(Name ="Nome da pizza")]
        [StringLength(80, MinimumLength = 10, ErrorMessage ="O {0} deve ter no mínimo {1} e no máximo {2}")]
        public string PizzaName { get; set; }
        [Required(ErrorMessage ="A descrição da pizza deve ser informada")]
        [Display(Name = "Descrição da pizza")]
        [MinLength(20, ErrorMessage ="A descrição deve ter no mínimo {1} caracteres")]
        [MaxLength(200, ErrorMessage ="A descrição não pode exceder {1} caracteres")]
        public string DescricaoCurta { get; set; }
        [Required(ErrorMessage = "A descrição detalhada da pizza deve ser informada")]
        [Display(Name = "Descrição detalhada da pizza")]
        [MinLength(20, ErrorMessage = "A descrição detalhada deve ter no mínimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "A descrição detalhada não pode exceder {1} caracteres")]
        public string DescricaoDetalhada { get; set; }
        [Required(ErrorMessage ="Informe o preço da pizza")]
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
