using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Eronaldo
{
    class Program
    {
        public static List<Carro> carro = new List<Carro>();
        public static List<Marca> marca = new List<Marca>();
       
        static void Main(string[] args)
        {
            int opcao = 0;
            Marca m1 = new Marca(1001, "Volkswagen", "Alemanha");
            Marca m2 = new Marca(1002, "General Motors", "Estados Unidos");
            marca.Add(m1);
            marca.Add(m2);


            Carro c1 = new Carro(101, "Fusca", 1980, 5000.00, m1);
            m1.addCarro(c1);
            Carro c2 = new Carro(102, "Golf", 2016, 60000.00, m1);
            m1.addCarro(c2);
            Carro c3 = new Carro(103, "Fox", 2017, 30000.00, m1);
            m1.addCarro(c3);
            Carro c4 = new Carro(104, "Cruze", 2016, 30000.00, m2);
            m2.addCarro(c4);
            Carro c5 = new Carro(105, "Cobalt", 2015, 25000.00, m2);
            m2.addCarro(c5);
            Carro c6 = new Carro(106, "Cobalt", 2017, 35000, m2);
            m2.addCarro(c6);


            carro.Add(c1);
            carro.Add(c2);
            carro.Add(c3);
            carro.Add(c4);
            carro.Add(c5);
            carro.Add(c6);

            while(opcao != 7)
            {
                Console.Clear();
                Tela.mostrarMenu();
                try
                {
                    opcao = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro inesperado: " + e.Message);
                    opcao = 0;
                }
                Console.WriteLine();

                if (opcao == 1)
                {
                    Tela.mortrarMarcas();
                }
                else if (opcao == 2)
                {
                     Tela.mostrarCarrosDeUmaMarca();
                }
                else if (opcao == 3)
                {
                    try
                    {
                        Tela.cadastrarMarca();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                }
                else if (opcao == 4)
                {
                    try
                    {
                        Tela.cadastrarCarro();
                    }
                    catch (ModelException e)
                    {
                        Console.WriteLine("Falha na regra de negócios!");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                }
                else if (opcao == 5)
                {
                    try
                    {
                        Tela.cadastrarAcessorio();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                }
                else if (opcao == 6)
                {
                    try
                    {
                        Tela.detalhesCarro();
                    }
                    catch (ModelException e)
                    {
                        Console.WriteLine("Falha na regra de negócios!");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }

                }
                else if (opcao == 7)
                {
                    Console.WriteLine("Saiu!");
                }
                else
                {
                    Console.WriteLine("Erro ao escolher a opção! Digite novamente ");
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
           
        }
    }
}
