namespace Models;

public class Usuario
{
    public int Id { get; set; }
    public String Nome { get; set; }
    public int Idade { get; set; }
    public String CPF { get; set; }
    public double RendaMensal { get; set; } // Calculada a partir da soma das Receitas
    public double GastoMensal { get; set; } // Calculado a partir da soma das Despesas
    public double isStable { get; set; } // Se a subtração da Renda pelo Gasto for possitivo
    public String Email { get; set; }
    public String Password { get; set; }
}