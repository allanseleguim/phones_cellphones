using System;

namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        // Propriedades específicas do Nokia, se houverem
        public string Modelo { get; set; }

        public Nokia(string numero, string modelo) : base(numero)
        {
            Modelo = modelo;
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            // Implemente a lógica específica para instalar aplicativos em um dispositivo Nokia, se necessário.
            Console.WriteLine($"Instalando {nomeApp} na loja de aplicativos da Nokia para o modelo {Modelo}.");
        }
    }
}
