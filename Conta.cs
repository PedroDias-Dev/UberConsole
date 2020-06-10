using System;

namespace Aula13Uber
{
    public class Conta
    {
        public string agencia { get; set; }
        public string conta { get; set; }
        public string Cadastrar(){
            Console.WriteLine("Digite o seu nome:");
            string titular = Console.ReadLine();

            Console.WriteLine("Sua conta é: 2465 2435 3453 7967 ");
            Console.WriteLine("Sua agencia é: Itaú ");

            return "Cadastro concluído com sucesso!";
        }
        public void Excluir(){
            Console.WriteLine("Esta conta foi excluida com sucesso!");
        }
    }
}