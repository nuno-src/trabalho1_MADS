using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reg_sinais
{
    public static class Sistema
    {
        public static List<Sinal> lista_sinais = new List<Sinal>();

        //public static Sistema()
        //{ 
        
        //}

        public static void Adicionar(int id, string toponomia, int numero, int referencia, bool estado, DateTime dt_col)
        {
            Sinal s = new Sinal(id, toponomia, numero, referencia, estado, dt_col);


            lista_sinais.Add(s);

            //return true;
        }

    }
}
