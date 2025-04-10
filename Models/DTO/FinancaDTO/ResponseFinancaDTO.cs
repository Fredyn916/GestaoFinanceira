namespace Models.DTO.FinancaDTO;

public class ResponseFinancaDTO
{
    public int Id { get; set; }
    public String Identificacao { get; set; }
    public double Valor { get; set; } // Em reais (R$)
    public String Descricao { get; set; }
    public int UsuarioId { get; set; }
}