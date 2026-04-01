using System.Diagnostics;
using System.Net.NetworkInformation;
using SistemaGestaoEventos;

internal class Program
{
    private static Local CadastrarLocal()
    {
        Console.WriteLine("Informe o nome do local: ");
        var nomeLocal = Console.ReadLine();
        Console.WriteLine("Informe o endereco do local: ");
        var enderecoLocal = Console.ReadLine();
        Console.WriteLine("Informe a capacidade");
        var capacidade = Console.ReadLine();
        Local local = new Local();
        local.Nome = nomeLocal;
        local.Endereco = enderecoLocal;
        local.Capacidade = int.Parse(capacidade);
        return local;
    }

    private static Palestrante CadastrarPalestrante()
    {
        Console.WriteLine("Informe o nome: ");
        var nome = Console.ReadLine();
        Console.WriteLine("Informe o telefone: ");
        var telefone = Console.ReadLine();
        System.Console.WriteLine("Informe o email: ");
        var email = Console.ReadLine();
        System.Console.WriteLine("Informe o Valor Hora em R$: ");
        var valorHora = Console.ReadLine();
        
        Palestrante palestrante = new Palestrante();
        palestrante.Id = Guid.NewGuid().ToString();
        palestrante.Nome = nome;
        palestrante.Email = email;
        palestrante.Telefone = telefone;
        palestrante.ValorHora = decimal.Parse(valorHora);

        return palestrante;
    }
    private static Participante CadastrarParticipante()

    {
        Console.WriteLine("Informe o nome: ");
        var nome = Console.ReadLine();
        Console.WriteLine("Informe o telefone: ");
        var telefone = Console.ReadLine();
        System.Console.WriteLine("Informe o email: ");
        var email = Console.ReadLine();
        Console.WriteLine("Informe o CPF:");
        var cpf = Console.ReadLine();

        Participante participante = new Participante();
        participante.Id = Guid.NewGuid().ToString();
        participante.Nome = nome;
        participante.Email = email;
        participante.Telefone = telefone;
        participante.CPF = cpf;

        return participante;

    }

    public static Evento CadastrarEvento()
    {
        Console.WriteLine("Informe a hora de início:");
        var inicio = Console.ReadLine();
        Console.WriteLine("Informe a hora do fim:");
        var fim = Console.ReadLine();
        
        Console.WriteLine("Escolha um local informando o numero dele:");
        locais.Listar();

        int localEscolhido = int.Parse(Console.ReadLine());

        var novoEvento = new Evento();

        Evento evento = new Evento();
        novoEvento.Id = Guid.NewGuid().ToString();
        novoEvento.Inicio = DateTime.Parse(inicio);
        novoEvento.Fim = DateTime.Parse(fim);
        
        novoEvento.Local = locais.Obter(localEscolhido - 1);

        return novoEvento;
    }


    static MeuTipo[] AdicionarNoVetor<MeuTipo>(MeuTipo novo, MeuTipo[] existentes)
    {
        MeuTipo[] novoVetor = new MeuTipo[existentes.Length + 1];

        int cont;
        for ( cont = 0; cont < existentes.Length - 1; cont++)
        {
            novoVetor[cont] = existentes[cont];
        }

        novoVetor[novoVetor.Length - 1] = novo;
        return novoVetor;
    }

    static void Listar<TipoDoObjeto>(TipoDoObjeto[] meuVetor) where TipoDoObjeto : EntidadeComID
    {
        for(int i = 0; i <= meuVetor.Count(); i++)
        {
            Console.WriteLine($"{i + 1}) {meuVetor[i].ObterDescricao()}");
        }
    }

    private static Palestra CadastrarPalestra()
    {
        Console.WriteLine("Informe o titulo");
        var titulo = Console.ReadLine();

        Palestra palestra = new Palestra();
        palestra.Titulo = titulo;
        return palestra;
    }
    
    static MeusLocais locais = new MeusLocais();
    static MeusEventos eventos = new MeusEventos();
    private static void Main(string[] args)
    {
        Local localDoEvento;
        Evento evento;
        Palestra palestra;
        MeusPalestrantes palestrantes = new MeusPalestrantes();
        MeusParticipantes participantes = new MeusParticipantes();
        MinhasPalestras palestras = new MinhasPalestras();

        Console.WriteLine("Sistema de Gestão de Eventos");
        int opcao = 0;
        do
        {
            Console.WriteLine("10 - Cadastrar Local");
            Console.WriteLine("20 - Cadastrar Participante");
            Console.WriteLine("21 - Listar Participantes");
            Console.WriteLine("30 - Cadastrar Palestrante");
            Console.WriteLine("31 - Criar Palestra");
            Console.WriteLine("32 - Listar Palestrantes");
            Console.WriteLine("33 - Listar Palestras");
            Console.WriteLine("40 - Criar Evento");
            Console.WriteLine("41 - Listar Eventos");
            Console.WriteLine("99 - Sair do sistema");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 10)
            {
                localDoEvento = CadastrarLocal();
            }

            else if (opcao == 20)
            {
                var novoParticipante = CadastrarParticipante();
                participantes.Adicionar(novoParticipante);
            }

            else if (opcao == 21)
            {
                participantes.Listar();
            }

            else if (opcao == 30)
            {
                var novoPalestrante = CadastrarPalestrante();
                palestrantes.Adicionar(novoPalestrante);
            }

            else if (opcao == 31)
            {
                CadastrarPalestra();
            }
            else if (opcao == 32)
            {
                palestrantes.Listar();
            }
            else if (opcao == 33)
            {
                palestras.Listar();
            }

            else if (opcao == 40)
            {
                eventos.Adicionar(CadastrarEvento());
            }

            else if(opcao == 41)
            {
                eventos.Listar();
            }
        }while(opcao != 99);
    }
}