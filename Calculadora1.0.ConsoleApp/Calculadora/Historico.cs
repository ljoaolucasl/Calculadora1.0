namespace Calculadora1._0.ConsoleApp.Calculadora
{
    public class Historico
    {
        private List<string> historico;

        public Historico()
        {
            historico = new List<string>();
        }

        public void AdicionarHistorico(string calculo)
        {
            historico.Add(calculo);
        }

        public void LimparHistorico()
        {
            historico.Clear();
        }

        public void ImprimirHistorico()
        {
            Console.WriteLine("================= Histórico de cálculos: =================");

            foreach (string calculo in historico)
            {
                Console.WriteLine($"{calculo}");
            }
        }
    }
}
