﻿using ConsoleAppAula01;

internal class Program
{
    private static void Main(string[] args)
    {
        Funcionario joao = new Funcionario("João", "Eng. de Software", 25000);
        Console.WriteLine("O salario liquido do joao é: " + joao.SalarioLiquido);

    }
}