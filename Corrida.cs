namespace Aula13Uber
{
    public class Corrida
    {
        public string localInicio { get; set; }
        public string localChegada { get; set; }
        public string StatusCorrida { get; set; }
        public string motorista { get; set; }
        public string passageiro { get; set; }

        public string Cancelar(){
            return "Esta corrida foi cancelada.";
        }
    }
}