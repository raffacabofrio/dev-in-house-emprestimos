﻿
public class Pessoa
{
    public string Nome { get; set; } = "";
    public string Cpf { get; set; } = "";

    public override string ToString()
    {
        return $"{Nome} - {Cpf}";
    }
}

