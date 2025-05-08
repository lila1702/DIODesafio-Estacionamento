using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace DIOChallenge___Estacionamento.Models
{
    public class Veiculo
    {
        public string Placa { get; set; }
        public string Motorista { get; set; }

        public bool CheckPlacaVálida(string placa)
        {
            if (placa == null) return false;
            if (placa.Length != 8) return false;

            for (int i = 0; i < placa.Length; i++)
            {
                if (i < 3)
                {
                    if (!char.IsLetter(placa[i])) return false;
                }
                else if (i == 3)
                {
                    if (placa[i] != '-') return false;
                }
                else if(i > 3)
                {
                    if (!char.IsDigit(placa[i])) return false;
                }
            }
            
            return true;
        }
        
    }
}
