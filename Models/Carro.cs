namespace crud_entity.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("carro")]
public record Carro {

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id =default!;

    [Required(ErrorMessage = "Nome é obrigatório")]
    [Column("nome", TypeName = "varchar(100)")]
    public string name = default!;

    [Required(ErrorMessage = "Id da marca é obrigatório")]
    public int marcaId =default!;
    [Required(ErrorMessage = "Id do modelo é obrigatório")]
    public int modeloId =default!;

}