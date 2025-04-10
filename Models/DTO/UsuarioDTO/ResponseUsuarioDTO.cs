namespace Models.DTO.UsuarioDTO;

public class ResponseUsuarioDTO
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string CPF { get; set; }
    public double RendaMensal { get; set; } // Calculada a partir da soma das Receitas
    public double GastoMensal { get; set; } // Calculado a partir da soma das Despesas
    public bool isStable { get; set; } // True se a subtração da Renda pelo Gasto resultar positivo (0 false; 1 true)
    public string Email { get; set; }
    public string Password { get; set; }
}