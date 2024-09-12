class MsgFoto : Mensagem{
    public int Tamanho{ get; set; }

    public MsgFoto(Contatinho destinatario, string horaEnvio, string conteudo, int tamanho) : base(destinatario, horaEnvio, conteudo){
        Tamanho = tamanho;

    }
    public override void toString()
    {
        Console.WriteLine($"Mensagem de foto - Tamanho de {Tamanho} MB - Enviada para {Destinatario.Nome} - Hora: {HoraEnvio} - Conteúdo: {Conteudo}");
    }
}


    