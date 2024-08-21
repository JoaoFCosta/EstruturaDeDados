﻿using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {

        //Trabalhando com Lista (List)

        List<string> frutas = new List<string>();

        //Adicionar itens na Lista
        frutas.Add("Morango");
        frutas.Add("Manga");
        frutas.Add("Goiaba");
        frutas.Add("Uva");

        //Imprimindo os itens da Lista
        frutas.ForEach(Console.WriteLine);

        //Imprimindo elementos no indice específica
        Console.WriteLine();
        Console.WriteLine("Fruta no indice 2: " + frutas[2]);

        //Inserir um elemento no indice específica

        frutas.Insert(1, "Maracuja");

        Console.WriteLine();

        //Imprimindo a lista novamente

        frutas.ForEach(Console.WriteLine);

        //Alterando um elemento ja existente no indice específico

        frutas[4] = "Pêra";

        Console.WriteLine();

        //Imprimindo a lista novamente
        frutas.ForEach(Console.WriteLine);

        //Removendo um elemento da lista no indice específico

        frutas.RemoveAt(3);
        Console.WriteLine();
        //Removendo elementos pelo valor do conteúdo

        frutas.Remove("Morango");

        //Imprimindo a lista novamente
        frutas.ForEach(Console.WriteLine);

        //Apagar todos os elementos da Lista

        frutas.Clear();

        Console.WriteLine();



        //Trabalhando com Dicionário (Dictionary)

        //Criando um Dicionário de Dados
        Dictionary<int, string> carros = new Dictionary<int, string>();
        //Adicionar Dados a um Dicionário
        carros.Add(5, "Corsa");
        carros.Add(10, "Fusca");
        carros.Add(2, "Forda Ka");

        //Imprimindo um Dicionário de Dados

        foreach (var carro in carros)
        {
            Console.WriteLine($"{carro.Key} - {carro.Value}");
        }
    }
}