namespace crud_entity.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("carro")]
public record Carro {

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id{get;set;}

    [Required(ErrorMessage = "Nome é obrigatório")]
    [Column("nome", TypeName = "varchar(100)")]
    public string Nome {get;set;} = default!;

    [Required(ErrorMessage = "Id da marca é obrigatório")]
    public int MarcaId {get;set;} 
    [Required(ErrorMessage = "Id do modelo é obrigatório")]
    public int ModeloId {get;set;}

}