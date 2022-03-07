using System;

namespace NomeVogal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int  vogais = 0, consoantes = 0;

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();

            nome = nome.ToLower();
            nome = nome.Replace(" ", "");

            for(int i = 0; i < nome.Length; i++)
            {
                if(nome[i] =='a'|| nome[i] == 'e' || nome[i] == 'i' || nome[i] == 'o' || nome[i] == 'u')
                {
                    vogais++;
                }
                else
                {
                    consoantes++;
                }
            }
            Console.WriteLine("Quantidade de Vogais = {0} e Quantidade de Consoantes = {1}", vogais, consoantes);

        }
    }
}
