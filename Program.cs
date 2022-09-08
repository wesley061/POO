using POO.Banco;
using POO.Confeccao;

namespace POO{

    class Program
    {
        static void Main(string[] args)
        {
            Cliente maria = new Cliente();
            maria.SetCpf("123456789-10");
            maria.SetNome("Mariazinha");
            maria.SetProfissao("Programadora");
            
            ContaCorrente conta1 = new ContaCorrente();
            conta1.SetTitular(maria);
            conta1.SetConta("654321-7");
            conta1.SetNumeroAgencia(123);
            conta1.SetNomeAgencia("Agencia central DV");
            conta1.SetSaldo(100);

            /*
            ContaCorrente conta2 = new ContaCorrente();
            conta2.SetTitular("Joaozinho");
            conta2.SetConta("123456-7");
            conta2.SetNumeroAgencia(123);
            conta2.SetNomeAgencia("Agencia central DV");
            conta2.SetSaldo(0);
            */

            //conta1.Transferir(160, conta2);
            conta1.DadosConta();
        }
    }
}