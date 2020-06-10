using System;

namespace Aula13Uber
{
    public class Cartao
    {
        public string numero { get; set; }
        public string titular { get; set; }
        public string bandeira { get; set; }
        public string cvv { get; set; }

        public string Cadastrar(){
            Console.WriteLine("Digite o seu nome:");
            string titular = Console.ReadLine();

            Console.WriteLine("Seu número é: 2465 2435 3453 7967 ");
            Console.WriteLine("Sua bandeira é: Visa");
            Console.WriteLine("Seu CVV é: 254");
            return "Cadastro concluído com sucesso!";
        }
        public void Excluir(){
            Console.WriteLine("Esta conta foi excluida com sucesso!");
        }
    }
}