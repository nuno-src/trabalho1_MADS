﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reg_sinais
{
    internal class Program
    {
        public static List<sinal> lista_sinais = new List<sinal>();
        static void Main(string[] args)
        {

            //private List<sinal> lista_sinais = new List<sinal>();


            int op = 9;
            while (op != 0)
            {
                Console.WriteLine("\n-------------------MENU-----------------");
                Console.WriteLine(" 1) - Adicionar sinal");
                Console.WriteLine(" 2) - Editar sinal");
                Console.WriteLine(" 3) - Remover sinal");
                Console.WriteLine(" 4) - Consultar sinais");
                Console.WriteLine(" 5) - Atualizar estado do sinal");


                Console.WriteLine(" 0) - Sair");
                Console.WriteLine("------------------------------------------");


                Console.Write("Escolha uma opção:");

                op = int.Parse(Console.ReadLine());

                switch (op)
                {

                    case 1: Adicionar_sinal(); break;
                    case 4: Consultar_sinais(); break;

                    case 0: Environment.Exit(0); break;




                    default:
                        Console.WriteLine("OPÇÃO ERRADA");
                        break;


                }

            }






        }



        static void Adicionar_sinal()
        {


            Console.Write("Insira o ID:");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Insira a toponomia:");
            string toponomia = Console.ReadLine();

            Console.Write("Insira o numero do sinal:");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Insira a referencia:");
            int referencia = int.Parse(Console.ReadLine());

            Console.Write("Insira a data de colocação:");
            DateTime dt_col = DateTime.Parse(Console.ReadLine());


            Console.Write("Insira a data de remoção:");
            DateTime dt_remo = DateTime.Parse(Console.ReadLine());
            //DateTime dt_remo = null;



            sinal s = new sinal(id, toponomia, numero, referencia, dt_col, dt_remo);


            lista_sinais.Add(s);




            Console.WriteLine("\nSinal registado com sucesso!");

        }




        static void Consultar_sinais()
        {

            foreach (sinal f in lista_sinais)
            {
                Console.WriteLine($"{f.Id} , {f.Toponomia}");

            }




        }





    }
}
