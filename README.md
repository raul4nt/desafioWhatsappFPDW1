# WhatsApp - Sistema de mensagens

## Descrição do Projeto

Este projeto é o **Desafio 2** da cadeira de Frameworks para Desenvolvimento Web 1. Este projeto é uma simulação básica de um sistema de mensagens em C#. O sistema foi desenvolvido para gerenciar contatos e mensagens de diferentes tipos, como áudio, texto e foto. A aplicação de console permite a criação e visualização de contatos e mensagens.

## Estrutura do Código

### Classes

1. **`Mensagem` (Abstrata)**
   - Representa uma mensagem genérica.
   - Propriedades:
     - `Destinatario`: O contato para quem a mensagem foi enviada.
     - `HoraEnvio`: A hora em que a mensagem foi enviada.
     - `Conteudo`: O conteúdo da mensagem.
   - Método:
     - `void toString()`: Método abstrato que deve ser implementado pelas subclasses para imprimir uma representação textual da mensagem no console.

2. **`Contatinho`**
   - Representa um contato no sistema.
   - Propriedades:
     - `Nome`: Nome do contato.
     - `Celular`: Número de celular do contato.

3. **`MsgAudio`**
   - Representa uma mensagem de áudio.
   - Propriedades:
     - `Duracao`: Duração do áudio em minutos.
   - Implementação do Método `toString()`: Imprime uma representação textual da mensagem de áudio, incluindo a duração e o destinatário.

4. **`MsgTexto`**
   - Representa uma mensagem de texto.
   - Propriedades:
     - `NumChar`: Número de caracteres na mensagem de texto.
   - Implementação do Método `toString()`: Imprime uma representação textual da mensagem de texto, incluindo o número de caracteres e o destinatário.

5. **`MsgFoto`**
   - Representa uma mensagem de foto.
   - Propriedades:
     - `Tamanho`: Tamanho da foto em megabytes.
   - Implementação do Método `toString()`: Imprime uma representação textual da mensagem de foto, incluindo o tamanho e o destinatário.

6. **`Whatsapp`**
   - Gerencia a lista de contatos e mensagens.
   - Propriedades:
     - `Contatos`: Lista de contatos.
     - `Mensagens`: Lista de mensagens.
   - Métodos:
     - `void ListarContatos()`: Exibe todos os contatos na lista.
     - `void ListarMensagens()`: Exibe todas as mensagens na lista.

