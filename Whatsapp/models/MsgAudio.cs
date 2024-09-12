class MsgAudio : Mensagem{
    public int Duracao{ get; set; }

    public MsgAudio(Contatinho destinatario, string horaEnvio, string conteudo, int duracao) : base(destinatario, horaEnvio, conteudo){
        Duracao = duracao;

    }
    public override void toString()
    {
        Console.WriteLine($"Mensagem de áudio - {Duracao} minutos de duração - Enviada para: {Destinatario.Nome} - Hora: {HoraEnvio} - Conteúdo: {Conteudo}");
    }
}


    