using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reg_sinais
{
    internal class sinal
    {
        private int id;
        private string toponomia;
        private int numero; // apenas para sinais com numeros
        private int referencia; // codigo do site Infra estruturas
        private DateTime data_colocacao;
        private DateTime data_removido;

        /*
         
            Acerca de cada sinal vertical (não luminoso) guarda-se a seguinte informação (estática):
                identificador único no sistema da empresa;
                uma referência para o código de sinal (disponível em
                https://servicos.infraestruturasdeportugal.pt/pt-pt/parceiros/normas-desinalizacao/sinais-de-alerta);
                valor nomimal (no sinais com números);
                referência ao identificador da EN ou toponímia;
                data inicial - data de colocação no terreno (ou na falta, data do primeiro
                levantamento);
                data fim - data quando o sinal foi removido/perdido.


            Acerca de cada sinal vertical (não luminoso) guarda-se a seguinte informação
            temporal, ou seja, associada a cada levantamento ou vistoria:
                referência à vistoria;
                índice de qualidade [0..3];
                perdido/removido (V/F).

            Uma vistoria, tem:
                um identificador único;
                uma data (dia único);
                a equipa de pessoas que a compunha
         
         
         */

        // contrutores:
        public sinal()
        {
            id = 0;
            toponomia = "";
            numero = 0;
            referencia = 0;
            data_colocacao = new DateTime();
            data_removido = new DateTime();

        }

        public sinal(int nid, string ntoponomia, int nnumero, int nreferencia, DateTime ndt_col, DateTime ndt_remo)
        {
            id = nid;
            toponomia = ntoponomia;
            numero = nnumero;
            referencia = nreferencia;
            data_colocacao = ndt_col;
            data_removido = ndt_remo;

        }



        public int Id { get => id; set => id = value; }
        public string Toponomia { get => toponomia; set => toponomia = value; }



    }
}
