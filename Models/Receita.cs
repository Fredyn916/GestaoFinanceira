using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace Models;

[Table("receitas")]
public class Receita : BaseModel
{
    [PrimaryKey("id", false)]
    public int Id { get; set; }
    [Column("identificacao")]
    public String Identificacao { get; set; }
    [Column("valor")]
    public double Valor { get; set; } // Em reais (R$)
    [Column("descricao")]
    public String Descricao { get; set; }
    [Column("usuario_id")]
    public int UsuarioId { get; set; }
}