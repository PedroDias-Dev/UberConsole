namespace Aula13Uber
{
    public class Passageiro : Usuario
    {
        public string SolicitarMotorista(){
            return "Procurando motorista ...";
        }

        public bool Pagar(string StatusCorrida){
            if (StatusCorrida == "Finalizada"){
                return true;
            }
            return false;
        }
    }
}