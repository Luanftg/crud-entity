using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace crud_entity.Models;

[Table("configuracao")]
public record Configuracao {

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id =default!;

    [Required(ErrorMessage = "Dias de locação é obrigatório")]
    [Column("diasLocacao", TypeName = "int")]
    public int diasLocacao = default!;
}