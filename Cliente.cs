namespace POO{
    public class Cliente{
        private string cpf = "";
        public string Nome{ get; set; }
        private string Profissao{ get; set; }

        public static int QtdClientes{ get; set; }

        public string Cpf{
            get{
                return cpf;
            }
            set{
                this.cpf = value;
            }
        }

        public Cliente(string cpf, string nome){
            this.cpf = cpf;
            this.Nome = nome;
            QtdClientes ++;
        }
    }
}