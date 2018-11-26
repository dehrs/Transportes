using System;
using System.Collections.Generic;
using System.Text;

namespace Transporte
{
    public class Aquatico: MeiosDeTransporte, IPodeFlutuar
    {
        private int qtdMotores;

        public Aquatico(int qtdMotor, string nom, string mar, string mod, int capac):base(nom,mar,mod,capac)
        {
            qtdMotores = qtdMotor;
        }


        public void Flutuar()
        {
            Console.WriteLine("Estou flutuando");
        }

        public override void TempodeManutencao(int tempoUso, string Tipo)
        {
            if (tempoUso <= 0)
            {
                throw new Exception(" Não é preciso realizar manutenção");
            }
            
            if(tempoUso> 5 && Tipo == "Luxo")
            {
                Console.WriteLine("Será preciso realizar manutenção");
            }
            else if (tempoUso>10 && Tipo == "Comum")
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
