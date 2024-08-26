/*-------------------------------------------------------------------
Questão 1: Seleção de Armadura
* Contextualização: Em um jogo de RPG, cada classe de personagem (Guerreiro, Arqueiro, Mago)
possui requisitos diferentes para a escolha da armadura ideal. A armadura é considerada ideal
se a defesa oferecida for alta o suficiente para a classe e se a penalidade de agilidade for
aceitável.
* Comando:
Crie um programa que receba a classe do personagem, o valor de defesa da armadura e a
penalidade de agilidade. O programa deve informar se a armadura é adequada ou não para a
classe.
* Para o Guerreiro, a defesa deve ser maior que 50 e a penalidade de agilidade menor que 20.
* Para o Arqueiro, a defesa deve ser maior que 30 e a penalidade de agilidade menor que 10.
* Para o Mago, a defesa deve ser maior que 20 e a penalidade de agilidade menor que 40.
@Lista: 02 - Condicionais
@Autor: Lucas Amaral Gonçalves
@Data: 20/08/2024
---------------------------------------------------------------------*/

using System;

class Program
{
    public static void Main(string[] args)
    {
        string? classes;
        int defensor,penalizacao;
        Console.WriteLine ("Qual a classe do player?");
        classes =Console.ReadLine();
        Console.WriteLine ("Quanto vai ser a defesa do seu player? ");
        int.TryParse(Console.ReadLine(),out defensor);
          Console.WriteLine ("Quanto vai ser a penalizacao que seu player vai receber? ");
        int.TryParse(Console.ReadLine(),out penalizacao);
        if(classes=="guerreiro")
        {
             if(defensor>50 & penalizacao<20)
             { 
            Console.WriteLine("Armadura adequada");
             }
             else
             { 
                Console.WriteLine("Armadura não adequada");
             }
    }
    if(classes=="arqueiro")
    {
             if(defensor>30 && penalizacao<10)
             { 
            Console.WriteLine("Armadura adequada");
             }
             else
             { 
                Console.WriteLine("Armadura inadequada");
             }
    }
    if(classes=="mago")
    {
             if(defensor>20 && penalizacao<40)
             { 
            Console.WriteLine("Armadura adequada");
             }
             else
             {
                Console.WriteLine("Armadura inadequada");
             }
    }
    }
}
