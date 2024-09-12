// public class Whatsapp{
//     public Contatinho Contatos{ get; set; }
//     public Mensagem Mensagens{ get; set; }

//     public Whatsapp(Contatinho contatos, Mensagem mensagens){
//         Contatos = contatos;
//         Mensagens = mensagens;
//     }

//     public void listarContatos(){

//     }

//     public void listarMensagens(){

//     }
    
// }
public class Whatsapp
{
    public List<Contatinho> Contatos { get; set; }
    public List<Mensagem> Mensagens { get; set; }
    //Optei por usar arraylist em ambos para ter múltiplos contatos e múltiplas mensagens
    public Whatsapp(List<Contatinho> contatos, List<Mensagem> mensagens)
    {
        Contatos = contatos;
        Mensagens = mensagens;
    }

    public void listarContatos()
    {
        if (Contatos == null || Contatos.Count == 0)
        {
            Console.WriteLine("Nenhum contato encontrado.");
            return;
        }

        Console.WriteLine("Contatos:");
        foreach (var contato in Contatos)
        {
            Console.WriteLine($"Nome do contato: {contato.Nome} - Telefone do contato: {contato.Celular}"); // Assumindo que Contatinho tem um ToString() apropriado
        }
    }

    public void listarMensagens()
    {
        if (Mensagens == null || Mensagens.Count == 0)
        {
            Console.WriteLine("Nenhuma mensagem encontrada.");
            return;
        }

        Console.WriteLine("Mensagens:");
        foreach (var mensagem in Mensagens)
        {
            mensagem.toString(); // Assumindo que Mensagem e suas subclasses têm um ToString() apropriado
        }
    }
}
