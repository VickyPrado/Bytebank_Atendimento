using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Exceptions;
using bytebank_ATENDIMENTO.bytebank.Util;
using System;
using System.Collections;
using System.Security.AccessControl;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

#region Exemplos Arrays em C#
//TestaArrayInt();
//TestaBuscarPalavra();

void TestaArrayInt()
{
    int[] idades = new int[5];
    idades[0] = 30;
    idades[1] = 40;
    idades[2] = 17;
    idades[3] = 21;
    idades[4] = 18;

    Console.WriteLine($"O tamanho do array é: {idades.Length}");

    int acumulador = 0;
    for (int i = 0; i < idades.Length; i++)
    {
        int idade = idades[i];
        Console.WriteLine($"Índice [{i}] = {idade}");
        acumulador += idade;
    }

    int media = acumulador / idades.Length;
    Console.WriteLine($"A média de idades é: {media}");
}

void TestaBuscarPalavra()
{
    string[] arrayDePalavras = new string[5];

    for (int i = 0; i < arrayDePalavras.Length; i++)
    {
        Console.Write($"Digite a {i+1}ª palavra: ");
        arrayDePalavras[i] = Console.ReadLine();
    }

    Console.Write("Digite a palavra que deseja encontrar: ");
    var busca = Console.ReadLine();

    foreach(var palavra in arrayDePalavras)
    {
        if (palavra.Equals(busca))
        {
            Console.WriteLine($"A palavra {busca} foi encontrada.");
            break;
        }
    }
}

Array amostra = new double[5];
amostra.SetValue(5.9, 0);
amostra.SetValue(1.8, 1);
amostra.SetValue(7.1, 2);
amostra.SetValue(10, 3);
amostra.SetValue(6.9, 4);

//TestaMediana(amostra);

void TestaMediana(Array array)
{
    if((array == null) || (array.Length == 0))
    {
        Console.WriteLine("Array para cálculo mediana está vazio ou nulo.");
    }

    double[] numerosOrdenado = (double[])array.Clone();
    Array.Sort(numerosOrdenado);

    int tamanho = numerosOrdenado.Length;
    int meio = tamanho / 2;

    double mediana = (tamanho % 2 != 0) ? numerosOrdenado[meio] :
        (numerosOrdenado[meio] + numerosOrdenado[meio - 1]) / 2;
    Console.WriteLine($"Com base na amostra a mediana é: {mediana}");
        
}

void TestaArrayDeContasCorrentes()
{
    ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();
    listaDeContas.Adicionar(new ContaCorrente(874, "5679787-A"));
    listaDeContas.Adicionar(new ContaCorrente(874, "4456668-B"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    var contaDoAndre = new ContaCorrente(963, "123456-X");
    listaDeContas.Adicionar(contaDoAndre);
    //listaDeContas.ExibirLista();
    //Console.WriteLine("==============");
    //listaDeContas.Remover(contaDoAndre);
    //listaDeContas.ExibirLista();

    for(int i = 0; i < listaDeContas.Tamanho; i++)
    {
        ContaCorrente conta = listaDeContas[i];
        Console.WriteLine($"Indice [{i}] = {conta.Conta}/{conta.Numero_agencia}");
    }
}

//TestaArrayDeContasCorrentes();
#endregion

#region Exemplos de uso do List
//Generica<int> teste1 = new();
//teste1.MostrarMensagem(10);

//Generica<string> teste2 = new();
//teste2.MostrarMensagem("Olá, Mundo!");

//public class Generica<T>
//{
//    public void MostrarMensagem(T t)
//    {
//        Console.WriteLine($"Exibindo: {t}");
//    }
//}

//List<ContaCorrente> listaDeContas2 = new()
//{
//    new ContaCorrente(874, "5679787-A"),
//    new ContaCorrente(874, "4456668-B"),
//    new ContaCorrente(874, "7781438-C")
//};

//List<ContaCorrente> listaDeContas3 = new()
//{
//    new ContaCorrente(874, "5679787-E"),
//    new ContaCorrente(874, "4456668-F"),
//    new ContaCorrente(874, "7781438-G")
//};

//listaDeContas2.AddRange(listaDeContas3);
//listaDeContas2.Reverse();

//for (int i = 0; i < listaDeContas2.Count; i++)
//{
//    Console.WriteLine($"Indice: [{i}] = Conta [{listaDeContas2[i].Conta}]");
//}

//Console.WriteLine("\n\n");

//var range = listaDeContas3.GetRange(0, 1);
//for (int i = 0; i < range.Count; i++)
//{
//    Console.WriteLine($"Indice: [{i}] = Conta [{range[i].Conta}]");
//}

//Console.WriteLine("\n\n");

//listaDeContas3.Clear();
//for (int i = 0; i < listaDeContas3.Count; i++)
//{
//    Console.WriteLine($"Indice: [{i}] = Conta [{range[i].Conta}]");
//}
#endregion

List<ContaCorrente> _listaDeContas = new()
{
    new ContaCorrente(95, "123456-X"){Saldo = 100, Titular = new Cliente{Cpf = "11111", Nome = "Henrique"}},
    new ContaCorrente(95, "951258-X"){Saldo = 200, Titular = new Cliente{Cpf = "22222", Nome = "Pedro"}},
    new ContaCorrente(94, "987321-W"){Saldo = 60, Titular = new Cliente{Cpf = "33333", Nome = "Marisa"}}
};

AtendimentoCliente();
void AtendimentoCliente()
{
    try
    {
        char opcao = '0';
        while(opcao != '6')
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("===         Atendimento         ===");
        Console.WriteLine("===1 - Cadastrar Conta          ===");
        Console.WriteLine("===2 - Listar Contas            ===");
        Console.WriteLine("===3 - Remover Contas           ===");
        Console.WriteLine("===4 - Ordenar Contas           ===");
        Console.WriteLine("===5 - Pesquisar Contas         ===");
        Console.WriteLine("===6 - Sair do Sistema          ===");
        Console.WriteLine("===================================");
        Console.WriteLine("\n\n");
        Console.Write("Digite a opção desejada: ");
        try
        {
            opcao = Console.ReadLine()[0];
        }
        catch (Exception excecao)
        {
            throw new BytebankException(excecao.Message);
        }    

        switch (opcao)
        {
            case '1': CadastrarConta();
                break;
            case '2': ListarContas();
                break;
            case '3': RemoverContas();
                break;
            case '4': OrdenarContas();
                break;
            case '5': PesquisarContas();
                break;
            //case '6': Sair();
            //    Console.WriteLine("Saindo do sistema...");
            //    break;
            default:
                Console.WriteLine("Opção não implementada.");
                break;
        }
    }
    }
    catch (BytebankException excecao)
    {
        Console.WriteLine($"{excecao.Message}");
    }

}

void PesquisarContas()
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===    PESQUISAR CONTAS     ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");
    Console.Write("Deseja pesquisar por (1) NúMERO DA CONTA, (2) CPF TITULAR ou (3) NúMERO AGÊNCIA ? ");
    switch (int.Parse(Console.ReadLine()))
    {
        case 1:
            {
                Console.Write("Informe o número da Conta: ");
                string _numeroConta = Console.ReadLine();
                ContaCorrente consultaConta = ConsultaPorNumeroConta(_numeroConta);
                Console.WriteLine(consultaConta.ToString());
                Console.ReadKey();
                break;
            }
        case 2:
            {
                Console.Write("Informe o CPF do Titular: ");
                string _cpf = Console.ReadLine();
                ContaCorrente consultaCpf = ConsultaPorCPFTitular(_cpf);
                Console.WriteLine(consultaCpf.ToString());
                Console.ReadKey();
                break;                
            }
        case 3:
            {
                Console.Write("Informe o Nº da Agência: ");
                int _numeroAgencia = int.Parse(Console.ReadLine());
                var contasPorAgencia = ConsultaPorAgencia(_numeroAgencia);
                ExibirListaDeContas(contasPorAgencia);
                Console.ReadKey();
                break;
            }
        default:
            Console.WriteLine("Opção não implementada.");
            break;
    }
}

void ExibirListaDeContas(List<ContaCorrente> contasPorAgencia)
{
    if(contasPorAgencia == null)
    {
        Console.WriteLine("... A consulta não retornou dados ...");
    }
    else
    {
        foreach(var item in contasPorAgencia)
        {
            Console.WriteLine(item.ToString());            
        }
    }
}

List<ContaCorrente> ConsultaPorAgencia(int numeroAgencia)
{
    var consulta = (
            from conta in _listaDeContas
            where conta.Numero_agencia == numeroAgencia
            select conta).ToList();
    return consulta;
}

ContaCorrente ConsultaPorCPFTitular(string? cpf)
{
    return _listaDeContas.FirstOrDefault(conta => conta.Titular.Cpf == cpf);
}

ContaCorrente ConsultaPorNumeroConta(string? numeroConta)
{
    return _listaDeContas.FirstOrDefault(conta => conta.Conta == numeroConta);
}

void OrdenarContas()
{
    _listaDeContas.Sort();
    Console.WriteLine("... Lista de contas ordenadas ...");
    Console.ReadKey();
}

void RemoverContas()
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===      REMOVER CONTAS     ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");
    Console.Write("Informe o número da Conta: ");
    string numeroConta = Console.ReadLine();
    ContaCorrente conta = null;
    foreach (var item in _listaDeContas)
    {
        if (item.Conta.Equals(numeroConta))
        {
            conta = item;
        }
    }
    if (conta != null)
    {
        _listaDeContas.Remove(conta);
        Console.WriteLine("... Conta removida da lista! ...");
    }
    else
    {
        Console.WriteLine("... Conta para remoção não encontrada ...");
    }
    Console.ReadKey();
}

void ListarContas()
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===     LISTA DE CONTAS     ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");
    if (_listaDeContas.Count <= 0)
    {
        Console.WriteLine("... Não há contas cadastradas! ...");
        Console.ReadKey();
        return;
    }    
    
    foreach (ContaCorrente item in _listaDeContas)
    {
        Console.WriteLine("===  Dados da Conta  ===");
        Console.WriteLine("Número da Conta : " + item.Conta);
        Console.WriteLine("Saldo da Conta : " + item.Saldo);        
        Console.WriteLine("Titular da Conta: " + item.Titular.Nome);
        Console.WriteLine("CPF do Titular  : " + item.Titular.Cpf);
        Console.WriteLine("Profissão do Titular: " + item.Titular.Profissao);
        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        Console.ReadKey(); 
    }    
}

void CadastrarConta()
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===   CADASTRO DE CONTAS    ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");
    Console.WriteLine("=== Informe dados da conta ===");
    Console.Write("Número da conta: ");
    string numeroConta = Console.ReadLine();

    Console.Write("Número da Agência: ");
    int numeroAgencia = int.Parse(Console.ReadLine());

    ContaCorrente conta = new ContaCorrente(numeroAgencia, numeroConta);

    Console.Write("Informe o saldo inicial: ");
    conta.Saldo = double.Parse(Console.ReadLine());

    Console.Write("Informe nome do Titular: ");
    conta.Titular.Nome = Console.ReadLine();

    Console.Write("Informe CPF do Titular: ");
    conta.Titular.Cpf = Console.ReadLine();

    Console.Write("Informe Profissão do Titular: ");
    conta.Titular.Profissao = Console.ReadLine();

    _listaDeContas.Add(conta);

    Console.WriteLine("... Conta cadastrada com sucesso! ...");
    Console.ReadKey();
}
