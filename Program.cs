using System;
using DesafioPOO.Models; // Certifique-se de que o namespace esteja correto

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de uso das classes Nokia e Iphone
            Nokia nokiaPhone = new Nokia("123456789", "Nokia Modelo XYZ");
            Iphone iphonePhone = new Iphone("987654321", "iPhone Modelo ABC");

            nokiaPhone.InstalarAplicativo("WhatsApp");
            iphonePhone.InstalarAplicativo("Facebook");
        }
    }
}
