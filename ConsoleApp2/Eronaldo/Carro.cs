using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp2.Eronaldo
{
    class Carro : IComparable
    {
        public int codCarro { get; set; }
        public string modelo { get; set; }
        public int ano { get; set; }
        public double precoBasico { get; set; }
        public List<Acessorio> acessorios { get; set; }
        public Marca marca { get; set; }

        public Carro(int codCarro, string modelo, int ano, double precoBasico, Marca marca)
        {
            this.codCarro = codCarro;
            this.modelo = modelo;
            this.ano = ano;
            this.precoBasico = precoBasico;
            this.marca = marca;
            acessorios = new List<Acessorio>();
        }

        public double precoTotal()
        {
            double soma = precoBasico;
            for (int i = 0; i < acessorios.Count; i++)
            {
                soma += acessorios[i].preco;
            }
            return soma;
        }

        public override string ToString()
        {
            String s = codCarro + ", " + modelo + ", Ano: " + ano
                + ", Preço básico: " + precoBasico.ToString("F2", CultureInfo.InvariantCulture)
                + ", Preço total: " + precoTotal().ToString("F2", CultureInfo.InvariantCulture);
            if (acessorios.Count > 0)
            {
                s += "\nAcessórios:\n";
                for (int i = 0; i < acessorios.Count; i++)
                {
                    s += acessorios[i];
                }
            }
            return s;
        }

        public int CompareTo(object obj)
        {
            Carro outro = (Carro)obj;
            int resultado = modelo.CompareTo(outro.modelo);
            if (resultado != 0)
            {
                return resultado;
            }
            else
            {
                return -precoTotal().CompareTo(outro.precoTotal());
            }
        }
    }
}
