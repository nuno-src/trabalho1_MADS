using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reg_sinais
{
    internal class Program
    {
        private List<sinal> lista_sinais = new List<sinal>();
        static void Main(string[] args)
        {

            //private List<sinal> lista_sinais = new List<sinal>();


            int op = 9;
            while (op != 0)
            {
                Console.WriteLine("\n-------------------MENU-----------------");
                Console.WriteLine(" 1) - Adicionar sinal");
                
                
                Console.WriteLine(" 0) - Sair");
                Console.WriteLine("------------------------------------------");


                Console.Write("Escolha uma opção:");

                op = int.Parse(Console.ReadLine());

                switch (op)
                {

                    //case 1: Remover_recluso(); break;
                    
                    case 0: Environment.Exit(0); break;




                    default:
                        Console.WriteLine("OPÇÃO ERRADA");
                        break;


                }

            }






        }



        static void Adicionar_sinal()
        { 
        
        
        }










    }
}
