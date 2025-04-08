using Dapper.Contrib.Extensions;

namespace Models;

[Table("Receitas")]
public class Receita
{
    [Key]
    public int Id { get; set; }
    public String Identificacao { get; set; }
    public double Valor { get; set; } // Em reais (R$)
    public String Descricao { get; set; }
    public bool isMonthly { get; set; } // True se for mensalmente fixa (0 false; 1 true)
    public int UsuarioId { get; set; }
}