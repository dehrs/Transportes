using System;
using System.Collections.Generic;
using System.Text;

namespace Transporte
{
     public class Aereo: MeiosDeTransporte, IPodeVoar
    {
        private int qtdAsas;

        public Aereo(int qtdAsa, string nom, string mar, string mod, int capac):base(nom,mar,mod, capac)
        {
            qtdAsas = qtdAsa;
        }

        public void Voar()
        {
            Console.WriteLine("Estou voando");
        }

        public override void TempodeManutencao(int tempoUso, string Tipo)
        {

            if (tempoUso <= 0)
            {
                throw new Exception(" Não é preciso realizar manutenção");
            }

            if (tempoUso > 5 && Tipo == "Helicoptero")
            {
                Console.WriteLine("Será preciso realizar manutenção");
            }
            else if (tempoUso > 10 && Tipo == "Aviao")
            {
                Console.WriteLine("Será preciso realizar manutenção");
            }
            else
            {
                Console.WriteLine("Não é preciso realizar manutenção");
            }
        }
    }
}
