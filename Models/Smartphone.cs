using System;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // Propriedades comuns a todos os smartphones
        public string Numero { get; set; }

        // Construtor para inicializar o número do smartphone
        public Smartphone(string numero)
        {
            Numero = numero;
        }

        // Método abstrato que deve ser implementado pelas subclasses
        public abstract void InstalarAplicativo(string nomeApp);

        // Métodos comuns a todos os smartphones
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }
    }
}
