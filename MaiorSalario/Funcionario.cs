namespace MaiorSalario
{
    class Funcionario
    {
        public string nome;
        public int idade;
        public double salario;

        public string Apresentacao()
        {
            string r = $"{this.nome} com {this.idade} anos e salário de R$ {this.salario:F2} reais.";
            return r;
        }
    }
}
