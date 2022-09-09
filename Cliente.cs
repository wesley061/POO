namespace POO{
    public class Cliente{
        private string cpf = "";
        public string Nome{ get; set; }
        public string Profissao{ get; set; }

        public static int QtdClientes{ get; set; }

        public string Cpf{
            get{
                return cpf;
            }
            private set{
                this.cpf = value;
            }
        }

        public Cliente(string cpf){
            this.cpf = cpf;
            this.Nome = "";
            this.Profissao = "";
            QtdClientes ++;
        }

        public Cliente(string cpf, string nome){
            this.cpf = cpf;
            this.Nome = nome;
            this.Profissao = "";
            QtdClientes ++;
        }
    }
}