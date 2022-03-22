
public class InputHelper
{
    public static float ObterValorFloat()
    {
        float valor = 0;

        var valorInformadoValido = false;


        while (!valorInformadoValido)
        {
            var valorDigitadoString = Console.ReadLine();

            valorInformadoValido = float.TryParse(valorDigitadoString, out valor);

            if (!valorInformadoValido)
            {
                Console.WriteLine("Valor informado não é válido. Tente de novo.");
                continue;
            }


        }

        return valor;
    }


    public static int ObterValorInt()
    {
        int valor = 0;

        var valorInformadoValido = false;


        while (!valorInformadoValido)
        {
            var valorDigitadoString = Console.ReadLine();

            valorInformadoValido = int.TryParse(valorDigitadoString, out valor);

            if (!valorInformadoValido)
            {
                Console.WriteLine("Valor informado não é válido. Tente de novo.");
                continue;
            }


        }

        return valor;
    }
}

