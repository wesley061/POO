namespace POO{
    public class Funcionario{
        protected string nome;
        protected double salario;

        public string GetNome(){
            return nome;
        }

        public void SetNome(string nome){
            this.nome = nome;
        }

        public double GetSalario(){
            return salario;
        }

        public void SetSalario(double salario){
            this.salario = salario;
        }

        public Funcionario(){
            this.nome = "";
            this.salario = 0;
            Console.WriteLine("Funcionario.Construtor");
        }

        public Funcionario(string nome, double salario){
            this.nome = nome;
            this.salario = salario;
            Console.WriteLine("Funcionario.Construtor");
        }

        public virtual double GetBonificacao(){
            return salario * 0.2;
        }
    }
}