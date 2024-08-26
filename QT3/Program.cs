/*-------------------------------------------------------------------
Questão 3: Loja de Poções
* Contextualização: Em uma loja de poções mágicas, o jogador pode comprar poções que
aumentam sua vida, mana ou resistência. O preço das poções é fixo: Vida custa 10 moedas,
Mana custa 15 moedas, e Resistência custa 20 moedas. Dependendo da classe do jogador, há
um desconto aplicável.
* Comando: Crie um programa que receba a classe do jogador (Guerreiro, Mago, Paladino), o tipo
de poção (Vida, Mana, Resistência), e a quantidade que deseja comprar. Calcule o preço total
das poções, aplicando o desconto correspondente:
* Guerreiro recebe 10% de desconto na compra de poções de Vida.
* Mago recebe 15% de desconto na compra de poções de Mana.
* Paladino recebe 20% de desconto na compra de poções de Resistência.
* Exiba o preço total com e sem desconto.
@Lista: 02 - Condicionais
@Autor: Lucas Amaral Goçalves 
@Data: 23/08/2024
---------------------------------------------------------------------*/

using System;

class Program
{
    public static void Main(string[] args)
    {
            string classes, tipoPocao;
            int quantidade, resultados;
            double totais;
            
        Console.WriteLine ("Informe a classe do seu player (guerreiro, mago ou paladino): ");
        classes = Console.ReadLine();
        
        Console.WriteLine ("Informe o tipo de pocao que voce deseja comprar (vida, mana ou resistencia): ");
        tipoPocao = Console.ReadLine();
        
        Console.WriteLine ("Informe qual a quantidade de poções que você deseja: ");
        int.TryParse(Console.ReadLine(), out quantidade);
        
        if(tipoPocao == "vida")
        {
            resultados = 10 * quantidade;
            Console.WriteLine($"Resultado sem desconto:{resultados}");
        }
        if(tipoPocao == "mana")
        {
        resultados = 15 * quantidade;
        Console.WriteLine($"Resultado sem desconto:{resultados}");
        }
         if(tipoPocao == "resistencia")
        {
        resultados = 20 * quantidade;
        Console.WriteLine($"Resultado sem desconto :{resultados}");
        }
        if(classes == "guerreiro" && tipoPocao == "vida")
        {
            resultados = (10 * quantidade);
            totais = resultados - (resultados * 0.1);
            Console.WriteLine($"Resultado sem desconto:{resultados}");
            Console.WriteLine($"Resultado com desconto:{totais}");
        }
        if(classes == "mago" && tipoPocao == "mana")
        {
            resultados = (15 * quantidade);
            totais = resultados - (resultados * 0.15);
             Console.WriteLine($"Resultado sem desconto:{resultados}");
            Console.WriteLine($"Resultado com desconto:{totais}");
        }
        if(classes == "paladino" && tipoPocao == "resistencia")
        {
            resultados = (20 * quantidade);
           totais = resultados - (resultados * 0.2);
             Console.WriteLine($"Resultado sem desconto:{resultados}");
           Console.WriteLine($"Resultado com desconto:{totais}");
        }
     }
}