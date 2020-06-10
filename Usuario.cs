namespace Aula13Uber
{
    public class Usuario
    {

        public int Nome { get; set; }
        private int idade;
        public int Idade
        {
            get { return idade; }
            set { 
                if (idade >= 0){
                    idade = value;
                }
             }
        }

        public string Foto { get; set; }
        public string login = "predo@gmail.com";
        public string senha = "saas";

        public string LocalizacaoAtual { get; set; }
        public string TokenLogin { get; set; }

        public bool Login(string login, string senha){
            if (this.login == login && this.senha == senha){
                TokenLogin = "8w6gr8v39bg9283rb6v";
                return true;
            }
            return false;
        }

        public void Logout(){
            TokenLogin = "";
        }
        
    }
}