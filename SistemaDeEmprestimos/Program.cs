
Console.WriteLine("Bem vindo ao sistema DevInLoan.");
Console.WriteLine("");

var sair = false;
var menuSelecionadoValido = false;

while (!sair)
{


    Console.WriteLine("Escolha uma opção do menu:");
    Console.WriteLine("1 - simular um emprestimo.");
    Console.WriteLine("2 - efetuar um emprestimo.");
    Console.WriteLine("3 - pagar um boleto.");
    Console.WriteLine("4 - listar contas.");
    Console.WriteLine("5 - mudar a data do sistema.");
    Console.WriteLine("6 - sair.");

    int menuSelecionado;

    menuSelecionadoValido = int.TryParse(Console.ReadLine(), out menuSelecionado);

    Console.WriteLine("");

    if (!menuSelecionadoValido)
    {
        Console.WriteLine("Opção inválida. Favor tentar de novo.");
        continue;
    }


    switch (menuSelecionado)
    {
        case 1:
            SimularEmprestimo();
            break;

        case 2:
            Console.WriteLine($"Opção de menu {menuSelecionado} não implementado ainda.");
            break;

        case 3:
            Console.WriteLine($"Opção de menu {menuSelecionado} não implementado ainda.");
            break;

        case 4:
            Console.WriteLine($"Opção de menu {menuSelecionado} não implementado ainda.");
            break;

        case 5:
            Console.WriteLine($"Opção de menu {menuSelecionado} não implementado ainda.");
            break;

        // SAIR
        case 6:
            Console.WriteLine($"Você está saindo do sistema. Adeus.");
            sair = true;
            break;

        default:
            Console.WriteLine("Escolha uma opção entre 1 e 6. Favor tentar de novo.");
            break;
    }



}



void SimularEmprestimo()
{
    Console.WriteLine("Favor informar o valor a ser emprestado:");
    float valor = InputHelper.ObterValorFloat();

    Console.WriteLine("Favor informar o número de parcelas:");
    int numParcelas = InputHelper.ObterValorInt();

    // 1 - taxa de 10% taxa da casa.
    valor = valor + (valor * 10 / 100);

    // 2 - dividir em parcelas
    var boletos = new List<Boleto>();
    var dataTmp = DateTime.Now;

    float valorParcela = valor / numParcelas;

    for (int i = 1; i<= numParcelas; i++)
    {
        dataTmp = dataTmp.AddMonths(1);

        // TODO: calcular o IGP-M em cada um dos boletos
        // Valor = Valor + juros do mês.

        boletos.Add(new Boleto
        {
            DataVencimento = dataTmp,
            Valor = valorParcela,
        });
    }

    

    Console.WriteLine("dfsadas");

}

