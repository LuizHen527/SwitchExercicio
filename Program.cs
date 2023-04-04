// - (cwl)Escolha sua bebida:
// - (opcoes):
// 	-Guarana
// 	-Coca-cola
// 	-Agua
// 	-Cerveja
// - (crl) 
// - (cwl)Gostaria de acrecentar gelo? ('s' para sim, 'n' para nao)
// - (crl)
// - (cwl)cSua bebida esta sendo feita ...

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(@$"
Escolha sua bebida:
- Guarana (digite 'G')
- Coco-cola (digite 'C')
- Agua (digite 'A')
- Cerveja (digite 'F')
");

        char bebida = char.Parse(Console.ReadLine().ToUpper());

        switch (bebida)
        {
            case 'G':
            Console.WriteLine($"Voce escolheu Guarana. Gostaria de adicionar gelo? ('s' para sim, 'n' para nao)");
            char gelo = char.Parse(Console.ReadLine().ToLower());
            if (gelo == 's')
            {
                Console.WriteLine($"Colocarei gelo. Sua bebida esta sendo feita ...");
            }
            else
            {
                Console.WriteLine($"Sua bebida esta sendo feita ...");
                
            }
            break;

            case 'C':
            Console.WriteLine($"Voce escolheu Coca-cola. Gostaria de adicionar gelo? ('s' para sim, 'n' para nao)");
            char gelo2 = char.Parse(Console.ReadLine().ToLower());
            if (gelo2 == 's')
            {
                Console.WriteLine($"Colocarei gelo. Sua bebida esta sendo feita ...");
            }
            else
            {
                Console.WriteLine($"Sua bebida esta sendo feita ...");
            }
            break;

            case 'A':
            Console.WriteLine($"Voce escolheu Agua, a melhor bebida. Gostaria de adicionar gelo? ('s' para sim, 'n' para nao)");
            char gelo3 = char.Parse(Console.ReadLine().ToLower());
            if (gelo3 == 's')
            {
                Console.WriteLine($"Colocarei gelo. Sua bebida esta sendo feita ...");
            }
            else
            {
                Console.WriteLine($"Sua bebida esta sendo feita ...");
                
            }
            break;

            case 'F':
            Console.WriteLine($"Voce escolheu Agua, a melhor bebida. Gostaria de adicionar gelo? ('s' para sim, 'n' para nao)");
            char gelo4 = char.Parse(Console.ReadLine().ToLower());
            if (gelo4 == 's')
            {
                Console.WriteLine($"Colocarei gelo. Sua bebida esta sendo feita ...");
            }
            else
            {
                Console.WriteLine($"Sua bebida esta sendo feita ...");
            }
            break;
            
            default:
            Console.WriteLine($"Nao foi possivel ler esse comando");
            break;
            
        }
    }
}