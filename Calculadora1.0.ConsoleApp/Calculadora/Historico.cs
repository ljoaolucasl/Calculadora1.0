namespace Calculadora1._0.ConsoleApp.Calculadora
{
    public class Historico
    {
        private List<string> historico;

        public List<string> AcessarHistorico => historico;

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
    }
}
