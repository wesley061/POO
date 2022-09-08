namespace POO{
    public class Cliente{
        private string cpf = "";
        private string nome = "";
        private string profissao = "";

        public string GetCpf(){
            return cpf;
        }

        public void SetCpf(string cpf){
            this.cpf = cpf;
        }

        public string GetNome(){
            return nome;
        }

        public void SetNome(string nome){
            this.nome = nome;
        }

        public string GetProfissao(){
            return profissao;
        }

        public void SetProfissao(string profissao){
            this.profissao = profissao;
        }
    }
}