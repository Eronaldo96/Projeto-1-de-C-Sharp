using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp2.Eronaldo
{
    class Tela
    {
        public static void mostrarMenu()
        {
            Console.WriteLine("1 – Listar marcas");
            Console.WriteLine("2 – Listar carros de uma marca ordenadamente");
            Console.WriteLine("3 – Cadastrar marca");
            Console.WriteLine("4 – Cadastrar carro");
            Console.WriteLine("5 – Cadastrar acessório");
            Console.WriteLine("6 – Mostrar detalhes de um carro");
            Console.WriteLine("7 – Sair");
            Console.Write("Escolha uma opção:");
        }

        public static void mortrarMarcas()
        {
            Console.WriteLine("LISTAGEM DE MARCAS:");
            for (int i = 0; i < Program.marca.Count; i++)
            {
                Console.WriteLine(Program.marca[i]);
            }
            Console.WriteLine();
        }

        public static void mostrarCarrosDeUmaMarca()
        {
            Console.WriteLine("Digite o código da marca: ");
            int codMarca = int.Parse(Console.ReadLine());
            int pos = Program.marca.FindIndex(x => x.codMarca == codMarca);
            if (pos == -1)
            {
                throw new ModelException("Código da marca do carro não foi encontrada: " + codMarca);
            }

            Console.WriteLine("Carros da marca" + Program.marca[pos].nomeMarca + ":");
            List<Carro> lista = Program.marca[pos].carros;
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }

            Console.WriteLine();
        }

        public static void cadastrarMarca()
        {
            Console.WriteLine("Digite os dados da marca:");
            Console.Write("Código: ");
            int codMarca = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            String nome = Console.ReadLine();
            Console.Write("País de origem: ");
            String pais = Console.ReadLine();

            Marca M = new Marca(codMarca, nome, pais);

            Program.marca.Add(M);

            Console.WriteLine("Cadastro Concluído");
        }

        public static void cadastrarCarro()
        {
            Console.WriteLine("Digite os dados do carro:");
            Console.Write("Marca (código): ");
            int codMarca = int.Parse(Console.ReadLine());
            int pos = Program.marca.FindIndex(x => x.codMarca == codMarca);
            if (pos == -1)
            {
                throw new ModelException("Código da marca do carro não foi encontrada: " + codMarca);
            }
            Console.Write("Código do carro: ");
            int codCarro = int.Parse(Console.ReadLine());
            Console.Write("Modelo: ");
            String modelo = Console.ReadLine();
            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());
            Console.WriteLine("Preço básico: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Marca M = Program.marca[pos];
            Carro C = new Carro(codCarro, modelo, ano, preco, M);

            M.addCarro(C);

            Program.carro.Add(C);

            Console.WriteLine("Cadastro Concluído");
        }

        public static void cadastrarAcessorio()
        {
            Console.WriteLine("Digite os dados do acessório:");
            Console.WriteLine("Carro (código): ");
            int codCarro = int.Parse(Console.ReadLine());
            int pos = Program.carro.FindIndex(x => x.codCarro == codCarro);
            if (pos == -1)
            {
                throw new ModelException("Código do carro não foi encontrado: " + codCarro);
            }
            Console.WriteLine("Descrição: ");
            string descricao = Console.ReadLine();
            Console.WriteLine("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Carro C = Program.carro[pos];

            Acessorio A = new Acessorio(descricao, preco, C);

            C.acessorios.Add(A);
            Console.WriteLine("Cadastro Concluído");
        }
        public static void detalhesCarro()
        {
            Console.Write("Digite o código do carro: ");
            int codCarro = int.Parse(Console.ReadLine());
            int pos = Program.carro.FindIndex(x => x.codCarro == codCarro);
            if (pos == -1)
            {
                throw new ModelException("Código do carro não foi encontrado: " + codCarro);
            }


            Console.WriteLine(Program.carro[pos]);
        }
    }
}
