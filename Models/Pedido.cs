namespace crud_entity.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("pedido")]
public record Pedido {

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id =default!;

    [Required(ErrorMessage = "Id do carro é obrigatório")]
    [Column("carroId", TypeName = "int")]
    public string carroId = default!;

    [Required(ErrorMessage = "Id do cliente é obrigatório")]
     [Column("clienteId", TypeName = "int")]

    public int clienteId =default!;
    
     [Required(ErrorMessage = "Data de locação é obrigatório")]
     [Column("dataLocacao", TypeName = "DATETIME")]

    public DateTime dataLocacao =default!;
    
    [Required(ErrorMessage = "Data de entrega é obrigatório")]
     [Column("dataEntrega", TypeName = "DATETIME")]

    public DateTime dataEntrega =default!;


}