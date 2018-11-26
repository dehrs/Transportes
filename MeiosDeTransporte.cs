using System;
using System.Collections.Generic;
using System.Text;

namespace Transporte
{
    public abstract class  MeiosDeTransporte
    {
        public string nome;
        public string marca;
        public string modelo;
        public int capacidade;


        public MeiosDeTransporte()
        {
            nome = "Sem nome";
            marca = "Sem marca";
            modelo = "Sem Modelo";
            capacidade = 0;
        }

        public MeiosDeTransporte(string nom, string mar, string mod, int capac)
        {
            nome = nom;
            marca = mar;
            modelo = mod;
            capacidade = capac;
        }


        public virtual void VerificarAbastecer(int qtd)
        {
            if (qtd<0)
            {
                throw new TanqueException();
            }

      
        }

        public virtual void Abastecer(int x)
        {
            try
            {
                VerificarAbastecer(x);
            }
            catch (TanqueException ex)
            {
                Console.WriteLine(ex.Message, "Abastecer");
            }

        }

        public virtual void Locomocao( string velHR, string Tipo)
        {
            //aplicação nas classes filhas
        }

        public virtual void Locomocao(string Tipo)
        {
            //aplicação nas classes filhas
        }

        public abstract void TempodeManutencao(int tempoUso, string Tipo);
    }
}
