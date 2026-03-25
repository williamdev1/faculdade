using System;
using ConsoleApp1;

namespace ConsoleAppAula01;

public class Funcionario
{
    public Funcionario(String nome, decimal salarioBruto)
    {
        Cargo = new CargoInfo();
        Nome = nome;
        SalarioBruto = salarioBruto; 
        GerarSalarioLiquido(); 
    }

    public String Nome { get; set; }
    public decimal SalarioBruto { get; set; }
    public CargoInfo Cargo {get; set;}
    public decimal SalarioLiquido { get; private set;}

    public decimal GerarSalarioLiquido()
    {
        DescontarINSS();
        DescontarIR();
        ContribuirFGTS();

        return SalarioLiquido;
    }

    private void DescontarINSS()
    {
        if (SalarioBruto <= 1518)
        {
            SalarioLiquido = SalarioBruto * 0.925m;
        }
        
    }

}
