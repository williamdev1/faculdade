namespace app;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá, Qual seu idioma? / Hola, que idioma hablas?");
        Console.WriteLine(" 1 - Português");
        Console.WriteLine(" 2 - Español");
        int cod = int.Parse(Console.ReadLine());

        IMenu menu;
        if (cod == 1)
        {
            menu = new Menupt();
        }
        else
        {
            menu = new Menues();
        }
        Console.WriteLine(menu.prato1());
        Console.WriteLine(menu.prato2());
        Console.WriteLine(menu.prato3());
    }
}   