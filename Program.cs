using System.Formats.Asn1;
using System.Runtime.InteropServices;
using System.Security.Authentication;

Console.WriteLine("olá usuario, me chamo lucas");
Console.Write("primeiro texto");
Console.WriteLine("segundo texto");
Console.Write("terceiro texto");
Console.Clear();
Console.Beep(1320, 200);
Console.Beep(1485, 200);
Console.Beep(1650, 200);
Console.Beep(1759, 200);
Thread.Sleep(0300);
Console.Beep(1759, 200);
Console.Beep(1759, 200);
Thread.Sleep(0300);
Console.Beep(1320, 200);
Console.Beep(1485, 200);
Console.Beep(1320, 200);
Console.Beep(1485, 200);
Thread.Sleep(0300);
Console.Beep(1485, 200);
Console.Beep(1485, 200);
Thread.Sleep(0300);
Console.Beep(1320, 200);
Console.Beep(1980, 200);
Console.Beep(1759, 200);
Console.Beep(1650, 200);
Thread.Sleep(0300);
Console.Beep(1650, 200);
Console.Beep(1650, 200);
Thread.Sleep(0300);
Console.Beep(1320, 200);
Console.Beep(1485, 200);
Console.Beep(1650, 200);
Console.Beep(1759, 200);
Thread.Sleep(0300);
Console.Beep(1759, 200);
Console.Beep(1759, 200);
Console.Write("gostou da musica?");
string resposta = Console.ReadLine()
.ToLower()
.Trim();    // remove espaços

resposta = resposta.Replace("ã", "a");

if (resposta == "sim")
{
    Console.WriteLine("fico feliz que tenha gostado");
}
else if (resposta == "nao" )
{
    Console.WriteLine("que pena que não gostou");
}