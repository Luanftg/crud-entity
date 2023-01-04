namespace crud_entity.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
[Table("marca")]
public record Marca {

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id {get;set;}

    [Required(ErrorMessage = "Nome é obrigatório")]
    [Column("name", TypeName = "varchar(100)")]
    public string Nome {get;set;} = default!;
}