namespace Objeto
{
    internal class Fantasma: IPairador
    {
        public void pairar() { Console.WriteLine("O fantasma esta passando"); }
        public void Voar() { Console.WriteLine("Fantasma esta vindo para ca"); }
        public void decolar() { Console.WriteLine("Fatasma vai voar"); }
        public void pousar() { Console.WriteLine("Fantasma vai parar"); }
    }
}
