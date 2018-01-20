using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Eronaldo
{
    class Marca
    {
        public int codMarca { get; set; }
        public string nomeMarca { get; set; }
        public string pais { get; set; }
        public List<Carro> carros { get; set; }

        public Marca(int codMarca, string nomeMarca, string pais)
        {
            this.codMarca = codMarca;
            this.nomeMarca = nomeMarca;
            this.pais = pais;
            carros = new List<Carro>();
        }

        public void addCarro(Carro c)
        {
            carros.Add(c);
            carros.Sort();
        }


        public override string ToString()
        {
            return codMarca + ", " + nomeMarca + ", País: " + pais + ", Número de carros: " + carros.Count;
        }
    }
}
