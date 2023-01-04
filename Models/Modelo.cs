namespace crud_entity.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("modelo")]
public record Modelo {

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id =default!;

    [Required(ErrorMessage = "Nome é obrigatório")]
    [Column("name", TypeName = "varchar(100)")]
    public string name = default!;
}