using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp2.Eronaldo
{
    class Acessorio
    {
        public string nomeAcessorio { get; set; }
        public double preco { get; set; }
        public Carro carro { get; set; }

        public Acessorio(string nomeAcessorio, double preco, Carro carro)
        {
            this.nomeAcessorio = nomeAcessorio;
            this.preco = preco;
            this.carro = carro;
        }

        public override string ToString()
        {
            return nomeAcessorio
                + ", Preço: " + preco.ToString("F2", CultureInfo.InvariantCulture);
                
        }
    }
}
