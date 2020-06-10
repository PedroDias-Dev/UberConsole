using System;

namespace Aula13Uber
{
    class Program
    {
        static void Main(string[] args)
        {
            Passageiro pedro = new Passageiro();
            Console.WriteLine("Digite seu login:");
            string login = Console.ReadLine();

            Console.WriteLine("Digite sua senha:");
            string senha = Console.ReadLine();

            pedro.Login(login, senha);

            if (pedro.TokenLogin != "" && pedro.TokenLogin != null){
                Console.WriteLine("Login Autorizado!");
                Console.WriteLine(pedro.TokenLogin);

            }
            else {
                Console.WriteLine("Login e Senha incorretos.");
                System.Environment.Exit(0); 
                
            }

            

            
        }
    }
}
