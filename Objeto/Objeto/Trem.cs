namespace Objeto
{
    internal class Trem : IMaquina
    {
        public void ligar() { Console.WriteLine("ligando trem"); }
        public void desligar() { Console.WriteLine("Desligando o tem, hora de ir embora dormir"); }
    }
}