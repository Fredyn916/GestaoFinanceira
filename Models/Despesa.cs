using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace Models;

[Table("despesas")]
public class Despesa : BaseModel
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

    public void InverterValor() => Valor = Valor * -1;
}