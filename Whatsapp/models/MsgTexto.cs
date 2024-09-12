class MsgTexto : Mensagem{
    public int NumChar{ get; set; }

    public MsgTexto(Contatinho destinatario, string horaEnvio, string conteudo, int numChar) : base(destinatario, horaEnvio, conteudo){
        NumChar = numChar;

    }
    public override void toString()
    {
        Console.WriteLine($"Mensagem de texto - {NumChar} caracteres - Enviada para: {Destinatario.Nome} - Hora: {HoraEnvio} - Conteúdo: {Conteudo}");
    }
}


    