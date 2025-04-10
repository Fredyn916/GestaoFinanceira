using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace Models;

[Table("usuarios")]
public class Usuario : BaseModel
{
    [PrimaryKey("id", false)]
    public int Id { get; set; }
    [Column("nome")]
    public String Nome { get; set; }
    [Column("idade")]
    public int Idade { get; set; }
    [Column("cpf")]
    public String CPF { get; set; }
    [Column("renda_mensal")]
    public double RendaMensal { get; set; } // Calculada a partir da soma das Receitas
    [Column("gasto_mensal")]
    public double GastoMensal { get; set; } // Calculado a partir da soma das Despesas
    [Column("is_stable")]
    public bool isStable { get; set; } // True se a subtração da Renda pelo Gasto resultar positivo (0 false; 1 true)
    [Column("email")]
    public String Email { get; set; }
    [Column("password")]
    public String Password { get; set; }
}