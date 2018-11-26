using System;
using System.Collections.Generic;
using System.Text;

namespace Transporte
{
    public class Terrestre: MeiosDeTransporte, IPodeAndar
    {
        private int qtdRodas;

        public Terrestre(string nom, string mar, string mod, int capac, int qtdRoda):base(nom,mar,mod,capac)
        {
            qtdRodas = qtdRoda;
        }

        public void Andar()
        {
            Console.WriteLine("Estou andando");
        }

        public override void TempodeManutencao(int tempoUso, string Tipo)
        {

            if (tempoUso <= 0)
            {
                throw new Exception(" Não é preciso realizar manutenção");
            }

            if (tempoUso > 5 && Tipo == "Carro")
            {
                Console.WriteLine("Será preciso realizar manutenção");
            }
            else if (tempoUso > 8 && Tipo == "Onibus")
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
