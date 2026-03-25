﻿using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;
using ConsoleApp1;
using ConsoleAppAula01;

internal class Program
{
    private static void Main(string[] args)
    {
        Funcionario andre = new Funcionario("Andre", 50000);
        andre.Cargo.Codigo = 444;
        andre.Cargo.Descricao = "Dono";

        Funcionario joao = new Funcionario("João", 25000);
        joao.Cargo.Codigo = 123456;
        joao.Cargo.Descricao = "Eng. de Software";

        CargoInfo cargoProgramador = new CargoInfo();
        cargoProgramador.Codigo = 123;
        cargoProgramador.Descricao = "Dev";

        Funcionario pedro = new Funcionario("Pedro", 5000);
        pedro.Cargo = cargoProgramador;

        Funcionario maria = new Funcionario("Maria", 5000);
        maria.Cargo = cargoProgramador;

        Funcionario paulo = new Funcionario("Paulo", 10000);
        paulo.Cargo.Codigo = 777;
        paulo.Cargo.Descricao = "Gerente Adm.";
        Console.WriteLine("Batata");
    }
}