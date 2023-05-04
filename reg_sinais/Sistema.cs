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

        public static void Adicionar(int id, string toponomia, int numero, int referencia, DateTime dt_col, DateTime dt_remo)
        {
            Sinal s = new Sinal(id, toponomia, numero, referencia, dt_col, dt_remo);


            lista_sinais.Add(s);

            //return true;
        }

    }
}
