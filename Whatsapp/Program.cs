public class Program
{
    public static void Main()
    {
 
        var contato1 = new Contatinho("Alice", "5192929292");
        var contato2 = new Contatinho("Bob", "67592929291");

        var mensagemTexto = new MsgTexto(contato1, "10:00", "Olá, como vai?", 15);
        var mensagemAudio = new MsgAudio(contato2, "11:00", "Mensagem de áudio", 2);
        var mensagemFoto = new MsgFoto(contato1, "12:00", "Foto do dia", 5);

        var contatos = new List<Contatinho> { contato1, contato2 };
        var mensagens = new List<Mensagem> { mensagemTexto, mensagemAudio, mensagemFoto };

        var whatsapp = new Whatsapp(contatos, mensagens);

        whatsapp.listarContatos();
        whatsapp.listarMensagens();
    }
}