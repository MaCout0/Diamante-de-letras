namespace Diamante_de_letras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variaveis do código
            char letraEscolhida;
            int espaçoInterno = -1;
            

            Console.WriteLine("Digite uma letra de A a Z: ");
            letraEscolhida = Convert.ToChar(Console.ReadLine());
            letraEscolhida = char.ToUpper(letraEscolhida);
            Console.ReadLine();
            Console.Clear();

            //parte superior
            constroiParteSuperior(letraEscolhida, ref espaçoInterno);

            espaçoInterno -= 4;
            letraEscolhida--;

            //parte inferior            
            constroiParteInferior(letraEscolhida, ref espaçoInterno);

            Console.ReadLine();
        }

        private static void constroiParteInferior(char letraEscolhida, ref int espaçoInterno)
        {
            char primeiraLetra = 'A';

            int margem = 1;

            for (char letra = letraEscolhida; letra >= primeiraLetra; letra--)
            {
                for (int i = 0; i < margem; i++)
                {
                    Console.Write(" ");
                }

                margem++;

                Console.Write(letra);

                for (int i = 0; i < espaçoInterno; i++)
                {
                    Console.Write(" ");
                }

                espaçoInterno -= 2;

                if (letra == 'A')
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(letra);
                }
            }
        }

        static void constroiParteSuperior(char letraEscolhida, ref int espaçoInterno)
        {
            char primeiraLetra = 'A';

            espaçoInterno = -1;

            int margem = letraEscolhida - primeiraLetra;

            for (char letra = 'A'; letra <= letraEscolhida; letra++)
            {
                for (int i = 0; i < margem; i++)
                {
                    Console.Write(" ");
                }

                margem--;

                Console.Write(letra);

                for (int i = 0; i < espaçoInterno; i++)
                {
                    Console.Write(" ");
                }

                espaçoInterno += 2;

                if (letra == 'A')
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(letra);
                }
            }
        }
    }
}
