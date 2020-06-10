namespace Aula13Uber
{
    public class Motorista
    {
        public string carro { get; set; }
        public string placa { get; set; }

        public string AceitarPassageiro( string nome ){
            return $"A corrida com {nome} foi confirmada.";
        }
        public bool ReceberPagamento(string StatusCorrida){
            if (StatusCorrida == "Finalizada"){
                return true;
            }
            return false;
        }
    }
}