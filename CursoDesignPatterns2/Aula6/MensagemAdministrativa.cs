﻿namespace CursoDesignPatterns2.Aula6
{
    public class MensagemAdministrativa : IMensagem
    {
        private string? nome;
        public IEnviador Enviador { get; set; }

        public MensagemAdministrativa(string nome) => this.nome = nome;

        public void Envia() => this.Enviador.Envia(this);

        public string Formata() => string.Format("Enviando a mensagem para o administrador {0}", nome);
    }
}
