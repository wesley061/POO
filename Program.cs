using POO.Banco;
using POO.Confeccao;

namespace POO{

    class Program
    {
        static void Main(string[] args)
        {
            Funcionario joao = new Funcionario();
            joao.SetNome("João");
            joao.SetSalario(2000);

            Diretor maria = new Diretor("Maria", 5000);

            Console.WriteLine("Bonificacao Joao: " + joao.GetBonificacao());
            Console.WriteLine("Bonificacao Maria: " + maria.GetBonificacao());
        }
    }
}