
public class Emprestimo
{
    public DateTime DataEmprestimo { get; set; }
    public float TotalEmprestado { get; set; }
    public float Saldo { get; set; }

    public Pessoa Cliente { get; set; }

    public List<Boleto> Boletos { get; set; }
}

