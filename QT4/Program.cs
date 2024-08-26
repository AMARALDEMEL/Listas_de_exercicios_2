/*-------------------------------------------------------------------
Questão 4: Decisão de Ataque Especial
* Contextualização: Durante uma batalha em um jogo de RPG, o jogador pode realizar um ataque
especial se tiver mana suficiente, se a vida do inimigo estiver baixa e se o nível do jogador for
alto o bastante.
* Comando: Crie um programa que determine se o jogador deve realizar um ataque especial. O
programa deve receber a quantidade de mana do jogador, a vida atual do inimigo em
porcentagem e o nível do jogador. As condições para realizar o ataque especial são:
* Mana maior que 30.
* Vida do inimigo menor que 50%.
* Nível do jogador maior que 5.


@Lista: 02 - Condicionais
@Autor: Lucas Amaral
@Data: 23/08/2024
---------------------------------------------------------------------*/

using System;

class Program
{
    public static void Main(string[] args)
    {
        int m, v, n;
        
        Console.WriteLine ("Informe a quantidade de mana do jogador:");
        int.TryParse(Console.ReadLine(), out m);
        
        Console.WriteLine ("Informe a quantidade de vida do inimigo:");
        int.TryParse(Console.ReadLine(), out v);
        
        Console.WriteLine ("Informe o nivel do seu jogador:");
        int.TryParse(Console.ReadLine(), out n);
        
        if(m > 30 && v < 50 && n > 5)
        {
            Console.WriteLine("Ataque Especial realizado");
        }
         if(m < 30 && v < 50 && n > 5)
        {
            Console.WriteLine("Mana insuficiente");
        }
         if(m > 30 && v > 50 && n > 5)
        {
            Console.WriteLine("Vida do inimigo muito alta");
        }
         if(m > 30 && v < 50 && n < 5)
        {
            Console.WriteLine("Nivel insuficiente");
        }
      
    }
}