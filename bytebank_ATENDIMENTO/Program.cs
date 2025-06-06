﻿using bytebank_ATENDIMENTO.bytebank.Atendimento;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");
new ByteBankAtendimento().AtendimentoCliente();

#region Exemplos Arrays em C#
//TestaArrayInt();
//TestaBuscarPalavra();

//void TestaArrayInt()
//{
//    int[] idades = new int[5];
//    idades[0] = 30;
//    idades[1] = 40;
//    idades[2] = 17;
//    idades[3] = 21;
//    idades[4] = 18;

//    Console.WriteLine($"O tamanho do array é: {idades.Length}");

//    int acumulador = 0;
//    for (int i = 0; i < idades.Length; i++)
//    {
//        int idade = idades[i];
//        Console.WriteLine($"Índice [{i}] = {idade}");
//        acumulador += idade;
//    }

//    int media = acumulador / idades.Length;
//    Console.WriteLine($"A média de idades é: {media}");
//}

//void TestaBuscarPalavra()
//{
//    string[] arrayDePalavras = new string[5];

//    for (int i = 0; i < arrayDePalavras.Length; i++)
//    {
//        Console.Write($"Digite a {i+1}ª palavra: ");
//        arrayDePalavras[i] = Console.ReadLine();
//    }

//    Console.Write("Digite a palavra que deseja encontrar: ");
//    var busca = Console.ReadLine();

//    foreach(var palavra in arrayDePalavras)
//    {
//        if (palavra.Equals(busca))
//        {
//            Console.WriteLine($"A palavra {busca} foi encontrada.");
//            break;
//        }
//    }
//}

//Array amostra = new double[5];
//amostra.SetValue(5.9, 0);
//amostra.SetValue(1.8, 1);
//amostra.SetValue(7.1, 2);
//amostra.SetValue(10, 3);
//amostra.SetValue(6.9, 4);

//TestaMediana(amostra);

//void TestaMediana(Array array)
//{
//    if((array == null) || (array.Length == 0))
//    {
//        Console.WriteLine("Array para cálculo mediana está vazio ou nulo.");
//    }

//    double[] numerosOrdenado = (double[])array.Clone();
//    Array.Sort(numerosOrdenado);

//    int tamanho = numerosOrdenado.Length;
//    int meio = tamanho / 2;

//    double mediana = (tamanho % 2 != 0) ? numerosOrdenado[meio] :
//        (numerosOrdenado[meio] + numerosOrdenado[meio - 1]) / 2;
//    Console.WriteLine($"Com base na amostra a mediana é: {mediana}");

//}

//void TestaArrayDeContasCorrentes()
//{
//    ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();
//    listaDeContas.Adicionar(new ContaCorrente(874, "5679787-A"));
//    listaDeContas.Adicionar(new ContaCorrente(874, "4456668-B"));
//    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
//    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
//    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
//    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
//    var contaDoAndre = new ContaCorrente(963, "123456-X");
//    listaDeContas.Adicionar(contaDoAndre);
//listaDeContas.ExibirLista();
//Console.WriteLine("==============");
//listaDeContas.Remover(contaDoAndre);
//listaDeContas.ExibirLista();

//    for(int i = 0; i < listaDeContas.Tamanho; i++)
//    {
//        ContaCorrente conta = listaDeContas[i];
//        Console.WriteLine($"Indice [{i}] = {conta.Conta}/{conta.Numero_agencia}");
//    }
//}

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