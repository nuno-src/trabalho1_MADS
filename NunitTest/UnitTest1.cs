using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using reg_sinais;



namespace NunitTest
{
    public class Tests
    {


        //Sinal sin = new Sinal(345, "Maia", 543654, 3456, new System.DateTime(12/03/2012), new System.DateTime(10 / 11 / 2015));

        [Test]
        public void Test_adicionar_na_lista()
        {


            //Sinal sin = new Sinal(345, "Maia", 543654, 3456, new System.DateTime(12 / 03 / 2012), new System.DateTime(10 / 11 / 2015));

            Sistema.Adicionar(345, "Maia", 543654, 3456, true, new System.DateTime(2012, 03, 12));

            // Assert.AreEqual(true, Sistema.Adicionar(345, "Maia", 543654, 3456, new System.DateTime(12 / 03 / 2012), new System.DateTime(10 / 11 / 2015)));
            //Assert.AreEqual(1, Sistema.lista_sinais);
            Assert.IsNotEmpty(Sistema.lista_sinais);
        }
    }
}