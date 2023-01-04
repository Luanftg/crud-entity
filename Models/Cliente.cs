using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace crud_entity.Models;



[Table("cliente")]
public record Cliente {

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id {get;set;}

    [Required(ErrorMessage = "Nome é obrigatório")]
    [Column("nome", TypeName = "varchar(100)")]
    public string Nome {get;set;} = default!;

    [Required(ErrorMessage = "Email da marca é obrigatório")]
    [Column("email", TypeName = "varchar(100)")]
    public string Email {get;set;} = default!;
    
    [Required(ErrorMessage = "Telefone da marca é obrigatório")]
    [Column("telefone", TypeName = "varchar(100)")]
    public string Telefone {get;set;} =default!;
    
    [Required(ErrorMessage = "Endereço da marca é obrigatório")]
    [Column("endereco", TypeName = "text")]
    public string Endereco {get;set;} = default!;
   

}