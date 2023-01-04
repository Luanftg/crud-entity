using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace crud_entity.Models;

[Table("configuracao")]
public record Configuracao {

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id {get;set;}

    [Required(ErrorMessage = "Dias de locação é obrigatório")]
    [Column("diasLocacao", TypeName = "int")]
    public int DiasLocacao {get;set;} = default!;
}