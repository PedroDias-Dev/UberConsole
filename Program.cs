using System;

namespace Aula13Uber
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("||ESTE PROGRAMA É APENAS UM TESTE||");


            Console.WriteLine("Login:");
            Passageiro pedro = new Passageiro();
            Console.WriteLine("Digite seu login:");
            string login = Console.ReadLine();

            Console.WriteLine("Digite sua senha:");
            string senha = Console.ReadLine();

            pedro.Login(login, senha);

            if (pedro.TokenLogin != "" && pedro.TokenLogin != null){
                Console.WriteLine("Login Autorizado!");
                Console.WriteLine(pedro.TokenLogin);
                pedro.LocalizacaoAtual = "Rua Carl Johnson, Groove Street";

                Motorista Joao = new Motorista();
                Joao.carro = "Ford KA";
                Joao.placa = "ABC-2222";


                Console.WriteLine("Corrida:");
                Corrida corrida = new Corrida();
                corrida.localInicio = pedro.LocalizacaoAtual;
                Console.WriteLine("Para onde deseja ir?");
                corrida.localChegada = Console.ReadLine();

                Console.WriteLine("-- Informações da Corrida --");
                Console.WriteLine("Motorista: Joao");
                Console.WriteLine("Passageiro: Pedro" );
                Console.WriteLine("Início: " +pedro.LocalizacaoAtual);
                Console.WriteLine("Final: " +corrida.localChegada);

                pedro.SolicitarMotorista();

                Joao.AceitarPassageiro("Pedro");

                
                Console.WriteLine("Corrida finalizada!");
                pedro.LocalizacaoAtual = corrida.localChegada;

                corrida.StatusCorrida = "Finalizada";
                pedro.Pagar(corrida.StatusCorrida);

                Pagamento pagamento = new Pagamento();

                Console.WriteLine("Confirme a data de pagamento:");
                pagamento.data = DateTime.Parse(Console.ReadLine());

                Joao.ReceberPagamento(corrida.StatusCorrida);
                pagamento.status = "Confirmado";


                Console.WriteLine("Conta:");
                Conta conta = new Conta();
                conta.agencia = "Itaú";
                conta.conta = "2465 2435 3453 7967";
                conta.Cadastrar();
                conta.Excluir();

                Console.WriteLine("Cartão:");
                Cartao cartao = new Cartao();
                cartao.cvv = "555";
                cartao.numero = "2345 4324 5345 6564";
                cartao.titular = "Pedrinho Gamer";
                cartao.bandeira = "Visa";

                cartao.Cadastrar();
                cartao.Excluir();

                Console.WriteLine("Obrigado por usar nosso console, até a próxima!");

            }
            else {
                Console.WriteLine("Login e Senha incorretos.");
                System.Environment.Exit(0); 
                
            }

            

            
        }
    }
}
