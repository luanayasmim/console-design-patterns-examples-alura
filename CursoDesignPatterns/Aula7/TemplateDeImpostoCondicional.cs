﻿namespace CursoDesignPatterns.Aula7
{
    public abstract class TemplateDeImpostoCondicional: Imposto
    {

        public TemplateDeImpostoCondicional(Imposto outroImposto) : base(outroImposto)
        {
        }

        public TemplateDeImpostoCondicional() : base()
        {
        }

        public override double Calcula(Orcamento orcamento)
        {
            if (DeveUsarMaximaTaxacao(orcamento))
                return MaximaTaxacao(orcamento) + CalculoDoOutroImposto(orcamento);

            return MinimaTaxacao(orcamento) + CalculoDoOutroImposto(orcamento);

        }

        public abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
        public abstract double MaximaTaxacao(Orcamento orcamento);
        public abstract double MinimaTaxacao(Orcamento orcamento);
    }
}
