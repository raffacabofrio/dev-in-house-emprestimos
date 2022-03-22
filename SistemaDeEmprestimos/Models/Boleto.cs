
public class Boleto
{
    public DateTime? DataPagamento { get; set; } = null;
    public DateTime DataVencimento { get; set; }

    public float Valor { get; set; }

    public float Multa { get; set; } = 0;

    public bool Pago { get; set; } = false;

}

