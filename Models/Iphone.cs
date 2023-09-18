using System;

namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        // Propriedades específicas do iPhone, se houverem
        public string Modelo { get; set; }

        public Iphone(string numero, string modelo) : base(numero)
        {
            Modelo = modelo;
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            // Implemente a lógica específica para instalar aplicativos em um iPhone, se necessário.
            Console.WriteLine($"Instalando {nomeApp} na loja de aplicativos da Apple para o iPhone modelo {Modelo}.");
        }
    }
}
