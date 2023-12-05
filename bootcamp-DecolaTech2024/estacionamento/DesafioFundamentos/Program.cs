using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;
int opcaoInicial = 0;

bool sairPrograma = false;

Console.WriteLine("\n============================================\n" +
                  "Seja bem vindo ao sistema de estacionamento!\n" +
                  "\n     Selecione uma opção para começar:\n" +
                  "\n          1 - Iniciar sistema\n" +
                  "          2 - Instruções de uso\n" +
                  "============================================\n\n" +
                  "Digite o número da opção:");

opcaoInicial = Convert.ToInt32(Console.ReadLine());

if(opcaoInicial == 2){
    Console.WriteLine("\nAo iniciar o sistema, é necessário informar o preço inicial, que é o preço cobrado para \n" +
                      "deixar seu veículo estacionado! Após isso, é necessário informar o preço por hora, que \n" +
                      "é o preço por hora que o veículo permanecer estacionado. Em ambos casos, informar 0 irá \n" +
                      "encerrar o programa. Tendo estas informações, o sistema te permitirá navegar pelas opções: \n\n" +
                      "1 - Cadastrar veículo: adiciona um veiculo a partir da placa informada \n\n" +
                      "2 - Remover veículo: remove um veiculo cadastrado anteriormente com base na placa \n" +
                      "    informada. Ao informar quantidade de horas estacionadas, o sistema calcula o preço \n" +
                      "    total a ser pago \n\n" +
                      "3 - Listar veículos: Exibe a lista de veiculos cadastrados a partir da opção 1 \n\n" +
                      "4 - Encerrar: finaliza o sistema\n\n");

                    Console.WriteLine("Pressione uma tecla para iniciar o sistema");
                    Console.ReadLine();
}
else if(opcaoInicial == 0){
    sairPrograma = true;
}

if (!sairPrograma){
    Console.WriteLine("Digite o preço inicial:");
    precoInicial = Convert.ToDecimal(Console.ReadLine());

    if (precoInicial ==0){
    sairPrograma = true;
    }
}

if (!sairPrograma){
    Console.WriteLine("Agora digite o preço por hora:");
    precoPorHora = Convert.ToDecimal(Console.ReadLine());

    if (precoPorHora ==0){
    sairPrograma = true;
    }
}

if (!sairPrograma){
    // Instancia a classe Estacionamento, já com os valores obtidos anteriormente
    Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

    string opcao = string.Empty;
    bool exibirMenu = true;

    // Realiza o loop do menu
    while (exibirMenu)
    {
        Console.Clear();
        Console.WriteLine("Digite a sua opção:");
        Console.WriteLine("1 - Cadastrar veículo");
        Console.WriteLine("2 - Remover veículo");
        Console.WriteLine("3 - Listar veículos");
        Console.WriteLine("4 - Encerrar");

        switch (Console.ReadLine())
        {
            case "1":
                es.AdicionarVeiculo();
                break;

            case "2":
                es.RemoverVeiculo();
                break;

            case "3":
                es.ListarVeiculos();
                break;

            case "4":
                exibirMenu = false;
                break;

            default:
                Console.WriteLine("Opção inválida");
                break;
        }

        Console.WriteLine("\nPressione uma tecla para continuar");
        Console.ReadLine();
    }
}

Console.WriteLine("O programa se encerrou");
