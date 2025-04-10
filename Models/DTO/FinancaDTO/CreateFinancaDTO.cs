namespace Models.DTO.FinancaDTO;

public class CreateFinancaDTO
{
    public string Identificacao { get; set; }
    public double Valor { get; set; } // Em reais (R$)
    public string Descricao { get; set; }
    public int UsuarioId { get; set; }
}