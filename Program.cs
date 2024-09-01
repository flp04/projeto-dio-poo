using System;
using DesafioPOO.Models;

class Program
{
  static void Main(string[] args)
  {
    Nokia aparelho1 = new("11995875266", "Azul", "123456789", 8);
    Iphone aparelho2 = new("11958234678", "Preto", "987654321", 4);
    aparelho1.Ligar();
    aparelho2.ReceberLigacao();
    aparelho2.Ligar();
    aparelho1.ReceberLigacao();
    aparelho1.InstalarAplicativo("WhatsApp");
    aparelho2.InstalarAplicativo("WhatsApp");
  }
}

// TODO: Realizar os testes com as classes Nokia e Iphone
