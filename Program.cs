
var exibirMenu = true;

while (exibirMenu)
{
    SetCabecalhoApp();

    switch (GetMenuOpcao())
    {
        case 1:
            GetMelhorCombustivel();
            exibirMenu = Continuar();
            break;
        default:
            break;
    }

}


static void SetCabecalhoApp()
{
    Console.Clear();
    Console.WriteLine("Bem-vindo ao Power Consumo Blaster 1.0, seu verme insolente\n");
    Console.WriteLine("----------- SELECIONE UMA OPÇÃO --------------\n");
    Console.WriteLine("1 - Qual combustível devo utilizar");
    Console.WriteLine("2 - Alguma função a mais, um PLUS");
    Console.WriteLine("3 - Sair\n");
    Console.WriteLine("-----------------------------------------------\n");

}


static bool Continuar()
{
    Console.WriteLine("----------- SELECIONE UMA OPÇÃO --------------\n");
    Console.WriteLine("1 - Retornar ao MENU");
    Console.WriteLine("0 - Sair da Aplicação\n");
    Console.WriteLine("-----------------------------------------------\n");

    switch (GetMenuOpcao())
    {
        case 1:
            return true;
        default:
            return false;
    }

}

// função para permitir que o usuário digite apenas número

static int GetMenuOpcao()
{
    int val = 0;
    string num = "";
    Console.Write("Digite sua opção: ");
    ConsoleKeyInfo chr;
    do
    {
        chr = Console.ReadKey(true);
        if (chr.Key != ConsoleKey.Backspace)
        {
            bool control = int.TryParse(chr.KeyChar.ToString(), out val);
            if (control)
            {
                num += chr.KeyChar;
                Console.Write(chr.KeyChar);
            }
        }
        else

        {
            if (chr.Key == ConsoleKey.Backspace && num.Length > 0)
            {
                num = num.Substring(0, (num.Length - 1));
                Console.Write("\b \b");
            }
        }
    }
    while (chr.Key != ConsoleKey.Enter);
    //Console.ReadKey();
    return int.Parse(num);
}


static void GetMelhorCombustivel()
{
    var precoGasolina = 0.0;
    var precoAlcool = 0.0;

    Console.Write("\n\nDigite o valor da GASOLINA: ");
    double.TryParse(Console.ReadLine(), out precoGasolina);

    Console.Write("\nDigite o valor do ALCOOL: ");
    double.TryParse(Console.ReadLine(), out precoGasolina);

    var relacaoConsumo = precoAlcool / precoGasolina;

    if (relacaoConsumo > 0.7)
    {
        Console.WriteLine("\nÉ mais vantajoso abastecer com GASOLINA!!!\n");
        return;
    }

    if (relacaoConsumo < 0.7)
    {
        Console.WriteLine("\nÉ mais vantajoso abastecer com ÁLCOOL!!!\n");
        return;
    }

    Console.WriteLine("O abastecimento pode ser realizado tanto com GASOLINA como com ÁLCOOL\n");

}

