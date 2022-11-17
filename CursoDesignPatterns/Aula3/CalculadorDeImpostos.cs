﻿namespace CursoDesignPatterns.Aula3
{
    public class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, TemplateDeImpostoCondicional imposto)
        {
            var resultado = imposto.Calcula(orcamento);
            Console.WriteLine(resultado);
        }

        /*
        public void RealizaCalculoICMS(Orcamento orcamento)
        {
            double icms = new ICMS().CalculaICMS(orcamento);
            Console.WriteLine(icms);
        }

        public void RealizaCalculoISS(Orcamento orcamento)
        {
            double iss = new ISS().CalculaIss(orcamento);
            Console.WriteLine(iss);
        }
        */

    }
}
