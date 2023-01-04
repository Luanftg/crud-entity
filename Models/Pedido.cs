namespace crud_entity.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("pedido")]
public record Pedido {

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id {get;set;}

    [Required(ErrorMessage = "Id do carro é obrigatório")]
    [Column("carroId", TypeName = "int")]
    public int CarroId {get;set;}= default!;

    [Required(ErrorMessage = "Id do cliente é obrigatório")]
    [Column("clienteId", TypeName = "int")]
    public int ClienteId {get;set;} =default!;
    
     [Required(ErrorMessage = "Data de locação é obrigatório")]
     [Column("dataLocacao", TypeName = "DATETIME")]

    public DateTime DataLocacao {get;set;} = default!;
    
    [Required(ErrorMessage = "Data de entrega é obrigatório")]
     [Column("dataEntrega", TypeName = "DATETIME")]
    public DateTime DataEntrega {get;set;} =default!;


}