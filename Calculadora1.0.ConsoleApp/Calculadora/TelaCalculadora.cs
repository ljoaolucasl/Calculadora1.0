using System;

namespace Calculadora1._0.ConsoleApp.Calculadora
{
    public class TelaCalculadora
    {
        private Calculo calculo = new Calculo();
        private Historico historico = new Historico();

        public TelaCalculadora()
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();

                MostrarCabecalho(50, "Calculadora", ConsoleColor.DarkYellow);
                Console.WriteLine();
                Console.WriteLine("Digite 1 para Somar");
                Console.WriteLine("Digite 2 para Subtrair");
                Console.WriteLine("Digite 3 para Multiplicar");
                Console.WriteLine("Digite 4 para Dividir");
                Console.WriteLine("Digite 5 para Visualizar Histórico");
                Console.WriteLine();
                Console.WriteLine("Digite S para Sair");

                string opcao = Console.ReadLine();

                switch (opcao.ToUpper())
                {
                    case "1": EscolherSoma(); break;
                    case "2": EscolherSubtracao(); break;
                    case "3": EscolherMultiplicacao(); break;
                    case "4": EscolherDivisao(); break;
                    case "5": VisualizarHistorico(); break;
                    case "S": continuar = false;  break;
                }
            }
        }

        private void VisualizarHistorico()
        {
            Console.ReadLine();
        }

        private void EscolherSoma()
        {
            double[] numeros = ObterNumeros();

            double resultado = 2;//calculo.Somar(numeros[0], numeros[1]);

            historico.AdicionarHistorico($"{numeros[0]} + {numeros[1]} = {resultado}");
        }

        private void EscolherSubtracao()
        {
            double[] numeros = ObterNumeros();

            double resultado = 2;//calculo.Subtrair(numeros[0], numeros[1]);

            historico.AdicionarHistorico($"{numeros[0]} - {numeros[1]} = {resultado}");
        }

        private void EscolherMultiplicacao()
        {
            double[] numeros = ObterNumeros();

            double resultado = 2;//calculo.Multiplicar(numeros[0], numeros[1]);

            historico.AdicionarHistorico($"{numeros[0]} x {numeros[1]} = {resultado}");
        }

        private void EscolherDivisao()
        {
            double[] numeros = ObterNumeros();

            double resultado = 2;//calculo.Dividir(numeros[0], numeros[1]);

            historico.AdicionarHistorico($"{numeros[0]} / {numeros[1]} = {resultado}");
        }

        private double[] ObterNumeros()
        {
            double[] numeros = new double[2];

            numeros[0] = VerificarNumero("Digite o primeiro número: ");
            numeros[1] = VerificarNumero("Digite o segundo número: ");

            return numeros;
        }

        private double VerificarNumero(string mensagem)
        {
            bool validaNumero;
            string entrada;
            double numero;

            do
            {
                Console.Write(mensagem);

                entrada = Console.ReadLine();

                validaNumero = double.TryParse(entrada, out numero);

                if (!validaNumero)
                {
                    MensagemColor("Atenção, apenas números\n", ConsoleColor.Red);
                }

            } while (!validaNumero);

            return numero;
        }

        private void MostrarCabecalho(int espaco, string texto, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine("╔" + "".PadRight(espaco, '═') + "╗");
            Console.WriteLine("║" + CentralizarTexto(espaco, texto) + "║");
            Console.WriteLine("╚" + "".PadRight(espaco, '═') + "╝");
            Console.WriteLine();
            Console.ResetColor();
        }

        private string CentralizarTexto(int espaco, string texto)
        {
            int calculoLeft = (espaco + texto.Length) / 2;

            string textoCentralizado = $"{texto.PadLeft(calculoLeft, ' ').PadRight(espaco, ' ')}";

            return textoCentralizado;
        }

        private void MensagemColor(string mensagem, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.Write(mensagem);
            Console.ResetColor();
        }
    }
}
