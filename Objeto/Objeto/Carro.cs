namespace Objeto
{
    internal class Carro : IMaquina
    {
        public void ligar() { Console.WriteLine("Ligar carro"); }
        public void desligar() { Console.WriteLine("Desligar carro, até amanha"); }
    }
}
