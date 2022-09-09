namespace POO{
    public class Diretor:Funcionario{
        
        public Diretor(string nome, double salario):base(nome, salario){
            Console.WriteLine("Diretor.Construtor");
        }

        public override double GetBonificacao(){
            return salario * 0.5;
        }
    }
}