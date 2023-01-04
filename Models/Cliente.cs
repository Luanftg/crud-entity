namespace crud_entity.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("cliente")]
public record Cliente {

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id =default!;

    [Required(ErrorMessage = "Nome é obrigatório")]
    [Column("nome", TypeName = "varchar(100)")]
    public string name = default!;

    [Required(ErrorMessage = "email da marca é obrigatório")]
    public string email =default!;
    
    [Required(ErrorMessage = "Telefone da marca é obrigatório")]
    public string telefone =default!;
    
    [Required(ErrorMessage = "Endereço da marca é obrigatório")]
    [Column("endereco", TypeName = "text")]
    public string endereco =default!;
   

}